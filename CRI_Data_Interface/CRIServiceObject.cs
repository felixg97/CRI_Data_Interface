using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Threading;

// Configure log4net using the .config file
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace CRI_Data_Interface
{
    class CRIServiceObject
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        HardwareProtocolClient client = new HardwareProtocolClient();
        DataCollector collector = new DataCollector();

        private double[] jogValues = new double[9]; // 6 for the robot arm, 3 for the gripper - joint or cartesian [-100..100]

        // States
        private string programSelectedFilePath = "";
        private string programSelected = "";
        private bool programLoaded = false; 

        private bool dataCollectionRunning = false; 

        private bool gripperOpen = false;

        // Selections
        private string selectedOutputDir = "";
        private string selectedDatasetName = "";
        private int selectedRepetitons = 0;
        private int selectedSamplingRate = 0;

        private bool flagPosjointsetpoint = false;
        private bool flagPosjointcurrent = true;
        private bool flagPoscartrobot = true;
        private bool flagPoscartplatform = true;
        private bool flagOverride = true;
        private bool flagDindout = false;
        private bool flagEstop = false;
        private bool flagSupply = true;
        private bool flagCurrentall = true;
        private bool flagCurrentjoints = true;
        private bool flagError = false;
        private bool flagOpmode = false;
        private bool flagKinstate = true;

        private bool settingsChecked = false;

        // Collection stuff
        Thread collectionThread;

        private bool collectionStarted = false;
        private bool collectionReady = false;
        private bool collectionRunning = false;

        public CRIServiceObject()
        {
            //
        }

        /******* Getter *******/
        public bool GetFlagConnected()
        {
            return this.client.flagConnected;
        }

        public string GetProgramSelected()
        {
            return this.programSelected;
        }

        public Dictionary<string, bool> GetMessageFlags()
        {
            Dictionary<string, bool> messageFlags = new Dictionary<string, bool>
            {
                { "outAliveMessages", this.client.flagHideAliveMessages },
                { "inBasicStatusMessages", this.client.flagHideBasicStatusMessages },
                { "inFurtherStatusMessages", this.client.flagHideFurtherStatusMessages },
                { "inUnknownMessages", this.client.flagHideUnknownMessages }
            };

            return messageFlags;
        }

        public Dictionary<string, string> GetStatusInformation()
        {
            Dictionary<string, string> statusInformation = new Dictionary<string, string>
            {
                { "status", this.client.flagConnected.ToString() },
                { "error", this.client.errorString },
                { "selectedProgram", this.programSelected },
                { "programLoaded", this.programLoaded.ToString() },
                { "dataCollectionRunning", this.dataCollectionRunning.ToString() },
                { "emergencyStop", this.client.emergencyStopStatus.ToString() },
            };

            return statusInformation;
        }

        public Dictionary<string, double> GetPositions()
        {
            Dictionary<string, double> positions = new Dictionary<string, double>
            {
                { "joint1", this.client.posJointsCurrent[0] },
                { "joint2", this.client.posJointsCurrent[1] },
                { "joint3", this.client.posJointsCurrent[2] },
                { "joint4", this.client.posJointsCurrent[3] },
                { "joint5", this.client.posJointsCurrent[4] },
                { "joint6", this.client.posJointsCurrent[6] },
                { "velocityRelative", this.client.overrideValue },

                { "x", this.client.posCartesian[0] },
                { "y", this.client.posCartesian[1] },
                { "z", this.client.posCartesian[2] },
                { "a", this.client.posCartesian[3] },
                { "b", this.client.posCartesian[4] },
                { "c", this.client.posCartesian[5] },
                { "velocityAbsolute", 0.0 }
            };

            return positions;
        }

        public string GetOutputDirSelected() 
        {
            return this.selectedOutputDir;
        }

        public Dictionary<string, string> GetFixedCollectionSettings() 
        {
            Dictionary<string, string> fixedCollectionSettings = new Dictionary<string, string>
            {
                { "programName", programSelected },
                { "datasetName", this.selectedDatasetName },
                { "repetitions", Convert.ToString(this.selectedRepetitons) },
                { "samplingRate", Convert.ToString(this.selectedSamplingRate) },
                { "outputDir", this.selectedOutputDir },
            };
            return fixedCollectionSettings;
        }

        public bool GetCollectionSettingsChecked()
        {
            return this.settingsChecked;
        }

        public bool GetCollectionReadiness() 
        {
            return this.collectionReady;
        }
        
        public int GetSelectedRepetition()
        {
            return this.selectedRepetitons;
        }

        public int GetCurrentRepetition()
        {
            return this.collector.GetCurrentRepetition();
        }

        public bool IsCollectionRunning()
        {
            return this.collectionRunning;
        }

        public Dictionary<string, bool> GetDataCollectionFlags()
        {
            Dictionary<string, bool> dataCollectionFlags = new Dictionary<string, bool>
            {
                { "flagPosjointsetpoint", this.flagPosjointsetpoint },
                { "flagPosjointcurrent", this.flagPosjointcurrent },
                { "flagPoscartrobot", this.flagPoscartrobot },
                { "flagPoscartplatform", this.flagPoscartplatform },
                { "flagOverride", this.flagOverride },
                { "flagDindout", this.flagDindout },
                { "flagEstop", this.flagEstop },
                { "flagSupply", this.flagSupply },
                { "flagCurrentall", this.flagCurrentall },
                { "flagCurrentjoints", this.flagCurrentjoints },
                { "flagKinstate", this.flagKinstate },
                { "flagError", this.flagError },
                { "flagOpmode", this.flagOpmode },
            };
            return dataCollectionFlags;
        }

        /******* Setter *******/
        public void SetMessageFlag(string flagName, bool flagValue)
        {
            if (flagName.Equals("outAliveMessages"))
                this.client.flagHideAliveMessages = flagValue;
            else if (flagName.Equals("inBasicStatusMessages"))
                this.client.flagHideBasicStatusMessages = flagValue;
            else if (flagName.Equals("inFurtherStatusMessages"))
                this.client.flagHideFurtherStatusMessages = flagValue;
            else if (flagName.Equals("inUnknownMessages"))
                this.client.flagHideUnknownMessages = flagValue;
            else
                throw new Exception("Flag does not exist.");
        }

        public void SetSelectedProgramFile(string filePath) // TODO: Create and Send Program if it does not exist in this directory
        {
            this.programLoaded = false;
            this.programSelected = "";
            this.programSelectedFilePath = "";

            log.DebugFormat("Filepath selected: " + filePath);

            if (filePath.StartsWith("C:\\CPRog\\Data\\Programs"))
            {
                string[] splittedFilePath = filePath.Split('\\');

                if (splittedFilePath[splittedFilePath.Length - 2] == "Programs")
                {
                    this.programSelectedFilePath = filePath;
                    this.programSelected = splittedFilePath.Last();
                }
                else
                { // TODO: program error pop up?
                    log.Error("The program selected is in a sub directory. It has to be in the \"C:\\CPRog\\Data\\Programs\" directory");
                }
            }
            else
            { // TODO: program error pop up?
                log.Error("The program selected is not in the valid directory: C:\\CPRog\\Data\\Programs");
            }
        }

        public void SetSelectedOutputDir(string dirPath)
        {
            this.selectedOutputDir = dirPath;
        }

        public void SetCollectionFlag(string flagName, bool flagValue)
        {
            if (flagName == "flagPosjointsetpoint") this.flagPosjointsetpoint = flagValue;
            else if (flagName == "flagPosjointcurrent") this.flagPosjointcurrent = flagValue;
            else if (flagName == "flagPoscartrobot") this.flagPoscartrobot = flagValue;
            else if (flagName == "flagPoscartplatform") this.flagPoscartplatform = flagValue;
            else if (flagName == "flagOverride") this.flagOverride = flagValue;
            else if (flagName == "flagDindout") this.flagDindout = flagValue;
            else if (flagName == "flagEstop") this.flagEstop = flagValue;
            else if (flagName == "flagSupply") this.flagSupply = flagValue;
            else if (flagName == "flagCurrentall") this.flagCurrentall = flagValue;
            else if (flagName == "flagCurrentjoints") this.flagCurrentjoints = flagValue;
            else if (flagName == "flagKinstate") this.flagKinstate = flagValue;
            else if (flagName == "flagError") this.flagError = flagValue;
            else if (flagName == "flagOpmode") this.flagOpmode = flagValue;
            else throw new Exception("Flag does not exist.");
    }
    
        public void SetRepeatedStart(bool value)
        {
            if (value) this.SendCommand("StartOnRepeat");
            else this.SendCommand("StartNotOnRepeat");
        }

        /******* Collection Controls *******/
        public bool CheckIfCollectionDataSatisfied() 
        {
            if (this.programSelected == "") return false;
            else if (this.selectedOutputDir == "") return false;
            else if (this.selectedRepetitons == 0) return false;
            else if (this.selectedSamplingRate == 0) return false;

            this.settingsChecked = true;
            return true;
        }

        public void SetCollectionSettings(string outputDir, string programPath, string datasetName, int repetitions, int samplingRate)
        {
            this.programSelected = programPath;
            this.selectedOutputDir = outputDir;
            this.selectedDatasetName = datasetName;
            this.selectedRepetitons = repetitions;
            this.selectedSamplingRate = samplingRate;

            this.settingsChecked = false;

            this.programLoaded = false;
            this.LoadProgram();
        }

        public void ClearCollectionSettings()
        {
            this.programSelected = "";
            this.programSelectedFilePath = "";
            this.selectedOutputDir = "";
            this.selectedRepetitons = 0;
            this.selectedSamplingRate = 0;

            this.settingsChecked = false;

            this.programLoaded = false;
        }

        public void MoveRobotToProgramStartPosition()
        {
            ArrayList program = ProgramParser.Parse(this.programSelectedFilePath);
            string cmdText = (string) program[0];

            this.client.SendCommand(cmdText);

            this.collectionThread = new Thread(CollectionLoop);
            this.collectionThread.Name = "CollectionLoop";
            System.Globalization.CultureInfo culInf = new System.Globalization.CultureInfo("en-US");
            this.collectionThread.CurrentCulture = culInf;
            this.collectionThread.Start(this);
        }

        public void InitDataCollection() // TODO: 
        {
            bool[] flags =
            {
                this.flagPosjointsetpoint,
                this.flagPosjointcurrent,
                this.flagPoscartrobot,
                this.flagPoscartplatform,
                this.flagOverride,
                this.flagDindout,
                this.flagEstop,
                this.flagSupply,
                this.flagCurrentall,
                this.flagCurrentjoints,
                this.flagKinstate,
                this.flagError,
                this.flagOpmode
            };

            this.collector.InitDataCollection(
                this.selectedOutputDir,
                this.programSelectedFilePath,
                this.selectedDatasetName,
                this.selectedRepetitons,
                this.selectedSamplingRate,
                flags  
                );
        }

        public void DropDataCollection() // TODO:
        {
            Console.WriteLine("Stopping collection.");

            this.collector.DropDataCollection();

            this.SendCommand("Stop");
            this.MoveToZeroPosition();

            this.programLoaded = false;

            this.collectionStarted = false;
            this.collectionReady = false;
            this.collectionRunning = false;
            

            if(this.collectionThread != null)
            {
                this.collectionThread.Abort();
                this.collectionThread = null;
            }
        }

        public void StartDataCollection()
        {
            this.collector.StartDataCollection();

            this.collectionStarted = true;

            this.SendCommand("Start");
        }

        private void StartNewRepetition()
        {
            this.StartDataCollection();
        }

        /******* Connection *******/
        public void ConnectToCRI(string IP)
        {
            this.client.SetIPAddress(IP);
            if (!this.client.GetConnectionStatus())
            {
                this.client.Connect();
                log.Info(string.Format("Connecting to {0}", IP));
            }
            else
            {
                log.Info(string.Format("Already connected, disconnect first."));
            }
        }

        public void DisconnectFromCRI()
        {
            this.client.Disconnect();
        }

        /******* Commands *******/
        public void SendCommand(string command)
        {
            if (!this.client.GetConnectionStatus())
            {
                log.Error("Send Command: Cannot send while not connected!");
                return;
            }

            string cmdText = "none";
            switch (command)
            {
                case "Start": cmdText = "CMD StartProgram"; break;
                case "StartNotOnRepeat": cmdText = "CMD ProgramReplayMode 0"; break;
                case "StartOnRepeat": cmdText = "CMD ProgramReplayMode 1"; break;
                case "Stop": cmdText = "CMD StopProgram"; break;
                case "Pause": cmdText = "CMD PauseProgram"; break;
                case "DOut25 true": cmdText = "CMD DOUT 24 true"; break; // Douts are off set by one compared to the UI
                case "DOut25 false": cmdText = "CMD DOUT 24 false"; break; // Douts are off set by one compared to the UI
                case "Stop Movement": cmdText = "CMD Move Stop"; break;
            }
            if (cmdText == "none")
            {
                log.Error("Send command: Command does not exist.");
                return;
            }
            log.DebugFormat("Send command: {0}", cmdText);
            this.client.SendCommand(cmdText);
        }

        public void LoadProgram() { // Specifically for StartPage
            this.programLoaded = true;

            string cmdText = "CMD DeleteProgram";
            this.client.SendCommand(cmdText);

            cmdText = "CMD LoadProgram ";
            cmdText += this.programSelected;

            this.client.SendCommand(cmdText);
        }

        public void DropProgram()
        {
            this.programLoaded = false;
            this.programSelected = "";
            this.programSelectedFilePath = "";

            string cmdText = "CMD DeleteProgram";
            this.client.SendCommand(cmdText);

            this.SendCommand("Stop");
            this.MoveToZeroPosition();
        }

        /******* Gripper Controls *******/
        public void OpenGripper()
        {
            this.gripperOpen = true;
            this.SendCommand("DOut25 true");
        }

        public void CloseGripper()
        {
            this.gripperOpen = false;
            this.SendCommand("DOut25 false");
        }

        public void MoveToZeroPosition()
        {
            double[] joint = { 0.0, 0.0, 0.0, 90.0, 0.0, 0.0 };
            double velpercent = 70.0;

            log.DebugFormat("Command: Move to zero position");
            this.MoveToJoint(joint, velpercent);
        }

        public void MoveToStoragePosition() 
        {
            double[] joint = { 0.0, -45.0, 54.0, 66.0, 0.0, 0.0 };
            double velpercent = 25.0;

            log.DebugFormat("Command: Move to storage position");
            this.MoveToJoint(joint, velpercent);
        }
       
        public void RunTestRobotArm() // TODO: make it possible
        {
            ArrayList testProgram = new ArrayList
            {
                "1997",
                "Joint 0.00 -13.42 20.30 80.00 0.00 0.00 EXT 0.0 0.0 0.0 VEL 80.00",
                "Joint -14.58 9.44 12.47 64.16 0.00 0.00 EXT 0.0 0.0 0.0 VEL 80.00",
                "Joint 22.19 12.05 9.14 65.66 36.73 0.00 EXT 0.0 0.0 0.0 VEL 80.00",
                "Joint 0.00 -13.42 20.30 80.00 0.00 0.00 EXT 0.0 0.0 0.0 VEL 80.00"
            };
        }

        public void RunTestGripper() 
        {
            this.gripperOpen = true;
            this.SendCommand("DOut25 true");

            Thread.Sleep(1000);

            this.gripperOpen = false;
            this.SendCommand("DOut25 false");
        }

        /******* Basic Controls *******/
        public void StopMovement()
        {
            for (int i = 0; i < 9; i++)
                jogValues[i] = 0.0;
            this.client.SetJogValues(jogValues);
        }

        /******* Movement Controls (Joints) *******/
        public void MoveJoint1Increase()
        {
            if (jogValues[0] <= 90.0)
                jogValues[0] += 10.0;
            this.client.SetJogValues(jogValues);
        }

        public void MoveJoint1Decrease()
        {
            if (jogValues[0] >= -90.0)
                jogValues[0] -= 10.0;
            this.client.SetJogValues(jogValues);
        }

        public void MoveJoint2Increase()
        {
            if (jogValues[1] <= 90.0)
                jogValues[1] += 10.0;
            this.client.SetJogValues(jogValues);
        }

        public void MoveJoint2Decrease()
        {
            if (jogValues[1] >= -90.0)
                jogValues[1] -= 10.0;
            this.client.SetJogValues(jogValues);
        }

        public void MoveJoint3Increase()
        {
            if (jogValues[2] <= 90.0)
                jogValues[2] += 10.0;
            this.client.SetJogValues(jogValues);
        }

        public void MoveJoint3Decrease()
        {
            if (jogValues[2] >= -90.0)
                jogValues[2] -= 10.0;
            this.client.SetJogValues(jogValues);
        }

        public void MoveJoint4Increase()
        {
            if (jogValues[3] <= 90.0)
                jogValues[3] += 10.0;
            this.client.SetJogValues(jogValues);
        }

        public void MoveJoint4Decrease()
        {
            if (jogValues[3] >= -90.0)
                jogValues[3] -= 10.0;
            this.client.SetJogValues(jogValues);
        }

        public void MoveJoint5Increase()
        {
            if (jogValues[4] <= 90.0)
                jogValues[4] += 10.0;
            this.client.SetJogValues(jogValues);
        }

        public void MoveJoint5Decrease()
        {
            if (jogValues[4] >= -90.0)
                jogValues[4] -= 10.0;
            this.client.SetJogValues(jogValues);
        }

        public void MoveJoint6Increase()
        {
            if (jogValues[5] <= 90.0)
                jogValues[5] += 10.0;
            this.client.SetJogValues(jogValues);
        }

        public void MoveJoint6Decrease()
        {
            if (jogValues[5] >= -90.0)
                jogValues[5] -= 10.0;
            this.client.SetJogValues(jogValues);
        }


        /******* Velocity Controls *******/
        public void IncreaseVelocity()
        {
            double ovr = this.client.overrideValue;
            if (ovr <= 90.0) // else: max override -> 100%
                ovr += 10.0;
            this.client.SetOverride(ovr);
        }

        public void DecreaseVelocity()
        {
            double ovr = this.client.overrideValue;
            if (ovr >= 10.0) // else: min override -> 0%
                ovr -= 10.0;
            this.client.SetOverride(ovr);
        }


        /******* Movement Relative to/to Controls *******/
        public void MoveToJoint(double[] joint, double velperc)
        {
            string userCommand = string.Format(
                "CMD Move Joint {0} {1} {2} {3} {4} {5} 0 0 0 {6}", 
                joint[0],
                joint[1], 
                joint[2], 
                joint[3], 
                joint[5], 
                joint[5], 
                velperc
                );
            this.client.SendCommand(userCommand);
        }

        public void MoveRelativeToJoint(double[] joint, double velperc)
        {
            string userCommand = string.Format(
                "CMD Move RelativeJoint {0} {1} {2} {3} {4} {5} 0 0 0 {6}",
                joint[0],
                joint[1],
                joint[2],
                joint[3],
                joint[5],
                joint[5],
                velperc
                );
            this.client.SendCommand(userCommand);

        }

        public void MoveToCoordinates(double[] coordinates, double velabs)
        {
            string userCommand = string.Format(
                "CMD Move Cart {0} {1} {2} {3} {4} {5} 0 0 0 {6}",
                coordinates[0],
                coordinates[1],
                coordinates[2],
                coordinates[3],
                coordinates[5],
                coordinates[5],
                velabs
                );
            this.client.SendCommand(userCommand);

        }

        public void MoveRelativeToCoordinates(double[] coordinates, double velabs)
        {
            string userCommand = string.Format(
                "CMD Move RelativeBase {0} {1} {2} {3} {4} {5} 0 0 0 {6}",
                coordinates[0],
                coordinates[1],
                coordinates[2],
                coordinates[3],
                coordinates[5],
                coordinates[5],
                velabs
                );
            this.client.SendCommand(userCommand);

        }


        /******* Data Collection *******/
        private void CollectionLoop(object Context)
        {
            // Timer
            System.Timers.Timer collectionTimer = new System.Timers.Timer(1);

            bool firstTimestamp = true;
            DateTime lastTimestamp = DateTime.Now;

            double timeDiffToSample = 1000 / this.collector.GetSamplingRate();

            while(true)
            {
                if (!this.collectionStarted
                    && !this.collectionRunning
                    && this.collector.IsPosFirstProgramPos(this.client.posJointsCurrent, this.client.posCartesian))
                {
                    //Console.WriteLine("Collection is ready.");
                    this.collectionReady = true;
                }
                
                if(this.collectionStarted
                    && this.collectionReady)
                {
                    //Console.WriteLine("Collection is running.");
                    this.collectionRunning = true;

                }

                DateTime timestampNow = DateTime.Now;

                if (this.collectionRunning)
                {
                    // Console.WriteLine("Test");

                    if (firstTimestamp)
                    {
                        firstTimestamp = false;
                        lastTimestamp = timestampNow;

                        this.collector.SampleData(
                            timestampNow.ToString("o"),
                            this.client.posJointsSetPoint,
                            this.client.posJointsCurrent,
                            this.client.posCartesian,
                            this.client.overrideValue,
                            this.client.digialInputs,
                            this.client.digialOutputs,
                            this.client.emergencyStopStatus,
                            this.client.supplyVoltage,
                            this.client.currentAll,
                            this.client.currentJoints,
                            this.client.errorString,
                            this.client.errorCodes,
                            this.client.kinState
                            );
                    }
                    else
                    {
                        TimeSpan diff = timestampNow - lastTimestamp;

                        if (diff.TotalMilliseconds >= timeDiffToSample)
                        {
                            lastTimestamp = timestampNow;

                            this.collector.SampleData(
                                timestampNow.ToString("o"),
                                this.client.posJointsSetPoint,
                                this.client.posJointsCurrent,
                                this.client.posCartesian,
                                this.client.overrideValue,
                                this.client.digialInputs,
                                this.client.digialOutputs,
                                this.client.emergencyStopStatus,
                                this.client.supplyVoltage,
                                this.client.currentAll,
                                this.client.currentJoints,
                                this.client.errorString,
                                this.client.errorCodes,
                                this.client.kinState
                                );
                        }
                    }
                }

                // If end of rep
                if (this.collectionRunning
                    && this.client.EXECEND)
                {
                    Console.WriteLine("Rep ended.");

                    this.collector.PersistRepetition();
                    this.collector.IncrementRepetition();

                    if(this.collector.GetCurrentRepetition() <= this.collector.GetMaxRepetition())
                    {
                        Console.WriteLine("About to restart.");
                        Console.WriteLine("Current rep: "+ this.collector.GetCurrentRepetition());
                        Console.WriteLine("Max rep: "+ this.collector.GetMaxRepetition());
                        this.StartNewRepetition();
                    }
                    else
                    {
                        this.DropDataCollection();
                        return;
                    }
                }

            }
            
        }

        public void test()
        {
            // this.SendCommand(); 
        }
    }
}           
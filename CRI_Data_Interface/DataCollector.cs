using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRI_Data_Interface
{
    public class DataCollector
    {
        private string outputPath = "";
        private string programPath = "";
        private string datasetName = "";
        private int repetitions = 0;
        private int samplingrate = 0;

        private string currentDatasetFile = "";
        private ArrayList currentProgram = null;

        private bool flagPosjointsetpoint = false;
        private bool flagPosjointcurrent = false;
        private bool flagPoscartrobot = false;
        private bool flagPoscartplatform = false; // no
        private bool flagOverride = false;
        private bool flagDindout = false;
        private bool flagEstop = false;
        private bool flagSupply = false;
        private bool flagCurrentall = false;
        private bool flagCurrentjoints = false;
        private bool flagKinstate = false;
        private bool flagError = false;
        private bool flagOpmode = false; // no

        private int currentRepetition = 1;
        private ArrayList dataCurrentRepetition = new ArrayList();

        
        /******* Getter *******/
        public int GetCurrentRepetition()
        {
            return this.currentRepetition;
        }

        public int GetSamplingRate()
        {
            return this.samplingrate;
        }

        public int GetMaxRepetition()
        {
            return this.repetitions;
        }

        /******* Setter *******/


        /******* Controls *******/
        public void InitDataCollection(
            string outputPath,
            string programPath,
            string datasetName,
            int repetitions,
            int samplingrate,
            bool[] settings
            ) 
        {
            this.outputPath = outputPath;
            this.programPath = programPath;
            this.datasetName = datasetName;
            this.repetitions = repetitions;
            this.samplingrate = samplingrate;

            this.flagPosjointsetpoint = settings[0];
            this.flagPosjointcurrent = settings[1];
            this.flagPoscartrobot = settings[2];
            this.flagPoscartplatform = settings[3];
            this.flagOverride = settings[4];
            this.flagDindout = settings[5];
            this.flagEstop = settings[6];
            this.flagSupply = settings[7];
            this.flagCurrentall = settings[8];
            this.flagCurrentjoints = settings[9];
            this.flagKinstate = settings[10];
            this.flagError = settings[11];
            this.flagOpmode = settings[12];

            this.currentProgram = ProgramParser.Parse(programPath);
            // this.currentRepetition = 0;
            this.dataCurrentRepetition = new ArrayList();

            this.currentRepetition = 1;
        }

        public void StartDataCollection()
        {
            this.CreateDatasetFile();
        }

        public void DropDataCollection()
        {
            this.outputPath = "";
            this.repetitions = 0;
            this.samplingrate = 0;

            this.currentDatasetFile = "";
            this.currentProgram = null;

            this.flagPosjointsetpoint = false;
            this.flagPosjointcurrent = false;
            this.flagPoscartrobot = false;
            this.flagPoscartplatform = false;
            this.flagOverride = false;
            this.flagDindout = false;
            this.flagEstop = false;
            this.flagSupply = false;
            this.flagCurrentall = false;
            this.flagCurrentjoints = false;
            this.flagError = false;
            this.flagOpmode = false;
            this.flagKinstate = false;

            this.currentRepetition = 0;

            this.dataCurrentRepetition = null;
        }

        public void IncrementRepetition()
        {
            this.currentRepetition = this.currentRepetition + 1;
            this.dataCurrentRepetition = new ArrayList();
        }

        public void SampleData(
            string timestamp,
            double[] posJointsSetPoint,
            double[] posJointsCurrent,
            double[] posCartesian,
            double overrideValue,
            ulong digialInputs,
            ulong digialOutputs,
            int emergencyStopStatus,
            int supplyVoltage,
            int currentAll,
            int[] currentJoints,
            string errorString,
            int[] errorCodes,
            int kinState)
        {
            string featureVector = this.CreateFeatureVector(
                timestamp,
                posJointsSetPoint,
                posJointsCurrent,
                posCartesian,
                overrideValue,
                digialInputs,
                digialOutputs,
                emergencyStopStatus,
                supplyVoltage,
                currentAll,
                currentJoints,
                errorString,
                errorCodes,
                kinState);

            this.dataCurrentRepetition.Add(featureVector);
        }

        private void CreateDatasetFile() 
        {
            if (this.outputPath == "") return;

            this.currentDatasetFile = this.outputPath + "\\" + this.datasetName + this.currentRepetition + ".csv";

            ArrayList csvHeader = new ArrayList(/*string*/);

            // header
            csvHeader.Add("timestamp");

            if (this.flagPosjointsetpoint) for(int i = 1; i <= 7; i++) csvHeader.Add("posjointsetpoint" + i);

            if (this.flagPosjointcurrent) for (int i = 1; i <= 7; i++) csvHeader.Add("posjointcurrent" + i);

            if (this.flagPoscartrobot) for (int i = 1; i <= 7; i++) csvHeader.Add("poscartrobot" + i); 

            if (this.flagOverride) csvHeader.Add("override");

            if (this.flagDindout) csvHeader.Add("din"); csvHeader.Add("dout");

            if (this.flagEstop) csvHeader.Add("estop");

            if (this.flagSupply) csvHeader.Add("supply");

            if (this.flagCurrentall) csvHeader.Add("currentall");

            if (this.flagCurrentjoints) for (int i = 1; i <= 9; i++) csvHeader.Add("currentjoints" + i);

            if (this.flagError) for (int i = 1; i <= 9; i++) csvHeader.Add("error" + i);

            if (this.flagKinstate) csvHeader.Add("kinstate");


            // write to file
            using(StreamWriter writer = File.CreateText(this.currentDatasetFile))
            {
                string header = "";

                for (int i = 0; i < csvHeader.Count; i++)
                {
                    header += csvHeader[i].ToString() + ";";
                }

                header.Remove(header.Length - 1);

                writer.WriteLine(header);
            }
        }
        
        private string CreateFeatureVector(
            string timestamp,
            double[] posJointsSetPoint,
            double[] posJointsCurrent,
            double[] posCartesian,
            double overrideValue,
            ulong digialInputs,
            ulong digialOutputs,
            int emergencyStopStatus,
            int supplyVoltage,
            int currentAll,
            int[] currentJoints,
            string errorString,
            int[] errorCodes,
            int kinState)
        {
            if (this.currentDatasetFile == "") return null;

            string featureVector = "";

            featureVector += timestamp + ";";

            if (this.flagPosjointsetpoint)
            {
                for(int i = 0; i < posJointsSetPoint.Length; i++)
                {
                    featureVector += posJointsSetPoint[i] + ";";
                }
            }
            if (this.flagPosjointcurrent)
            {
                for (int i = 0; i < posJointsCurrent.Length; i++)
                {
                    featureVector += posJointsCurrent[i] + ";";
                }
            }
            if (this.flagPoscartrobot)
            {
                for (int i = 0; i < posCartesian.Length; i++)
                {
                    featureVector += posCartesian[i] + ";";
                }
            }
            if (this.flagOverride)
            {
                featureVector += overrideValue + ";";
            }
            if (this.flagDindout)
            {
                featureVector += digialInputs + ";";
                featureVector += digialOutputs + ";";
            }
            if (this.flagEstop)  
            {
                featureVector += emergencyStopStatus + ";";
            }
            if (this.flagSupply) 
            {
                featureVector += supplyVoltage + ";";
            }
            if (this.flagCurrentall) 
            {
                featureVector += currentAll + ";";
            }
            if (this.flagCurrentjoints)
            {
                for (int i = 0; i < currentJoints.Length; i++)
                {
                    featureVector += currentJoints[i] + ";";
                }
            }
            if (this.flagError)
            {
                featureVector += errorString + ";";

                for (int i = 0; i < errorCodes.Length; i++)
                {
                    featureVector += errorCodes[i] + ";";
                }
            }
            if (this.flagKinstate)
            {
                featureVector += kinState + ";";
            }

            featureVector.Remove(featureVector.Length - 1);

            return featureVector;
        }

        public void PersistRepetition()
        {
            Console.WriteLine("Persisting it.");

            using (StreamWriter writer = File.AppendText(this.currentDatasetFile))
            {
                foreach (var element in this.dataCurrentRepetition)
                {
                    writer.WriteLine(element);
                }
            }

        }
        
        /******* Checks Ups *******/
        public bool IsPosFirstProgramPos(double[] currentPosJoints, double[] currentPosCart)
        {
            if (this.currentProgram == null) return false;

            string[] programPos = this.currentProgram[0].ToString().Split(' ');

            // if they are joint coordinates
            if (programPos[2] == "Joint")
            {
                return (
                    currentPosJoints[0] == Convert.ToDouble(programPos[3]) &&
                    currentPosJoints[1] == Convert.ToDouble(programPos[4]) &&
                    currentPosJoints[2] == Convert.ToDouble(programPos[5]) &&
                    currentPosJoints[3] == Convert.ToDouble(programPos[6]) &&
                    currentPosJoints[4] == Convert.ToDouble(programPos[7]) &&
                    currentPosJoints[5] == Convert.ToDouble(programPos[8])
                );
            }
            // if they are cartesian coordinates
            else if (programPos[2] == "Cart")
            {
                return (
                    currentPosCart[0] == Convert.ToDouble(programPos[3]) &&
                    currentPosCart[1] == Convert.ToDouble(programPos[4]) &&
                    currentPosCart[2] == Convert.ToDouble(programPos[5]) &&
                    currentPosCart[3] == Convert.ToDouble(programPos[6]) &&
                    currentPosCart[4] == Convert.ToDouble(programPos[7]) &&
                    currentPosCart[5] == Convert.ToDouble(programPos[8])
                );
            }

            return false;
        }
    }
}

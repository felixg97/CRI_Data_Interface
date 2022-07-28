using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRI_Data_Interface
{
    public partial class CRIDataInterfaceGUI : Form
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private CRIServiceObject criService;

        // Constants // TODO: refactor to CRIServiceObject
        private string[] CONNECTIONS = { "127.0.0.1", "192.168.3.11" };
        private string selectedConnectionIP = null;

        private int lastRepetition = 0;

        public CRIDataInterfaceGUI()
        {
            InitializeComponent();
            this.criService = new CRIServiceObject();

            this.appTimer.Interval = 50; // Max Hz (20 hz)
            this.appTimer.Enabled = true;
            log.Info("CRI data interface client started.");

            this.tabControl1.TabPages.Remove(this.handControlPage);
            this.tabControl1.TabPages.Remove(this.statusPage);
            this.tabControl1.TabPages.Remove(this.statusCoursePage);
        }

        private void appTimer_Tick(object sender, EventArgs e)
        {
            // <100ms Region - Data collection


            // 100ms Region


            // Set connected via connection flag
            if (this.criService.GetFlagConnected())
            {
                this.connectionStatusText.ForeColor = System.Drawing.Color.Green;
                this.connectionStatusText.Text = "Connected";

                this.connectButton.Enabled = false;
                this.comboBoxConnections.Enabled = false;
            }
            else
            {
                this.connectionStatusText.ForeColor = System.Drawing.Color.Red;
                this.connectionStatusText.Text = "Not connected";

                this.connectButton.Enabled = true;
                this.comboBoxConnections.Enabled = true;
            }

            if (tabControl1.SelectedIndex == 0) this.UpdateStartPageInformation();
            else if (tabControl1.SelectedIndex == 1) this.UpdateDataPageInformation();
            //else if (tabControl1.SelectedIndex == 2) this.UpdateHandControlPageInformation();
            //else if (tabControl1.SelectedIndex == 3) this.UpdateStatusPageInformation();


            // Appends the log messages in the app
            try
            {
                if (ListViewAppender.instance != null)
                {
                    while (ListViewAppender.instance.nrNewMessages > 0)
                    {
                        this.logTextBox.AppendText(ListViewAppender.instance.GetMessage());
                        this.logTextBox.AppendText("\r\n");
                    }
                }
            }
            catch (Exception)
            {
                ;
            }
        }

        private void UpdateStartPageInformation() 
        {
            Dictionary<string, string> statusInformation = this.criService.GetStatusInformation();

            this.errorStatusText.Text = statusInformation["error"];
            this.selectedProgramStatusText.Text = statusInformation["selectedProgram"] == "" ? "n/a" : statusInformation["selectedProgram"];
            this.referencedStatusText.Text = statusInformation["emergencyStop"];

            bool programLoaded = Convert.ToBoolean(statusInformation["programLoaded"]);
            this.programLoadedStatusText.Text = programLoaded ? "loaded": "not loaded";

            this.startProgramButton.Enabled = programLoaded;
            this.pauseProgramButton.Enabled = programLoaded;
            this.stopProgramButton.Enabled = programLoaded;
            this.repeatedProgramCheckBox.Enabled = programLoaded;

            this.dropProgramButton.Enabled = programLoaded;

            if(programLoaded) 
            {
                this.loadProgramButton.Enabled = false;
                this.selectProgramButton.Enabled = false;
            }
            else
            {
                this.loadProgramButton.Enabled = statusInformation["selectedProgram"] == "" ? false : true;
                this.selectProgramButton.Enabled = true;
            }

            bool dataCollectionRunning = Convert.ToBoolean(statusInformation["dataCollectionRunning"]);
            if (dataCollectionRunning)
            {
                this.dataCollectionStatusText.Text = "running...";
                this.dataCollectionStatusText.ForeColor = Color.Orange;
            }
            else 
            {
                this.dataCollectionStatusText.Text = "not running";
                this.dataCollectionStatusText.ForeColor = Color.Black;
            }

            Dictionary<string, double> posistions = this.criService.GetPositions();

            this.a1StatusText.Text = posistions["joint1"].ToString() + "°";
            this.a2StatusText.Text = posistions["joint2"].ToString() + "°";
            this.a3StatusText.Text = posistions["joint3"].ToString() + "°";
            this.a4StatusText.Text = posistions["joint4"].ToString() + "°";
            this.a5StatusText.Text = posistions["joint5"].ToString() + "°";
            this.a6StatusText.Text = posistions["joint6"].ToString() + "°";
            this.velocityRelStatusText.Text = posistions["velocityRelative"].ToString();

            this.xStatusText.Text = posistions["x"].ToString() + " mm";
            this.yStatusText.Text = posistions["y"].ToString() + " mm";
            this.zStatusText.Text = posistions["z"].ToString() + " mm";
            this.aStatusText.Text = posistions["a"].ToString() + " mm";
            this.bStatusText.Text = posistions["b"].ToString() + " mm";
            this.cStatusText.Text = posistions["c"].ToString() + " mm";

            Dictionary<string, bool> hideMessageFlags = this.criService.GetMessageFlags();

            this.hideOutAliveMsgCheckBox.Checked = hideMessageFlags["outAliveMessages"];
            this.hideInBasicMsgCheckBox.Checked = hideMessageFlags["inBasicStatusMessages"];
            this.hideInFurtherMsgCheckBox.Checked = hideMessageFlags["inFurtherStatusMessages"];
            this.hideInUnknownMsgCheckBox.Checked = hideMessageFlags["inUnknownMessages"];
        }

        private void UpdateDataPageInformation() 
        {
            // flag data collections
            Dictionary<string, bool> dataCollectionFlags = this.criService.GetDataCollectionFlags();

            this.posjointsetpointCheckBox.Checked = dataCollectionFlags["flagPosjointsetpoint"];
            this.posjointcurrentCheckBox.Checked = dataCollectionFlags["flagPosjointcurrent"];
            this.poscartrobotCheckBox.Checked = dataCollectionFlags["flagPoscartrobot"];
            this.poscartplatformCheckBox.Checked = dataCollectionFlags["flagPoscartplatform"];
            this.overrideCheckBox.Checked = dataCollectionFlags["flagOverride"];
            this.dindoutCheckBox.Checked = dataCollectionFlags["flagDindout"];
            this.estopCheckBox.Checked = dataCollectionFlags["flagEstop"];
            this.supplyCheckBox.Checked = dataCollectionFlags["flagSupply"];
            this.currentallCheckBox.Checked = dataCollectionFlags["flagCurrentall"];
            this.currentjointsCheckBox.Checked = dataCollectionFlags["flagCurrentjoints"];
            this.kinstateCheckBox.Checked = dataCollectionFlags["flagKinstate"];
            this.errorCheckBox.Checked = dataCollectionFlags["flagError"];
            this.opmodeCheckBox.Checked = dataCollectionFlags["flagOpmode"];

            this.selectedOutputDirTextBox.Text = this.criService.GetOutputDirSelected();

            string programSelected = this.criService.GetProgramSelected();
            this.selectedProgramTextBox.Text = programSelected == "" ? "" : programSelected;

            if (this.criService.IsCollectionRunning())
            {
                this.EnableCollectionInputElements(false);

                this.clearCollectionSettingsButton.Enabled = false;
                this.unfixCollectionSettingsButton.Enabled = false;
                this.fixCollectionSettingsButton.Enabled = false;

                this.collectionRunningText.Text = "running";
                this.collectionRunningText.ForeColor = Color.Orange;
            }
            else
            {
                this.clearCollectionSettingsButton.Enabled = true;
                this.unfixCollectionSettingsButton.Enabled = true;
                this.fixCollectionSettingsButton.Enabled = true;

                this.collectionRunningText.Text = "not runnig";
                this.collectionRunningText.ForeColor = Color.Black;
            }

            this.moveToStartPosButton.Enabled = this.criService.GetCollectionSettingsChecked();

            if (!this.criService.GetCollectionReadiness())
            {
                this.startDataCollectionButton.Enabled = false;
                this.stopDataCollectionButton.Enabled = false;

                this.collectionReadyText.Text = "not ready";
                this.collectionReadyText.ForeColor = Color.Black;   
            }
            else
            {
                this.startDataCollectionButton.Enabled = true;
                this.stopDataCollectionButton.Enabled = true;
                
                this.startDataCollectionButton.Enabled = true;
                this.stopDataCollectionButton.Enabled = true;

                this.collectionReadyText.Text = "ready";
                this.collectionReadyText.ForeColor = Color.Green; 
                
                this.progressBarCollection.Maximum = this.criService.GetSelectedRepetition();
                this.progressBarCollection.Value = 0;
                this.progressBarCollection.Step = 1;
                this.lastRepetition = 0;
            }

            int currentRepetition = this.criService.GetCurrentRepetition();
            this.currentRepetitionText.Text = Convert.ToString(currentRepetition);
            if (this.lastRepetition > currentRepetition) this.progressBarCollection.PerformStep();
            this.lastRepetition = currentRepetition;

        }

        private void EnableCollectionInputElements(bool val)
        {
            this.selectedOutputDirTextBox.Enabled = val;
            this.selectOutputDirectory.Enabled = val;

            this.selectedProgramTextBox.Enabled = val;
            this.selectProgrammButtonDataPage.Enabled = val;

            this.datasetNameTextBox.Enabled = val;
            this.repetitionsTextBox.Enabled = val;
            this.samplingRateTextBox.Enabled = val;

            this.posjointsetpointCheckBox.Enabled = val;
            this.posjointcurrentCheckBox.Enabled = val;
            this.poscartrobotCheckBox.Enabled = val;
            this.poscartplatformCheckBox.Enabled = val;
            this.overrideCheckBox.Enabled = val;
            this.dindoutCheckBox.Enabled = val;
            this.estopCheckBox.Enabled = val;
            this.supplyCheckBox.Enabled = val;
            this.currentallCheckBox.Enabled = val;
            this.currentjointsCheckBox.Enabled = val;
            this.kinstateCheckBox.Enabled = val;
            this.errorCheckBox.Enabled = val;
            this.opmodeCheckBox.Enabled = val;
        }

        /******* START PAGE *******/
        private void comboBoxConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedConnectionIP = this.CONNECTIONS[this.comboBoxConnections.SelectedIndex];
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            this.criService.ConnectToCRI(this.selectedConnectionIP);
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            this.criService.DisconnectFromCRI();
            this.criService.DropDataCollection();
            this.EnableCollectionInputElements(true);
        }

        private void buttonSendCommand(object sender, EventArgs e) 
        {
            this.criService.SendCommand(((System.Windows.Forms.ButtonBase)sender).Text);
        }

        private void zeroPositionButton_Click(object sender, EventArgs e) 
        {
            this.criService.MoveToZeroPosition();
        }

        private void storagePositionButton_Click(object sender, EventArgs e) 
        {
            this.criService.MoveToStoragePosition();
        }

        private void testGripperButton_Click(object sender, EventArgs e) 
        {
            this.criService.RunTestGripper();
        }

        private void testRobotButton_Click(object sender, EventArgs e) 
        {
            this.criService.RunTestRobotArm();
        }

        private void stopMovementButton_Click(object sender, EventArgs e)
        {
            this.criService.SendCommand("Stop Movement");
        }

        private void openProgramFileDialog_FileOk(object sender, CancelEventArgs e) // TODO:
        {
            string filePath = this.openProgramFileDialog.FileName;

            if (ProgramParser.checkIfProgram(filePath))
            {
                //
                log.DebugFormat("Program file: " + filePath + " selected.");
                this.criService.SetSelectedProgramFile(filePath);
            }
            else
            {
                log.Error("The file selected is not a valid program.");
            }
        }
        
        private void selectProgramButton_Click(object sender, EventArgs e)
        {
            this.openProgramFileDialog.ShowDialog();
        }

        private void dropProgramButton_Click(object sender, EventArgs e)
        {
            this.criService.DropProgram();
        }

        private void loadProgramButton_Click(object sender, EventArgs e)
        {
            this.criService.LoadProgram();
        }

        private void messageCheckBox_Changed(object sender, EventArgs e)
        {
            string checkBoxName = ((System.Windows.Forms.CheckBox)sender).Name;

            if (checkBoxName == "hideInUnknownMsgCheckBox")
                this.criService.SetMessageFlag("inUnknownMessages", this.hideInUnknownMsgCheckBox.Checked);
            else if (checkBoxName == "hideInBasicMsgCheckBox")
                this.criService.SetMessageFlag("inBasicStatusMessages", this.hideInBasicMsgCheckBox.Checked);
            else if (checkBoxName == "hideInFurtherMsgCheckBox")
                this.criService.SetMessageFlag("inFurtherStatusMessages", this.hideInFurtherMsgCheckBox.Checked);
            else if (checkBoxName == "hideOutAliveMsgCheckBox")
                this.criService.SetMessageFlag("outAliveMessages", this.hideOutAliveMsgCheckBox.Checked);
        }

        /******* DATA PAGE *******/
        private void selectOutputDirectory_Click(object sender, EventArgs e)
        {
            DialogResult result = this.outputDirBrowserDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                string dirPath = this.outputDirBrowserDialog.SelectedPath;

                log.DebugFormat("Output directory: " + dirPath + " selected.");
                this.criService.SetSelectedOutputDir(dirPath);
            }
        }

        private void linkLabelCRIDocumentation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://wiki.cpr-robots.com/images/2/23/CPR_RobotInterfaceCRI.pdf");
        }

        private void clearCollectionSettingsButton_Click(object sender, EventArgs e)
        {
            this.criService.SetSelectedProgramFile("");
            this.criService.SetSelectedOutputDir("");

            this.datasetNameTextBox.Text = "";
            this.repetitionsTextBox.Text = "";
            this.samplingRateTextBox.Text = "";

            // Clear Fixed Collection Settings
            this.criService.ClearCollectionSettings();

            // Enable inputs
            this.EnableCollectionInputElements(true);
        }

        private void unfixCollectionSettingsButton_Click(object sender, EventArgs e)
        {
            // Clear Fixed Collection Settings
            this.EnableCollectionInputElements(true);

            // Deinitialise Data Collection
            this.criService.DropDataCollection();
        }

        private void fixCollectionSettingsButton_Click(object sender, EventArgs e)
        {
            this.criService.SetCollectionSettings(
                this.selectedOutputDirTextBox.Text,
                this.selectedProgramTextBox.Text,
                this.datasetNameTextBox.Text,
                int.Parse(this.repetitionsTextBox.Text),
                int.Parse(this.samplingRateTextBox.Text)
                );

            if(this.criService.CheckIfCollectionDataSatisfied())
            {
                this.EnableCollectionInputElements(false);

                // Set fixed collection settings
                Dictionary<string, string> collectSettings = this.criService.GetFixedCollectionSettings();

                this.fixedProgramNameText.Text = collectSettings["programName"];
                this.fixedDatasetNameText.Text = collectSettings["datasetName"];
                this.fixedRepetitionsText.Text = collectSettings["repetitions"]; ;
                this.fixedSamplingRateText.Text = collectSettings["samplingRate"];
                this.fixedOutputDirText.Text = collectSettings["outputDir"];

                // Initialise Data Collection
                this.criService.InitDataCollection();

                Console.WriteLine("collection settings fixed");
            }
        }

        private void intTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            if (!char.IsDigit(keyChar) && keyChar != 8 && keyChar != 46)  e.Handled = true; 
        }

        private void moveToStartPosButton_Click(object sender, EventArgs e) 
        {
            this.criService.MoveRobotToProgramStartPosition();
        }

        private void startDataCollectionButton_Click(object sender, EventArgs e) // TODO:
        {
            this.criService.StartDataCollection();
        }

        private void stopDataCollectionButton_Click(object sender, EventArgs e) // TODO:
        {
            this.criService.DropDataCollection();
            this.EnableCollectionInputElements(true);
        }

        private void collectionFlagsCheckBox_Changed(object sender, EventArgs e)
        {
            string checkBoxName = ((System.Windows.Forms.CheckBox)sender).Name;

            if (checkBoxName == "posjointsetpointCheckBox") 
                this.criService.SetCollectionFlag("flagPosjointsetpoint", this.posjointsetpointCheckBox.Checked);
            else if (checkBoxName == "posjointcurrentCheckBox")
                this.criService.SetCollectionFlag("flagPosjointcurrent", this.posjointcurrentCheckBox.Checked);
            else if (checkBoxName == "poscartrobotCheckBox")
                this.criService.SetCollectionFlag("flagPoscartrobot", this.poscartrobotCheckBox.Checked);
            else if (checkBoxName == "poscartplatformCheckBox")
                this.criService.SetCollectionFlag("flagPoscartplatform", this.poscartplatformCheckBox.Checked);
            else if (checkBoxName == "overrideCheckBox")
                this.criService.SetCollectionFlag("flagOverride", this.overrideCheckBox.Checked);
            else if (checkBoxName == "dindoutCheckBox")
                this.criService.SetCollectionFlag("flagDindout", this.dindoutCheckBox.Checked);
            else if (checkBoxName == "estopCheckBox")
                this.criService.SetCollectionFlag("flagEstop", this.estopCheckBox.Checked);
            else if (checkBoxName == "supplyCheckBox")
                this.criService.SetCollectionFlag("flagSupply", this.supplyCheckBox.Checked);
            else if (checkBoxName == "currentallCheckBox")
                this.criService.SetCollectionFlag("flagCurrentall", this.currentallCheckBox.Checked);
            else if (checkBoxName == "currentjointsCheckBox")
                this.criService.SetCollectionFlag("flagCurrentjoints", this.currentjointsCheckBox.Checked);
            else if (checkBoxName == "kinstateCheckBox")
                this.criService.SetCollectionFlag("flagKinstate", this.kinstateCheckBox.Checked);
            else if (checkBoxName == "errorCheckBox")
                this.criService.SetCollectionFlag("flagError", this.errorCheckBox.Checked);
            else if (checkBoxName == "opmodeCheckBox")
                this.criService.SetCollectionFlag("flagOpmode", this.opmodeCheckBox.Checked);
        }

        /******* HAND CONTROL PAGE *******/
        private void closeGripperButton_Click(object sender, EventArgs e)
        {
            this.criService.CloseGripper();
        }

        private void openGripperButton_Click(object sender, EventArgs e)
        {
            this.criService.OpenGripper();
        }

        private void repeatedProgramCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.criService.SetRepeatedStart(this.repeatedProgramCheckBox.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.criService.test();
        }

        /******* STATUS PAGE *******/
    }
}

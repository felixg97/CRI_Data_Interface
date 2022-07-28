using System;

namespace CRI_Data_Interface
{
    partial class CRIDataInterfaceGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.appTimer = new System.Windows.Forms.Timer(this.components);
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.controlPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hideInUnknownMsgCheckBox = new System.Windows.Forms.CheckBox();
            this.hideInFurtherMsgCheckBox = new System.Windows.Forms.CheckBox();
            this.hideInBasicMsgCheckBox = new System.Windows.Forms.CheckBox();
            this.hideOutAliveMsgCheckBox = new System.Windows.Forms.CheckBox();
            this.standardPositionsGroup = new System.Windows.Forms.GroupBox();
            this.repeatedProgramCheckBox = new System.Windows.Forms.CheckBox();
            this.loadProgramButton = new System.Windows.Forms.Button();
            this.dropProgramButton = new System.Windows.Forms.Button();
            this.selectProgramButton = new System.Windows.Forms.Button();
            this.storagePositionButton = new System.Windows.Forms.Button();
            this.testGripperButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pauseProgramButton = new System.Windows.Forms.Button();
            this.startProgramButton = new System.Windows.Forms.Button();
            this.stopProgramButton = new System.Windows.Forms.Button();
            this.stopMovementButton = new System.Windows.Forms.Button();
            this.testRobotButton = new System.Windows.Forms.Button();
            this.zeroPositionButton = new System.Windows.Forms.Button();
            this.connectionStatusGroup = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.velocityRelStatusText = new System.Windows.Forms.Label();
            this.velocityRelLabel = new System.Windows.Forms.Label();
            this.programLoadedStatusText = new System.Windows.Forms.Label();
            this.dataCollectionStatusText = new System.Windows.Forms.Label();
            this.programLoadedStatusLabel = new System.Windows.Forms.Label();
            this.dataCollectionStatusLabel = new System.Windows.Forms.Label();
            this.selectedProgramStatusText = new System.Windows.Forms.Label();
            this.selectedProgramLabel = new System.Windows.Forms.Label();
            this.cStatusText = new System.Windows.Forms.Label();
            this.bStatusText = new System.Windows.Forms.Label();
            this.aStatusText = new System.Windows.Forms.Label();
            this.zStatusText = new System.Windows.Forms.Label();
            this.yStatusText = new System.Windows.Forms.Label();
            this.xStatusText = new System.Windows.Forms.Label();
            this.a6CurrentLabel = new System.Windows.Forms.Label();
            this.a5CurrentLabel = new System.Windows.Forms.Label();
            this.a4CurrentLabel = new System.Windows.Forms.Label();
            this.zCurrentLabel = new System.Windows.Forms.Label();
            this.yCurrentLabel = new System.Windows.Forms.Label();
            this.xCurrentLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a6StatusText = new System.Windows.Forms.Label();
            this.a5StatusText = new System.Windows.Forms.Label();
            this.a4StatusText = new System.Windows.Forms.Label();
            this.a3StatusText = new System.Windows.Forms.Label();
            this.a2StatusText = new System.Windows.Forms.Label();
            this.a1StatusText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.a3Label = new System.Windows.Forms.Label();
            this.a2Label = new System.Windows.Forms.Label();
            this.a1label = new System.Windows.Forms.Label();
            this.posLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorStatusText = new System.Windows.Forms.Label();
            this.referencedStatusText = new System.Windows.Forms.Label();
            this.connectionStatusText = new System.Windows.Forms.Label();
            this.errorStatusLabel = new System.Windows.Forms.Label();
            this.emergencyStatusLabel = new System.Windows.Forms.Label();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.connectionControlGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.comboBoxConnections = new System.Windows.Forms.ComboBox();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.dataProgressBarGroup = new System.Windows.Forms.GroupBox();
            this.progressInPercent = new System.Windows.Forms.Label();
            this.progressBarCollection = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label43 = new System.Windows.Forms.Label();
            this.linkLabelCRIDocumentation = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.opmodeCheckBox = new System.Windows.Forms.CheckBox();
            this.errorCheckBox = new System.Windows.Forms.CheckBox();
            this.kinstateCheckBox = new System.Windows.Forms.CheckBox();
            this.currentjointsCheckBox = new System.Windows.Forms.CheckBox();
            this.currentallCheckBox = new System.Windows.Forms.CheckBox();
            this.supplyCheckBox = new System.Windows.Forms.CheckBox();
            this.estopCheckBox = new System.Windows.Forms.CheckBox();
            this.dindoutCheckBox = new System.Windows.Forms.CheckBox();
            this.overrideCheckBox = new System.Windows.Forms.CheckBox();
            this.poscartplatformCheckBox = new System.Windows.Forms.CheckBox();
            this.poscartrobotCheckBox = new System.Windows.Forms.CheckBox();
            this.posjointcurrentCheckBox = new System.Windows.Forms.CheckBox();
            this.posjointsetpointCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fixedSamplingRateText = new System.Windows.Forms.Label();
            this.fixedRepetitionsText = new System.Windows.Forms.Label();
            this.fixedDatasetNameText = new System.Windows.Forms.Label();
            this.currentRepetitionText = new System.Windows.Forms.Label();
            this.collectionRunningText = new System.Windows.Forms.Label();
            this.collectionReadyText = new System.Windows.Forms.Label();
            this.fixedOutputDirText = new System.Windows.Forms.Label();
            this.fixedProgramNameText = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.fixedOutputDirLabel = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.stopDataCollectionButton = new System.Windows.Forms.Button();
            this.startDataCollectionButton = new System.Windows.Forms.Button();
            this.samplingRateLabel = new System.Windows.Forms.Label();
            this.clearCollectionSettingsButton = new System.Windows.Forms.Button();
            this.unfixCollectionSettingsButton = new System.Windows.Forms.Button();
            this.fixCollectionSettingsButton = new System.Windows.Forms.Button();
            this.moveToStartPosButton = new System.Windows.Forms.Button();
            this.samplingRateTextBox = new System.Windows.Forms.TextBox();
            this.datasetNameTextBox = new System.Windows.Forms.TextBox();
            this.selectedProgramTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.repetitionsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectProgrammButtonDataPage = new System.Windows.Forms.Button();
            this.selectOutputDirectory = new System.Windows.Forms.Button();
            this.selectedOutputDirTextBox = new System.Windows.Forms.TextBox();
            this.handControlPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.moveRelativeToCoordinateButton = new System.Windows.Forms.Button();
            this.velocityAbsMovementText = new System.Windows.Forms.TextBox();
            this.moveToCoordinateButton = new System.Windows.Forms.Button();
            this.xMovementText = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cMovementText = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.yMovementText = new System.Windows.Forms.TextBox();
            this.bMovementText = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.zMovementText = new System.Windows.Forms.TextBox();
            this.aMovementText = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.moveRealtiveToJointButton = new System.Windows.Forms.Button();
            this.moveToJointButton = new System.Windows.Forms.Button();
            this.velocityRelMovementText = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.joint6MovementText = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.joint5MovementText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.joint4MovementText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.joint3MovementText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.joint2MovementText = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.joint1MovementText = new System.Windows.Forms.TextBox();
            this.joint1MovementLabel = new System.Windows.Forms.Label();
            this.jointMoveGroup = new System.Windows.Forms.GroupBox();
            this.gripperStatusHCText = new System.Windows.Forms.Label();
            this.velStatusHCText = new System.Windows.Forms.Label();
            this.a6StatusHCText = new System.Windows.Forms.Label();
            this.a5StatusHCText = new System.Windows.Forms.Label();
            this.a4StatusHCText = new System.Windows.Forms.Label();
            this.a3StatusHCText = new System.Windows.Forms.Label();
            this.a2StatusHCText = new System.Windows.Forms.Label();
            this.a1StatusHCText = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.closeGripperButton = new System.Windows.Forms.Button();
            this.velocityDecreaseButton = new System.Windows.Forms.Button();
            this.a6DecreaseButton = new System.Windows.Forms.Button();
            this.a5DecreaseButton = new System.Windows.Forms.Button();
            this.a4DecreaseButton = new System.Windows.Forms.Button();
            this.a3DecreaseButton = new System.Windows.Forms.Button();
            this.a2DecreaseButton = new System.Windows.Forms.Button();
            this.openGripperButton = new System.Windows.Forms.Button();
            this.a1DecreaseButton = new System.Windows.Forms.Button();
            this.velocityIncreaseButton = new System.Windows.Forms.Button();
            this.a6IncreaseButton = new System.Windows.Forms.Button();
            this.a5IncreaseButton = new System.Windows.Forms.Button();
            this.a4IncreaseButton = new System.Windows.Forms.Button();
            this.a3IncreaseButton = new System.Windows.Forms.Button();
            this.a2IncreaseButton = new System.Windows.Forms.Button();
            this.a1IncreaseButton = new System.Windows.Forms.Button();
            this.statusPage = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.statusCoursePage = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.openProgramFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputDirBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.logGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.controlPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.standardPositionsGroup.SuspendLayout();
            this.connectionStatusGroup.SuspendLayout();
            this.connectionControlGroup.SuspendLayout();
            this.dataPage.SuspendLayout();
            this.dataProgressBarGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.handControlPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.jointMoveGroup.SuspendLayout();
            this.statusPage.SuspendLayout();
            this.statusCoursePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // appTimer
            // 
            this.appTimer.Tick += new System.EventHandler(this.appTimer_Tick);
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.logTextBox);
            this.logGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logGroupBox.Location = new System.Drawing.Point(8, 485);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(1011, 183);
            this.logGroupBox.TabIndex = 4;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Logging";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(8, 19);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(999, 153);
            this.logTextBox.TabIndex = 3;
            this.logTextBox.Text = "s";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.controlPage);
            this.tabControl1.Controls.Add(this.dataPage);
            this.tabControl1.Controls.Add(this.handControlPage);
            this.tabControl1.Controls.Add(this.statusPage);
            this.tabControl1.Controls.Add(this.statusCoursePage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1019, 471);
            this.tabControl1.TabIndex = 3;
            // 
            // controlPage
            // 
            this.controlPage.BackColor = System.Drawing.Color.Transparent;
            this.controlPage.Controls.Add(this.groupBox2);
            this.controlPage.Controls.Add(this.standardPositionsGroup);
            this.controlPage.Controls.Add(this.connectionStatusGroup);
            this.controlPage.Controls.Add(this.connectionControlGroup);
            this.controlPage.Location = new System.Drawing.Point(4, 22);
            this.controlPage.Name = "controlPage";
            this.controlPage.Padding = new System.Windows.Forms.Padding(3);
            this.controlPage.Size = new System.Drawing.Size(1011, 445);
            this.controlPage.TabIndex = 0;
            this.controlPage.Text = "Start";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hideInUnknownMsgCheckBox);
            this.groupBox2.Controls.Add(this.hideInFurtherMsgCheckBox);
            this.groupBox2.Controls.Add(this.hideInBasicMsgCheckBox);
            this.groupBox2.Controls.Add(this.hideOutAliveMsgCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(510, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enables";
            // 
            // hideInUnknownMsgCheckBox
            // 
            this.hideInUnknownMsgCheckBox.AutoSize = true;
            this.hideInUnknownMsgCheckBox.Location = new System.Drawing.Point(16, 92);
            this.hideInUnknownMsgCheckBox.Name = "hideInUnknownMsgCheckBox";
            this.hideInUnknownMsgCheckBox.Size = new System.Drawing.Size(221, 17);
            this.hideInUnknownMsgCheckBox.TabIndex = 3;
            this.hideInUnknownMsgCheckBox.Text = "Hide incoming unknown status messages";
            this.hideInUnknownMsgCheckBox.UseVisualStyleBackColor = true;
            this.hideInUnknownMsgCheckBox.CheckedChanged += new System.EventHandler(this.messageCheckBox_Changed);
            // 
            // hideInFurtherMsgCheckBox
            // 
            this.hideInFurtherMsgCheckBox.AutoSize = true;
            this.hideInFurtherMsgCheckBox.Location = new System.Drawing.Point(15, 68);
            this.hideInFurtherMsgCheckBox.Name = "hideInFurtherMsgCheckBox";
            this.hideInFurtherMsgCheckBox.Size = new System.Drawing.Size(207, 17);
            this.hideInFurtherMsgCheckBox.TabIndex = 2;
            this.hideInFurtherMsgCheckBox.Text = "Hide incoming further status messages";
            this.hideInFurtherMsgCheckBox.UseVisualStyleBackColor = true;
            this.hideInFurtherMsgCheckBox.CheckedChanged += new System.EventHandler(this.messageCheckBox_Changed);
            // 
            // hideInBasicMsgCheckBox
            // 
            this.hideInBasicMsgCheckBox.AutoSize = true;
            this.hideInBasicMsgCheckBox.Location = new System.Drawing.Point(15, 44);
            this.hideInBasicMsgCheckBox.Name = "hideInBasicMsgCheckBox";
            this.hideInBasicMsgCheckBox.Size = new System.Drawing.Size(202, 17);
            this.hideInBasicMsgCheckBox.TabIndex = 1;
            this.hideInBasicMsgCheckBox.Text = "Hide incoming basic status messages";
            this.hideInBasicMsgCheckBox.UseVisualStyleBackColor = true;
            this.hideInBasicMsgCheckBox.CheckedChanged += new System.EventHandler(this.messageCheckBox_Changed);
            // 
            // hideOutAliveMsgCheckBox
            // 
            this.hideOutAliveMsgCheckBox.AutoSize = true;
            this.hideOutAliveMsgCheckBox.Location = new System.Drawing.Point(15, 20);
            this.hideOutAliveMsgCheckBox.Name = "hideOutAliveMsgCheckBox";
            this.hideOutAliveMsgCheckBox.Size = new System.Drawing.Size(167, 17);
            this.hideOutAliveMsgCheckBox.TabIndex = 0;
            this.hideOutAliveMsgCheckBox.Text = "Hide outgoing alive messages";
            this.hideOutAliveMsgCheckBox.UseVisualStyleBackColor = true;
            this.hideOutAliveMsgCheckBox.CheckedChanged += new System.EventHandler(this.messageCheckBox_Changed);
            // 
            // standardPositionsGroup
            // 
            this.standardPositionsGroup.Controls.Add(this.repeatedProgramCheckBox);
            this.standardPositionsGroup.Controls.Add(this.loadProgramButton);
            this.standardPositionsGroup.Controls.Add(this.dropProgramButton);
            this.standardPositionsGroup.Controls.Add(this.selectProgramButton);
            this.standardPositionsGroup.Controls.Add(this.storagePositionButton);
            this.standardPositionsGroup.Controls.Add(this.testGripperButton);
            this.standardPositionsGroup.Controls.Add(this.button1);
            this.standardPositionsGroup.Controls.Add(this.pauseProgramButton);
            this.standardPositionsGroup.Controls.Add(this.startProgramButton);
            this.standardPositionsGroup.Controls.Add(this.stopProgramButton);
            this.standardPositionsGroup.Controls.Add(this.stopMovementButton);
            this.standardPositionsGroup.Controls.Add(this.testRobotButton);
            this.standardPositionsGroup.Controls.Add(this.zeroPositionButton);
            this.standardPositionsGroup.Location = new System.Drawing.Point(510, 6);
            this.standardPositionsGroup.Name = "standardPositionsGroup";
            this.standardPositionsGroup.Size = new System.Drawing.Size(491, 303);
            this.standardPositionsGroup.TabIndex = 1;
            this.standardPositionsGroup.TabStop = false;
            this.standardPositionsGroup.Text = "Standard Controls";
            // 
            // repeatedProgramCheckBox
            // 
            this.repeatedProgramCheckBox.AutoSize = true;
            this.repeatedProgramCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.repeatedProgramCheckBox.Location = new System.Drawing.Point(181, 35);
            this.repeatedProgramCheckBox.Name = "repeatedProgramCheckBox";
            this.repeatedProgramCheckBox.Size = new System.Drawing.Size(61, 17);
            this.repeatedProgramCheckBox.TabIndex = 13;
            this.repeatedProgramCheckBox.Text = "Repeat";
            this.repeatedProgramCheckBox.UseVisualStyleBackColor = true;
            this.repeatedProgramCheckBox.CheckedChanged += new System.EventHandler(this.repeatedProgramCheckBox_CheckedChanged);
            // 
            // loadProgramButton
            // 
            this.loadProgramButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loadProgramButton.Location = new System.Drawing.Point(15, 219);
            this.loadProgramButton.Name = "loadProgramButton";
            this.loadProgramButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loadProgramButton.Size = new System.Drawing.Size(160, 35);
            this.loadProgramButton.TabIndex = 12;
            this.loadProgramButton.Text = "Load selected program";
            this.loadProgramButton.UseVisualStyleBackColor = true;
            this.loadProgramButton.Click += new System.EventHandler(this.loadProgramButton_Click);
            // 
            // dropProgramButton
            // 
            this.dropProgramButton.ForeColor = System.Drawing.Color.Black;
            this.dropProgramButton.Location = new System.Drawing.Point(16, 260);
            this.dropProgramButton.Name = "dropProgramButton";
            this.dropProgramButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dropProgramButton.Size = new System.Drawing.Size(160, 35);
            this.dropProgramButton.TabIndex = 12;
            this.dropProgramButton.Text = "Drop selected program";
            this.dropProgramButton.UseVisualStyleBackColor = true;
            this.dropProgramButton.Click += new System.EventHandler(this.dropProgramButton_Click);
            // 
            // selectProgramButton
            // 
            this.selectProgramButton.ForeColor = System.Drawing.Color.Black;
            this.selectProgramButton.Location = new System.Drawing.Point(15, 178);
            this.selectProgramButton.Name = "selectProgramButton";
            this.selectProgramButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectProgramButton.Size = new System.Drawing.Size(160, 35);
            this.selectProgramButton.TabIndex = 12;
            this.selectProgramButton.Text = "Select custom program";
            this.selectProgramButton.UseVisualStyleBackColor = true;
            this.selectProgramButton.Click += new System.EventHandler(this.selectProgramButton_Click);
            // 
            // storagePositionButton
            // 
            this.storagePositionButton.Location = new System.Drawing.Point(313, 66);
            this.storagePositionButton.Name = "storagePositionButton";
            this.storagePositionButton.Size = new System.Drawing.Size(160, 35);
            this.storagePositionButton.TabIndex = 11;
            this.storagePositionButton.Text = "Storage position";
            this.storagePositionButton.UseVisualStyleBackColor = true;
            this.storagePositionButton.Click += new System.EventHandler(this.storagePositionButton_Click);
            // 
            // testGripperButton
            // 
            this.testGripperButton.Location = new System.Drawing.Point(313, 107);
            this.testGripperButton.Name = "testGripperButton";
            this.testGripperButton.Size = new System.Drawing.Size(160, 35);
            this.testGripperButton.TabIndex = 10;
            this.testGripperButton.Text = "Test gripper";
            this.testGripperButton.UseVisualStyleBackColor = true;
            this.testGripperButton.Click += new System.EventHandler(this.testGripperButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pauseProgramButton
            // 
            this.pauseProgramButton.Location = new System.Drawing.Point(15, 66);
            this.pauseProgramButton.Name = "pauseProgramButton";
            this.pauseProgramButton.Size = new System.Drawing.Size(160, 35);
            this.pauseProgramButton.TabIndex = 8;
            this.pauseProgramButton.Text = "Pause";
            this.pauseProgramButton.UseVisualStyleBackColor = true;
            this.pauseProgramButton.Click += new System.EventHandler(this.buttonSendCommand);
            // 
            // startProgramButton
            // 
            this.startProgramButton.Location = new System.Drawing.Point(15, 25);
            this.startProgramButton.Name = "startProgramButton";
            this.startProgramButton.Size = new System.Drawing.Size(160, 35);
            this.startProgramButton.TabIndex = 7;
            this.startProgramButton.Text = "Start";
            this.startProgramButton.UseVisualStyleBackColor = true;
            this.startProgramButton.Click += new System.EventHandler(this.buttonSendCommand);
            // 
            // stopProgramButton
            // 
            this.stopProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopProgramButton.Location = new System.Drawing.Point(15, 107);
            this.stopProgramButton.Name = "stopProgramButton";
            this.stopProgramButton.Size = new System.Drawing.Size(160, 35);
            this.stopProgramButton.TabIndex = 6;
            this.stopProgramButton.Text = "Stop";
            this.stopProgramButton.UseVisualStyleBackColor = true;
            this.stopProgramButton.Click += new System.EventHandler(this.buttonSendCommand);
            // 
            // stopMovementButton
            // 
            this.stopMovementButton.BackColor = System.Drawing.Color.Transparent;
            this.stopMovementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopMovementButton.ForeColor = System.Drawing.Color.Firebrick;
            this.stopMovementButton.Location = new System.Drawing.Point(313, 189);
            this.stopMovementButton.Name = "stopMovementButton";
            this.stopMovementButton.Size = new System.Drawing.Size(160, 35);
            this.stopMovementButton.TabIndex = 5;
            this.stopMovementButton.Text = "Stop Movement";
            this.stopMovementButton.UseVisualStyleBackColor = false;
            this.stopMovementButton.Click += new System.EventHandler(this.stopMovementButton_Click);
            // 
            // testRobotButton
            // 
            this.testRobotButton.ForeColor = System.Drawing.Color.Red;
            this.testRobotButton.Location = new System.Drawing.Point(313, 148);
            this.testRobotButton.Name = "testRobotButton";
            this.testRobotButton.Size = new System.Drawing.Size(160, 35);
            this.testRobotButton.TabIndex = 5;
            this.testRobotButton.Text = "Test robot arm";
            this.testRobotButton.UseVisualStyleBackColor = true;
            this.testRobotButton.Visible = false;
            this.testRobotButton.Click += new System.EventHandler(this.testRobotButton_Click);
            // 
            // zeroPositionButton
            // 
            this.zeroPositionButton.Location = new System.Drawing.Point(313, 25);
            this.zeroPositionButton.Name = "zeroPositionButton";
            this.zeroPositionButton.Size = new System.Drawing.Size(160, 35);
            this.zeroPositionButton.TabIndex = 4;
            this.zeroPositionButton.Text = "Zero position";
            this.zeroPositionButton.UseVisualStyleBackColor = true;
            this.zeroPositionButton.Click += new System.EventHandler(this.zeroPositionButton_Click);
            // 
            // connectionStatusGroup
            // 
            this.connectionStatusGroup.Controls.Add(this.label12);
            this.connectionStatusGroup.Controls.Add(this.velocityRelStatusText);
            this.connectionStatusGroup.Controls.Add(this.velocityRelLabel);
            this.connectionStatusGroup.Controls.Add(this.programLoadedStatusText);
            this.connectionStatusGroup.Controls.Add(this.dataCollectionStatusText);
            this.connectionStatusGroup.Controls.Add(this.programLoadedStatusLabel);
            this.connectionStatusGroup.Controls.Add(this.dataCollectionStatusLabel);
            this.connectionStatusGroup.Controls.Add(this.selectedProgramStatusText);
            this.connectionStatusGroup.Controls.Add(this.selectedProgramLabel);
            this.connectionStatusGroup.Controls.Add(this.cStatusText);
            this.connectionStatusGroup.Controls.Add(this.bStatusText);
            this.connectionStatusGroup.Controls.Add(this.aStatusText);
            this.connectionStatusGroup.Controls.Add(this.zStatusText);
            this.connectionStatusGroup.Controls.Add(this.yStatusText);
            this.connectionStatusGroup.Controls.Add(this.xStatusText);
            this.connectionStatusGroup.Controls.Add(this.a6CurrentLabel);
            this.connectionStatusGroup.Controls.Add(this.a5CurrentLabel);
            this.connectionStatusGroup.Controls.Add(this.a4CurrentLabel);
            this.connectionStatusGroup.Controls.Add(this.zCurrentLabel);
            this.connectionStatusGroup.Controls.Add(this.yCurrentLabel);
            this.connectionStatusGroup.Controls.Add(this.xCurrentLabel);
            this.connectionStatusGroup.Controls.Add(this.label2);
            this.connectionStatusGroup.Controls.Add(this.a6StatusText);
            this.connectionStatusGroup.Controls.Add(this.a5StatusText);
            this.connectionStatusGroup.Controls.Add(this.a4StatusText);
            this.connectionStatusGroup.Controls.Add(this.a3StatusText);
            this.connectionStatusGroup.Controls.Add(this.a2StatusText);
            this.connectionStatusGroup.Controls.Add(this.a1StatusText);
            this.connectionStatusGroup.Controls.Add(this.label8);
            this.connectionStatusGroup.Controls.Add(this.label7);
            this.connectionStatusGroup.Controls.Add(this.label6);
            this.connectionStatusGroup.Controls.Add(this.a3Label);
            this.connectionStatusGroup.Controls.Add(this.a2Label);
            this.connectionStatusGroup.Controls.Add(this.a1label);
            this.connectionStatusGroup.Controls.Add(this.posLabel);
            this.connectionStatusGroup.Controls.Add(this.label1);
            this.connectionStatusGroup.Controls.Add(this.errorStatusText);
            this.connectionStatusGroup.Controls.Add(this.referencedStatusText);
            this.connectionStatusGroup.Controls.Add(this.connectionStatusText);
            this.connectionStatusGroup.Controls.Add(this.errorStatusLabel);
            this.connectionStatusGroup.Controls.Add(this.emergencyStatusLabel);
            this.connectionStatusGroup.Controls.Add(this.connectionStatusLabel);
            this.connectionStatusGroup.Location = new System.Drawing.Point(11, 212);
            this.connectionStatusGroup.Name = "connectionStatusGroup";
            this.connectionStatusGroup.Size = new System.Drawing.Size(491, 225);
            this.connectionStatusGroup.TabIndex = 0;
            this.connectionStatusGroup.TabStop = false;
            this.connectionStatusGroup.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 43;
            // 
            // velocityRelStatusText
            // 
            this.velocityRelStatusText.AutoSize = true;
            this.velocityRelStatusText.Location = new System.Drawing.Point(199, 142);
            this.velocityRelStatusText.Name = "velocityRelStatusText";
            this.velocityRelStatusText.Size = new System.Drawing.Size(22, 13);
            this.velocityRelStatusText.TabIndex = 41;
            this.velocityRelStatusText.Text = "0.0";
            // 
            // velocityRelLabel
            // 
            this.velocityRelLabel.AutoSize = true;
            this.velocityRelLabel.Location = new System.Drawing.Point(158, 142);
            this.velocityRelLabel.Name = "velocityRelLabel";
            this.velocityRelLabel.Size = new System.Drawing.Size(36, 13);
            this.velocityRelLabel.TabIndex = 40;
            this.velocityRelLabel.Text = "Vel %:";
            // 
            // programLoadedStatusText
            // 
            this.programLoadedStatusText.AutoSize = true;
            this.programLoadedStatusText.Location = new System.Drawing.Point(350, 46);
            this.programLoadedStatusText.Name = "programLoadedStatusText";
            this.programLoadedStatusText.Size = new System.Drawing.Size(24, 13);
            this.programLoadedStatusText.TabIndex = 39;
            this.programLoadedStatusText.Text = "n/a";
            // 
            // dataCollectionStatusText
            // 
            this.dataCollectionStatusText.AutoSize = true;
            this.dataCollectionStatusText.Location = new System.Drawing.Point(350, 70);
            this.dataCollectionStatusText.Name = "dataCollectionStatusText";
            this.dataCollectionStatusText.Size = new System.Drawing.Size(60, 13);
            this.dataCollectionStatusText.TabIndex = 38;
            this.dataCollectionStatusText.Text = "not running";
            // 
            // programLoadedStatusLabel
            // 
            this.programLoadedStatusLabel.AutoSize = true;
            this.programLoadedStatusLabel.Location = new System.Drawing.Point(253, 46);
            this.programLoadedStatusLabel.Name = "programLoadedStatusLabel";
            this.programLoadedStatusLabel.Size = new System.Drawing.Size(84, 13);
            this.programLoadedStatusLabel.TabIndex = 37;
            this.programLoadedStatusLabel.Text = "Program loaded:";
            // 
            // dataCollectionStatusLabel
            // 
            this.dataCollectionStatusLabel.AutoSize = true;
            this.dataCollectionStatusLabel.Location = new System.Drawing.Point(253, 70);
            this.dataCollectionStatusLabel.Name = "dataCollectionStatusLabel";
            this.dataCollectionStatusLabel.Size = new System.Drawing.Size(81, 13);
            this.dataCollectionStatusLabel.TabIndex = 36;
            this.dataCollectionStatusLabel.Text = "Data collection:";
            // 
            // selectedProgramStatusText
            // 
            this.selectedProgramStatusText.AutoSize = true;
            this.selectedProgramStatusText.Location = new System.Drawing.Point(350, 22);
            this.selectedProgramStatusText.Name = "selectedProgramStatusText";
            this.selectedProgramStatusText.Size = new System.Drawing.Size(24, 13);
            this.selectedProgramStatusText.TabIndex = 35;
            this.selectedProgramStatusText.Text = "n/a";
            // 
            // selectedProgramLabel
            // 
            this.selectedProgramLabel.AutoSize = true;
            this.selectedProgramLabel.Location = new System.Drawing.Point(253, 22);
            this.selectedProgramLabel.Name = "selectedProgramLabel";
            this.selectedProgramLabel.Size = new System.Drawing.Size(93, 13);
            this.selectedProgramLabel.TabIndex = 34;
            this.selectedProgramLabel.Text = "Selected program:";
            // 
            // cStatusText
            // 
            this.cStatusText.AutoSize = true;
            this.cStatusText.Location = new System.Drawing.Point(366, 190);
            this.cStatusText.Name = "cStatusText";
            this.cStatusText.Size = new System.Drawing.Size(22, 13);
            this.cStatusText.TabIndex = 33;
            this.cStatusText.Text = "0.0";
            // 
            // bStatusText
            // 
            this.bStatusText.AutoSize = true;
            this.bStatusText.Location = new System.Drawing.Point(366, 166);
            this.bStatusText.Name = "bStatusText";
            this.bStatusText.Size = new System.Drawing.Size(22, 13);
            this.bStatusText.TabIndex = 32;
            this.bStatusText.Text = "0.0";
            // 
            // aStatusText
            // 
            this.aStatusText.AutoSize = true;
            this.aStatusText.Location = new System.Drawing.Point(366, 142);
            this.aStatusText.Name = "aStatusText";
            this.aStatusText.Size = new System.Drawing.Size(22, 13);
            this.aStatusText.TabIndex = 31;
            this.aStatusText.Text = "0.0";
            // 
            // zStatusText
            // 
            this.zStatusText.AutoSize = true;
            this.zStatusText.Location = new System.Drawing.Point(282, 190);
            this.zStatusText.Name = "zStatusText";
            this.zStatusText.Size = new System.Drawing.Size(22, 13);
            this.zStatusText.TabIndex = 30;
            this.zStatusText.Text = "0.0";
            // 
            // yStatusText
            // 
            this.yStatusText.AutoSize = true;
            this.yStatusText.Location = new System.Drawing.Point(282, 166);
            this.yStatusText.Name = "yStatusText";
            this.yStatusText.Size = new System.Drawing.Size(22, 13);
            this.yStatusText.TabIndex = 29;
            this.yStatusText.Text = "0.0";
            // 
            // xStatusText
            // 
            this.xStatusText.AutoSize = true;
            this.xStatusText.Location = new System.Drawing.Point(282, 142);
            this.xStatusText.Name = "xStatusText";
            this.xStatusText.Size = new System.Drawing.Size(22, 13);
            this.xStatusText.TabIndex = 28;
            this.xStatusText.Text = "0.0";
            // 
            // a6CurrentLabel
            // 
            this.a6CurrentLabel.AutoSize = true;
            this.a6CurrentLabel.Location = new System.Drawing.Point(337, 190);
            this.a6CurrentLabel.Name = "a6CurrentLabel";
            this.a6CurrentLabel.Size = new System.Drawing.Size(17, 13);
            this.a6CurrentLabel.TabIndex = 27;
            this.a6CurrentLabel.Text = "C:";
            // 
            // a5CurrentLabel
            // 
            this.a5CurrentLabel.AutoSize = true;
            this.a5CurrentLabel.Location = new System.Drawing.Point(337, 166);
            this.a5CurrentLabel.Name = "a5CurrentLabel";
            this.a5CurrentLabel.Size = new System.Drawing.Size(17, 13);
            this.a5CurrentLabel.TabIndex = 26;
            this.a5CurrentLabel.Text = "B:";
            // 
            // a4CurrentLabel
            // 
            this.a4CurrentLabel.AutoSize = true;
            this.a4CurrentLabel.Location = new System.Drawing.Point(337, 142);
            this.a4CurrentLabel.Name = "a4CurrentLabel";
            this.a4CurrentLabel.Size = new System.Drawing.Size(17, 13);
            this.a4CurrentLabel.TabIndex = 25;
            this.a4CurrentLabel.Text = "A:";
            // 
            // zCurrentLabel
            // 
            this.zCurrentLabel.AutoSize = true;
            this.zCurrentLabel.Location = new System.Drawing.Point(253, 190);
            this.zCurrentLabel.Name = "zCurrentLabel";
            this.zCurrentLabel.Size = new System.Drawing.Size(17, 13);
            this.zCurrentLabel.TabIndex = 24;
            this.zCurrentLabel.Text = "Z:";
            // 
            // yCurrentLabel
            // 
            this.yCurrentLabel.AutoSize = true;
            this.yCurrentLabel.Location = new System.Drawing.Point(253, 166);
            this.yCurrentLabel.Name = "yCurrentLabel";
            this.yCurrentLabel.Size = new System.Drawing.Size(17, 13);
            this.yCurrentLabel.TabIndex = 23;
            this.yCurrentLabel.Text = "Y:";
            // 
            // xCurrentLabel
            // 
            this.xCurrentLabel.AutoSize = true;
            this.xCurrentLabel.Location = new System.Drawing.Point(253, 142);
            this.xCurrentLabel.Name = "xCurrentLabel";
            this.xCurrentLabel.Size = new System.Drawing.Size(17, 13);
            this.xCurrentLabel.TabIndex = 22;
            this.xCurrentLabel.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cartesian Positions";
            // 
            // a6StatusText
            // 
            this.a6StatusText.AutoSize = true;
            this.a6StatusText.Location = new System.Drawing.Point(115, 190);
            this.a6StatusText.Name = "a6StatusText";
            this.a6StatusText.Size = new System.Drawing.Size(22, 13);
            this.a6StatusText.TabIndex = 20;
            this.a6StatusText.Text = "0.0";
            // 
            // a5StatusText
            // 
            this.a5StatusText.AutoSize = true;
            this.a5StatusText.Location = new System.Drawing.Point(115, 166);
            this.a5StatusText.Name = "a5StatusText";
            this.a5StatusText.Size = new System.Drawing.Size(22, 13);
            this.a5StatusText.TabIndex = 19;
            this.a5StatusText.Text = "0.0";
            // 
            // a4StatusText
            // 
            this.a4StatusText.AutoSize = true;
            this.a4StatusText.Location = new System.Drawing.Point(115, 142);
            this.a4StatusText.Name = "a4StatusText";
            this.a4StatusText.Size = new System.Drawing.Size(22, 13);
            this.a4StatusText.TabIndex = 18;
            this.a4StatusText.Text = "0.0";
            // 
            // a3StatusText
            // 
            this.a3StatusText.AutoSize = true;
            this.a3StatusText.Location = new System.Drawing.Point(41, 190);
            this.a3StatusText.Name = "a3StatusText";
            this.a3StatusText.Size = new System.Drawing.Size(22, 13);
            this.a3StatusText.TabIndex = 17;
            this.a3StatusText.Text = "0.0";
            // 
            // a2StatusText
            // 
            this.a2StatusText.AutoSize = true;
            this.a2StatusText.Location = new System.Drawing.Point(41, 166);
            this.a2StatusText.Name = "a2StatusText";
            this.a2StatusText.Size = new System.Drawing.Size(22, 13);
            this.a2StatusText.TabIndex = 16;
            this.a2StatusText.Text = "0.0";
            // 
            // a1StatusText
            // 
            this.a1StatusText.AutoSize = true;
            this.a1StatusText.Location = new System.Drawing.Point(41, 142);
            this.a1StatusText.Name = "a1StatusText";
            this.a1StatusText.Size = new System.Drawing.Size(22, 13);
            this.a1StatusText.TabIndex = 15;
            this.a1StatusText.Text = "0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "A6:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "A5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "A4:";
            // 
            // a3Label
            // 
            this.a3Label.AutoSize = true;
            this.a3Label.Location = new System.Drawing.Point(12, 190);
            this.a3Label.Name = "a3Label";
            this.a3Label.Size = new System.Drawing.Size(23, 13);
            this.a3Label.TabIndex = 10;
            this.a3Label.Text = "A3:";
            // 
            // a2Label
            // 
            this.a2Label.AutoSize = true;
            this.a2Label.Location = new System.Drawing.Point(12, 166);
            this.a2Label.Name = "a2Label";
            this.a2Label.Size = new System.Drawing.Size(23, 13);
            this.a2Label.TabIndex = 9;
            this.a2Label.Text = "A2:";
            // 
            // a1label
            // 
            this.a1label.AutoSize = true;
            this.a1label.Location = new System.Drawing.Point(12, 142);
            this.a1label.Name = "a1label";
            this.a1label.Size = new System.Drawing.Size(23, 13);
            this.a1label.TabIndex = 8;
            this.a1label.Text = "A1:";
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.Location = new System.Drawing.Point(12, 118);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(74, 13);
            this.posLabel.TabIndex = 7;
            this.posLabel.Text = "Joint Positions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // errorStatusText
            // 
            this.errorStatusText.AutoSize = true;
            this.errorStatusText.ForeColor = System.Drawing.Color.Red;
            this.errorStatusText.Location = new System.Drawing.Point(79, 70);
            this.errorStatusText.Name = "errorStatusText";
            this.errorStatusText.Size = new System.Drawing.Size(24, 13);
            this.errorStatusText.TabIndex = 5;
            this.errorStatusText.Text = "n/a";
            this.errorStatusText.Visible = false;
            // 
            // referencedStatusText
            // 
            this.referencedStatusText.AutoSize = true;
            this.referencedStatusText.ForeColor = System.Drawing.Color.Red;
            this.referencedStatusText.Location = new System.Drawing.Point(79, 46);
            this.referencedStatusText.Name = "referencedStatusText";
            this.referencedStatusText.Size = new System.Drawing.Size(24, 13);
            this.referencedStatusText.TabIndex = 4;
            this.referencedStatusText.Text = "n/a";
            this.referencedStatusText.Visible = false;
            // 
            // connectionStatusText
            // 
            this.connectionStatusText.AutoSize = true;
            this.connectionStatusText.ForeColor = System.Drawing.Color.Black;
            this.connectionStatusText.Location = new System.Drawing.Point(80, 22);
            this.connectionStatusText.Name = "connectionStatusText";
            this.connectionStatusText.Size = new System.Drawing.Size(24, 13);
            this.connectionStatusText.TabIndex = 3;
            this.connectionStatusText.Text = "n/a";
            // 
            // errorStatusLabel
            // 
            this.errorStatusLabel.AutoSize = true;
            this.errorStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.errorStatusLabel.Location = new System.Drawing.Point(11, 70);
            this.errorStatusLabel.Name = "errorStatusLabel";
            this.errorStatusLabel.Size = new System.Drawing.Size(32, 13);
            this.errorStatusLabel.TabIndex = 2;
            this.errorStatusLabel.Text = "Error:";
            this.errorStatusLabel.Visible = false;
            // 
            // emergencyStatusLabel
            // 
            this.emergencyStatusLabel.AutoSize = true;
            this.emergencyStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.emergencyStatusLabel.Location = new System.Drawing.Point(11, 46);
            this.emergencyStatusLabel.Name = "emergencyStatusLabel";
            this.emergencyStatusLabel.Size = new System.Drawing.Size(66, 13);
            this.emergencyStatusLabel.TabIndex = 1;
            this.emergencyStatusLabel.Text = "Referenced:";
            this.emergencyStatusLabel.Visible = false;
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(12, 22);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.connectionStatusLabel.TabIndex = 0;
            this.connectionStatusLabel.Text = "Status:";
            // 
            // connectionControlGroup
            // 
            this.connectionControlGroup.Controls.Add(this.button2);
            this.connectionControlGroup.Controls.Add(this.label4);
            this.connectionControlGroup.Controls.Add(this.disconnectButton);
            this.connectionControlGroup.Controls.Add(this.connectButton);
            this.connectionControlGroup.Controls.Add(this.comboBoxConnections);
            this.connectionControlGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.connectionControlGroup.Location = new System.Drawing.Point(10, 6);
            this.connectionControlGroup.Name = "connectionControlGroup";
            this.connectionControlGroup.Size = new System.Drawing.Size(491, 202);
            this.connectionControlGroup.TabIndex = 0;
            this.connectionControlGroup.TabStop = false;
            this.connectionControlGroup.Text = "Connection Control";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(299, 66);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(160, 35);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.connectButton.Location = new System.Drawing.Point(299, 25);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(160, 35);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // comboBoxConnections
            // 
            this.comboBoxConnections.AllowDrop = true;
            this.comboBoxConnections.BackColor = System.Drawing.Color.White;
            this.comboBoxConnections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConnections.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxConnections.FormattingEnabled = true;
            this.comboBoxConnections.ItemHeight = 13;
            this.comboBoxConnections.Items.AddRange(new object[] {
            "127.0.0.1 - CRI Server",
            "192.168.3.11 - USB CAN"});
            this.comboBoxConnections.Location = new System.Drawing.Point(15, 25);
            this.comboBoxConnections.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxConnections.Name = "comboBoxConnections";
            this.comboBoxConnections.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxConnections.Size = new System.Drawing.Size(209, 21);
            this.comboBoxConnections.TabIndex = 0;
            this.comboBoxConnections.SelectedIndexChanged += new System.EventHandler(this.comboBoxConnections_SelectedIndexChanged);
            // 
            // dataPage
            // 
            this.dataPage.BackColor = System.Drawing.Color.Transparent;
            this.dataPage.Controls.Add(this.dataProgressBarGroup);
            this.dataPage.Controls.Add(this.groupBox3);
            this.dataPage.Controls.Add(this.groupBox1);
            this.dataPage.Location = new System.Drawing.Point(4, 22);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataPage.Size = new System.Drawing.Size(1011, 445);
            this.dataPage.TabIndex = 1;
            this.dataPage.Text = "Data";
            // 
            // dataProgressBarGroup
            // 
            this.dataProgressBarGroup.Controls.Add(this.progressInPercent);
            this.dataProgressBarGroup.Controls.Add(this.progressBarCollection);
            this.dataProgressBarGroup.Location = new System.Drawing.Point(510, 6);
            this.dataProgressBarGroup.Name = "dataProgressBarGroup";
            this.dataProgressBarGroup.Size = new System.Drawing.Size(489, 46);
            this.dataProgressBarGroup.TabIndex = 1;
            this.dataProgressBarGroup.TabStop = false;
            this.dataProgressBarGroup.Text = "Progress";
            // 
            // progressInPercent
            // 
            this.progressInPercent.AutoSize = true;
            this.progressInPercent.Location = new System.Drawing.Point(447, 21);
            this.progressInPercent.Name = "progressInPercent";
            this.progressInPercent.Size = new System.Drawing.Size(36, 13);
            this.progressInPercent.TabIndex = 1;
            this.progressInPercent.Text = "000 %";
            // 
            // progressBarCollection
            // 
            this.progressBarCollection.Location = new System.Drawing.Point(9, 15);
            this.progressBarCollection.Name = "progressBarCollection";
            this.progressBarCollection.Size = new System.Drawing.Size(435, 25);
            this.progressBarCollection.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label43);
            this.groupBox3.Controls.Add(this.linkLabelCRIDocumentation);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.opmodeCheckBox);
            this.groupBox3.Controls.Add(this.errorCheckBox);
            this.groupBox3.Controls.Add(this.kinstateCheckBox);
            this.groupBox3.Controls.Add(this.currentjointsCheckBox);
            this.groupBox3.Controls.Add(this.currentallCheckBox);
            this.groupBox3.Controls.Add(this.supplyCheckBox);
            this.groupBox3.Controls.Add(this.estopCheckBox);
            this.groupBox3.Controls.Add(this.dindoutCheckBox);
            this.groupBox3.Controls.Add(this.overrideCheckBox);
            this.groupBox3.Controls.Add(this.poscartplatformCheckBox);
            this.groupBox3.Controls.Add(this.poscartrobotCheckBox);
            this.groupBox3.Controls.Add(this.posjointcurrentCheckBox);
            this.groupBox3.Controls.Add(this.posjointsetpointCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(510, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 381);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Collection";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(15, 356);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(233, 13);
            this.label43.TabIndex = 3;
            this.label43.Text = "To better understand the data see the following:";
            // 
            // linkLabelCRIDocumentation
            // 
            this.linkLabelCRIDocumentation.AutoSize = true;
            this.linkLabelCRIDocumentation.Location = new System.Drawing.Point(245, 356);
            this.linkLabelCRIDocumentation.Name = "linkLabelCRIDocumentation";
            this.linkLabelCRIDocumentation.Size = new System.Drawing.Size(174, 13);
            this.linkLabelCRIDocumentation.TabIndex = 2;
            this.linkLabelCRIDocumentation.TabStop = true;
            this.linkLabelCRIDocumentation.Text = "RobotInterface CRI Documentation";
            this.linkLabelCRIDocumentation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCRIDocumentation_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Check the data you want to be sampled. Recommended data is pre-checked.";
            // 
            // opmodeCheckBox
            // 
            this.opmodeCheckBox.AutoSize = true;
            this.opmodeCheckBox.Location = new System.Drawing.Point(18, 300);
            this.opmodeCheckBox.Name = "opmodeCheckBox";
            this.opmodeCheckBox.Size = new System.Drawing.Size(213, 17);
            this.opmodeCheckBox.TabIndex = 0;
            this.opmodeCheckBox.Text = "OPMODE - State of the safety switched";
            this.opmodeCheckBox.UseVisualStyleBackColor = true;
            this.opmodeCheckBox.Visible = false;
            this.opmodeCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // errorCheckBox
            // 
            this.errorCheckBox.AutoSize = true;
            this.errorCheckBox.Location = new System.Drawing.Point(18, 277);
            this.errorCheckBox.Name = "errorCheckBox";
            this.errorCheckBox.Size = new System.Drawing.Size(152, 17);
            this.errorCheckBox.TabIndex = 0;
            this.errorCheckBox.Text = "ERROR - Joint error codes";
            this.errorCheckBox.UseVisualStyleBackColor = true;
            this.errorCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // kinstateCheckBox
            // 
            this.kinstateCheckBox.AutoSize = true;
            this.kinstateCheckBox.Location = new System.Drawing.Point(18, 254);
            this.kinstateCheckBox.Name = "kinstateCheckBox";
            this.kinstateCheckBox.Size = new System.Drawing.Size(165, 17);
            this.kinstateCheckBox.TabIndex = 0;
            this.kinstateCheckBox.Text = "KINSTATE - Kinematic status";
            this.kinstateCheckBox.UseVisualStyleBackColor = true;
            this.kinstateCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // currentjointsCheckBox
            // 
            this.currentjointsCheckBox.AutoSize = true;
            this.currentjointsCheckBox.Location = new System.Drawing.Point(18, 231);
            this.currentjointsCheckBox.Name = "currentjointsCheckBox";
            this.currentjointsCheckBox.Size = new System.Drawing.Size(311, 17);
            this.currentjointsCheckBox.TabIndex = 0;
            this.currentjointsCheckBox.Text = "CURRENTJOINTS - Motor current of the single joints (in mA)";
            this.currentjointsCheckBox.UseVisualStyleBackColor = true;
            this.currentjointsCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // currentallCheckBox
            // 
            this.currentallCheckBox.AutoSize = true;
            this.currentallCheckBox.Location = new System.Drawing.Point(19, 208);
            this.currentallCheckBox.Name = "currentallCheckBox";
            this.currentallCheckBox.Size = new System.Drawing.Size(260, 17);
            this.currentallCheckBox.TabIndex = 0;
            this.currentallCheckBox.Text = "CURRENTALL - Motor current for all joints (in mA)";
            this.currentallCheckBox.UseVisualStyleBackColor = true;
            this.currentallCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // supplyCheckBox
            // 
            this.supplyCheckBox.AutoSize = true;
            this.supplyCheckBox.Location = new System.Drawing.Point(18, 185);
            this.supplyCheckBox.Name = "supplyCheckBox";
            this.supplyCheckBox.Size = new System.Drawing.Size(246, 17);
            this.supplyCheckBox.TabIndex = 0;
            this.supplyCheckBox.Text = "SUPPLY - Level of the main supply (in voltage)";
            this.supplyCheckBox.UseVisualStyleBackColor = true;
            this.supplyCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // estopCheckBox
            // 
            this.estopCheckBox.AutoSize = true;
            this.estopCheckBox.Location = new System.Drawing.Point(18, 162);
            this.estopCheckBox.Name = "estopCheckBox";
            this.estopCheckBox.Size = new System.Drawing.Size(243, 17);
            this.estopCheckBox.TabIndex = 0;
            this.estopCheckBox.Text = "ESTOP - Status of emergency stop/main relay";
            this.estopCheckBox.UseVisualStyleBackColor = true;
            this.estopCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // dindoutCheckBox
            // 
            this.dindoutCheckBox.AutoSize = true;
            this.dindoutCheckBox.Location = new System.Drawing.Point(18, 139);
            this.dindoutCheckBox.Name = "dindoutCheckBox";
            this.dindoutCheckBox.Size = new System.Drawing.Size(269, 17);
            this.dindoutCheckBox.TabIndex = 0;
            this.dindoutCheckBox.Text = "DIN DOUT - Current status of digital Inputs/Outputs";
            this.dindoutCheckBox.UseVisualStyleBackColor = true;
            this.dindoutCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // overrideCheckBox
            // 
            this.overrideCheckBox.AutoSize = true;
            this.overrideCheckBox.Location = new System.Drawing.Point(18, 116);
            this.overrideCheckBox.Name = "overrideCheckBox";
            this.overrideCheckBox.Size = new System.Drawing.Size(300, 17);
            this.overrideCheckBox.TabIndex = 0;
            this.overrideCheckBox.Text = "OVERRIDE - Percentage of velocity of mocement of robot";
            this.overrideCheckBox.UseVisualStyleBackColor = true;
            this.overrideCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // poscartplatformCheckBox
            // 
            this.poscartplatformCheckBox.AutoSize = true;
            this.poscartplatformCheckBox.Location = new System.Drawing.Point(18, 93);
            this.poscartplatformCheckBox.Name = "poscartplatformCheckBox";
            this.poscartplatformCheckBox.Size = new System.Drawing.Size(378, 17);
            this.poscartplatformCheckBox.TabIndex = 0;
            this.poscartplatformCheckBox.Text = "POSCARTPLATFORM - Position XY and rotation RZ of the mobile platform";
            this.poscartplatformCheckBox.UseVisualStyleBackColor = true;
            this.poscartplatformCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // poscartrobotCheckBox
            // 
            this.poscartrobotCheckBox.AutoSize = true;
            this.poscartrobotCheckBox.Location = new System.Drawing.Point(18, 70);
            this.poscartrobotCheckBox.Name = "poscartrobotCheckBox";
            this.poscartrobotCheckBox.Size = new System.Drawing.Size(305, 17);
            this.poscartrobotCheckBox.TabIndex = 0;
            this.poscartrobotCheckBox.Text = "POSCARTROBOT - Cartesian positions (in mm and degree)";
            this.poscartrobotCheckBox.UseVisualStyleBackColor = true;
            this.poscartrobotCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // posjointcurrentCheckBox
            // 
            this.posjointcurrentCheckBox.AutoSize = true;
            this.posjointcurrentCheckBox.Location = new System.Drawing.Point(18, 47);
            this.posjointcurrentCheckBox.Name = "posjointcurrentCheckBox";
            this.posjointcurrentCheckBox.Size = new System.Drawing.Size(332, 17);
            this.posjointcurrentCheckBox.TabIndex = 0;
            this.posjointcurrentCheckBox.Text = "POSJOINTCURRENT - Current physical joint positions (in degee)";
            this.posjointcurrentCheckBox.UseVisualStyleBackColor = true;
            this.posjointcurrentCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // posjointsetpointCheckBox
            // 
            this.posjointsetpointCheckBox.AutoSize = true;
            this.posjointsetpointCheckBox.Location = new System.Drawing.Point(19, 24);
            this.posjointsetpointCheckBox.Name = "posjointsetpointCheckBox";
            this.posjointsetpointCheckBox.Size = new System.Drawing.Size(277, 17);
            this.posjointsetpointCheckBox.TabIndex = 0;
            this.posjointsetpointCheckBox.Text = "POSJOINTSETPOINT - Set joint positions (in degree)";
            this.posjointsetpointCheckBox.UseVisualStyleBackColor = true;
            this.posjointsetpointCheckBox.CheckedChanged += new System.EventHandler(this.collectionFlagsCheckBox_Changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fixedSamplingRateText);
            this.groupBox1.Controls.Add(this.fixedRepetitionsText);
            this.groupBox1.Controls.Add(this.fixedDatasetNameText);
            this.groupBox1.Controls.Add(this.currentRepetitionText);
            this.groupBox1.Controls.Add(this.collectionRunningText);
            this.groupBox1.Controls.Add(this.collectionReadyText);
            this.groupBox1.Controls.Add(this.fixedOutputDirText);
            this.groupBox1.Controls.Add(this.fixedProgramNameText);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.fixedOutputDirLabel);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.stopDataCollectionButton);
            this.groupBox1.Controls.Add(this.startDataCollectionButton);
            this.groupBox1.Controls.Add(this.samplingRateLabel);
            this.groupBox1.Controls.Add(this.clearCollectionSettingsButton);
            this.groupBox1.Controls.Add(this.unfixCollectionSettingsButton);
            this.groupBox1.Controls.Add(this.fixCollectionSettingsButton);
            this.groupBox1.Controls.Add(this.moveToStartPosButton);
            this.groupBox1.Controls.Add(this.samplingRateTextBox);
            this.groupBox1.Controls.Add(this.datasetNameTextBox);
            this.groupBox1.Controls.Add(this.selectedProgramTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.repetitionsTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.selectProgrammButtonDataPage);
            this.groupBox1.Controls.Add(this.selectOutputDirectory);
            this.groupBox1.Controls.Add(this.selectedOutputDirTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // fixedSamplingRateText
            // 
            this.fixedSamplingRateText.AutoSize = true;
            this.fixedSamplingRateText.Location = new System.Drawing.Point(109, 344);
            this.fixedSamplingRateText.Name = "fixedSamplingRateText";
            this.fixedSamplingRateText.Size = new System.Drawing.Size(47, 13);
            this.fixedSamplingRateText.TabIndex = 6;
            this.fixedSamplingRateText.Text = "not fixed";
            // 
            // fixedRepetitionsText
            // 
            this.fixedRepetitionsText.AutoSize = true;
            this.fixedRepetitionsText.Location = new System.Drawing.Point(109, 323);
            this.fixedRepetitionsText.Name = "fixedRepetitionsText";
            this.fixedRepetitionsText.Size = new System.Drawing.Size(47, 13);
            this.fixedRepetitionsText.TabIndex = 6;
            this.fixedRepetitionsText.Text = "not fixed";
            // 
            // fixedDatasetNameText
            // 
            this.fixedDatasetNameText.AutoSize = true;
            this.fixedDatasetNameText.Location = new System.Drawing.Point(109, 302);
            this.fixedDatasetNameText.Name = "fixedDatasetNameText";
            this.fixedDatasetNameText.Size = new System.Drawing.Size(47, 13);
            this.fixedDatasetNameText.TabIndex = 6;
            this.fixedDatasetNameText.Text = "not fixed";
            // 
            // currentRepetitionText
            // 
            this.currentRepetitionText.AutoSize = true;
            this.currentRepetitionText.Location = new System.Drawing.Point(333, 344);
            this.currentRepetitionText.Name = "currentRepetitionText";
            this.currentRepetitionText.Size = new System.Drawing.Size(13, 13);
            this.currentRepetitionText.TabIndex = 6;
            this.currentRepetitionText.Text = "0";
            // 
            // collectionRunningText
            // 
            this.collectionRunningText.AutoSize = true;
            this.collectionRunningText.Location = new System.Drawing.Point(333, 323);
            this.collectionRunningText.Name = "collectionRunningText";
            this.collectionRunningText.Size = new System.Drawing.Size(60, 13);
            this.collectionRunningText.TabIndex = 6;
            this.collectionRunningText.Text = "not running";
            // 
            // collectionReadyText
            // 
            this.collectionReadyText.AutoSize = true;
            this.collectionReadyText.Location = new System.Drawing.Point(333, 302);
            this.collectionReadyText.Name = "collectionReadyText";
            this.collectionReadyText.Size = new System.Drawing.Size(51, 13);
            this.collectionReadyText.TabIndex = 6;
            this.collectionReadyText.Text = "not ready";
            // 
            // fixedOutputDirText
            // 
            this.fixedOutputDirText.AutoSize = true;
            this.fixedOutputDirText.Location = new System.Drawing.Point(333, 283);
            this.fixedOutputDirText.Name = "fixedOutputDirText";
            this.fixedOutputDirText.Size = new System.Drawing.Size(47, 13);
            this.fixedOutputDirText.TabIndex = 6;
            this.fixedOutputDirText.Text = "not fixed";
            // 
            // fixedProgramNameText
            // 
            this.fixedProgramNameText.AutoSize = true;
            this.fixedProgramNameText.Location = new System.Drawing.Point(109, 282);
            this.fixedProgramNameText.Name = "fixedProgramNameText";
            this.fixedProgramNameText.Size = new System.Drawing.Size(47, 13);
            this.fixedProgramNameText.TabIndex = 6;
            this.fixedProgramNameText.Text = "not fixed";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(13, 344);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(74, 13);
            this.label35.TabIndex = 6;
            this.label35.Text = "Sampling rate:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(13, 323);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(63, 13);
            this.label33.TabIndex = 6;
            this.label33.Text = "Repetitions:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(13, 302);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(76, 13);
            this.label31.TabIndex = 6;
            this.label31.Text = "Dataset name:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(237, 344);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(90, 13);
            this.label44.TabIndex = 6;
            this.label44.Text = "Current repetition:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(237, 323);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(94, 13);
            this.label41.TabIndex = 6;
            this.label41.Text = "Collection running:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(237, 302);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(85, 13);
            this.label39.TabIndex = 6;
            this.label39.Text = "Collection ready:";
            // 
            // fixedOutputDirLabel
            // 
            this.fixedOutputDirLabel.AutoSize = true;
            this.fixedOutputDirLabel.Location = new System.Drawing.Point(237, 283);
            this.fixedOutputDirLabel.Name = "fixedOutputDirLabel";
            this.fixedOutputDirLabel.Size = new System.Drawing.Size(85, 13);
            this.fixedOutputDirLabel.TabIndex = 6;
            this.fixedOutputDirLabel.Text = "Output directory:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(13, 282);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(78, 13);
            this.label29.TabIndex = 6;
            this.label29.Text = "Program name:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(13, 258);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(122, 13);
            this.label28.TabIndex = 5;
            this.label28.Text = "Fixed Collection Settings";
            // 
            // stopDataCollectionButton
            // 
            this.stopDataCollectionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stopDataCollectionButton.Location = new System.Drawing.Point(313, 386);
            this.stopDataCollectionButton.Name = "stopDataCollectionButton";
            this.stopDataCollectionButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stopDataCollectionButton.Size = new System.Drawing.Size(123, 34);
            this.stopDataCollectionButton.TabIndex = 4;
            this.stopDataCollectionButton.Text = "Stop Data Collection";
            this.stopDataCollectionButton.UseVisualStyleBackColor = true;
            this.stopDataCollectionButton.Click += new System.EventHandler(this.stopDataCollectionButton_Click);
            // 
            // startDataCollectionButton
            // 
            this.startDataCollectionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startDataCollectionButton.Location = new System.Drawing.Point(184, 386);
            this.startDataCollectionButton.Name = "startDataCollectionButton";
            this.startDataCollectionButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startDataCollectionButton.Size = new System.Drawing.Size(123, 34);
            this.startDataCollectionButton.TabIndex = 4;
            this.startDataCollectionButton.Text = "Start Data Collection";
            this.startDataCollectionButton.UseVisualStyleBackColor = true;
            this.startDataCollectionButton.Click += new System.EventHandler(this.startDataCollectionButton_Click);
            // 
            // samplingRateLabel
            // 
            this.samplingRateLabel.AutoSize = true;
            this.samplingRateLabel.Location = new System.Drawing.Point(13, 148);
            this.samplingRateLabel.Name = "samplingRateLabel";
            this.samplingRateLabel.Size = new System.Drawing.Size(93, 13);
            this.samplingRateLabel.TabIndex = 2;
            this.samplingRateLabel.Text = "Sampling rate (Hz)";
            // 
            // clearCollectionSettingsButton
            // 
            this.clearCollectionSettingsButton.Location = new System.Drawing.Point(15, 196);
            this.clearCollectionSettingsButton.Name = "clearCollectionSettingsButton";
            this.clearCollectionSettingsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearCollectionSettingsButton.Size = new System.Drawing.Size(123, 34);
            this.clearCollectionSettingsButton.TabIndex = 4;
            this.clearCollectionSettingsButton.Text = "Clear collection settings";
            this.clearCollectionSettingsButton.UseVisualStyleBackColor = true;
            this.clearCollectionSettingsButton.Click += new System.EventHandler(this.clearCollectionSettingsButton_Click);
            // 
            // unfixCollectionSettingsButton
            // 
            this.unfixCollectionSettingsButton.Location = new System.Drawing.Point(184, 196);
            this.unfixCollectionSettingsButton.Name = "unfixCollectionSettingsButton";
            this.unfixCollectionSettingsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.unfixCollectionSettingsButton.Size = new System.Drawing.Size(123, 34);
            this.unfixCollectionSettingsButton.TabIndex = 4;
            this.unfixCollectionSettingsButton.Text = "Unfix collection settings";
            this.unfixCollectionSettingsButton.UseVisualStyleBackColor = true;
            this.unfixCollectionSettingsButton.Click += new System.EventHandler(this.unfixCollectionSettingsButton_Click);
            // 
            // fixCollectionSettingsButton
            // 
            this.fixCollectionSettingsButton.Location = new System.Drawing.Point(313, 196);
            this.fixCollectionSettingsButton.Name = "fixCollectionSettingsButton";
            this.fixCollectionSettingsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fixCollectionSettingsButton.Size = new System.Drawing.Size(123, 34);
            this.fixCollectionSettingsButton.TabIndex = 4;
            this.fixCollectionSettingsButton.Text = "Fix collection settings";
            this.fixCollectionSettingsButton.UseVisualStyleBackColor = true;
            this.fixCollectionSettingsButton.Click += new System.EventHandler(this.fixCollectionSettingsButton_Click);
            // 
            // moveToStartPosButton
            // 
            this.moveToStartPosButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.moveToStartPosButton.Location = new System.Drawing.Point(15, 386);
            this.moveToStartPosButton.Name = "moveToStartPosButton";
            this.moveToStartPosButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.moveToStartPosButton.Size = new System.Drawing.Size(123, 34);
            this.moveToStartPosButton.TabIndex = 4;
            this.moveToStartPosButton.Text = "Move to start position";
            this.moveToStartPosButton.UseVisualStyleBackColor = true;
            this.moveToStartPosButton.Click += new System.EventHandler(this.moveToStartPosButton_Click);
            // 
            // samplingRateTextBox
            // 
            this.samplingRateTextBox.Location = new System.Drawing.Point(112, 145);
            this.samplingRateTextBox.Name = "samplingRateTextBox";
            this.samplingRateTextBox.Size = new System.Drawing.Size(195, 20);
            this.samplingRateTextBox.TabIndex = 3;
            this.samplingRateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intTextBox_KeyPress);
            // 
            // datasetNameTextBox
            // 
            this.datasetNameTextBox.Location = new System.Drawing.Point(112, 93);
            this.datasetNameTextBox.Name = "datasetNameTextBox";
            this.datasetNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.datasetNameTextBox.TabIndex = 3;
            // 
            // selectedProgramTextBox
            // 
            this.selectedProgramTextBox.Location = new System.Drawing.Point(112, 67);
            this.selectedProgramTextBox.Name = "selectedProgramTextBox";
            this.selectedProgramTextBox.Size = new System.Drawing.Size(195, 20);
            this.selectedProgramTextBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Dataset name";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 70);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 13);
            this.label27.TabIndex = 3;
            this.label27.Text = "Program ";
            // 
            // repetitionsTextBox
            // 
            this.repetitionsTextBox.Location = new System.Drawing.Point(112, 119);
            this.repetitionsTextBox.Name = "repetitionsTextBox";
            this.repetitionsTextBox.Size = new System.Drawing.Size(195, 20);
            this.repetitionsTextBox.TabIndex = 3;
            this.repetitionsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetitions";
            // 
            // selectProgrammButtonDataPage
            // 
            this.selectProgrammButtonDataPage.Location = new System.Drawing.Point(313, 67);
            this.selectProgrammButtonDataPage.Name = "selectProgrammButtonDataPage";
            this.selectProgrammButtonDataPage.Size = new System.Drawing.Size(123, 20);
            this.selectProgrammButtonDataPage.TabIndex = 1;
            this.selectProgrammButtonDataPage.Text = "Select program";
            this.selectProgrammButtonDataPage.UseVisualStyleBackColor = true;
            this.selectProgrammButtonDataPage.Click += new System.EventHandler(this.selectProgramButton_Click);
            // 
            // selectOutputDirectory
            // 
            this.selectOutputDirectory.Location = new System.Drawing.Point(313, 26);
            this.selectOutputDirectory.Name = "selectOutputDirectory";
            this.selectOutputDirectory.Size = new System.Drawing.Size(123, 20);
            this.selectOutputDirectory.TabIndex = 1;
            this.selectOutputDirectory.Text = "Select output directory";
            this.selectOutputDirectory.UseVisualStyleBackColor = true;
            this.selectOutputDirectory.Click += new System.EventHandler(this.selectOutputDirectory_Click);
            // 
            // selectedOutputDirTextBox
            // 
            this.selectedOutputDirTextBox.Location = new System.Drawing.Point(15, 26);
            this.selectedOutputDirTextBox.Name = "selectedOutputDirTextBox";
            this.selectedOutputDirTextBox.Size = new System.Drawing.Size(292, 20);
            this.selectedOutputDirTextBox.TabIndex = 0;
            // 
            // handControlPage
            // 
            this.handControlPage.BackColor = System.Drawing.Color.Transparent;
            this.handControlPage.Controls.Add(this.groupBox4);
            this.handControlPage.Controls.Add(this.groupBox5);
            this.handControlPage.Controls.Add(this.jointMoveGroup);
            this.handControlPage.Location = new System.Drawing.Point(4, 22);
            this.handControlPage.Name = "handControlPage";
            this.handControlPage.Padding = new System.Windows.Forms.Padding(3);
            this.handControlPage.Size = new System.Drawing.Size(1011, 445);
            this.handControlPage.TabIndex = 1;
            this.handControlPage.Text = "Hand Control";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.moveRelativeToCoordinateButton);
            this.groupBox4.Controls.Add(this.velocityAbsMovementText);
            this.groupBox4.Controls.Add(this.moveToCoordinateButton);
            this.groupBox4.Controls.Add(this.xMovementText);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.cMovementText);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.yMovementText);
            this.groupBox4.Controls.Add(this.bMovementText);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.zMovementText);
            this.groupBox4.Controls.Add(this.aMovementText);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Location = new System.Drawing.Point(674, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 433);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cartesian Movement";
            // 
            // moveRelativeToCoordinateButton
            // 
            this.moveRelativeToCoordinateButton.Location = new System.Drawing.Point(65, 301);
            this.moveRelativeToCoordinateButton.Name = "moveRelativeToCoordinateButton";
            this.moveRelativeToCoordinateButton.Size = new System.Drawing.Size(141, 36);
            this.moveRelativeToCoordinateButton.TabIndex = 14;
            this.moveRelativeToCoordinateButton.Text = "Move relative to coordinate";
            this.moveRelativeToCoordinateButton.UseVisualStyleBackColor = true;
            // 
            // velocityAbsMovementText
            // 
            this.velocityAbsMovementText.Location = new System.Drawing.Point(106, 217);
            this.velocityAbsMovementText.Name = "velocityAbsMovementText";
            this.velocityAbsMovementText.Size = new System.Drawing.Size(100, 20);
            this.velocityAbsMovementText.TabIndex = 13;
            this.velocityAbsMovementText.Text = "0";
            // 
            // moveToCoordinateButton
            // 
            this.moveToCoordinateButton.Location = new System.Drawing.Point(65, 259);
            this.moveToCoordinateButton.Name = "moveToCoordinateButton";
            this.moveToCoordinateButton.Size = new System.Drawing.Size(141, 36);
            this.moveToCoordinateButton.TabIndex = 14;
            this.moveToCoordinateButton.Text = "Move to coordiante";
            this.moveToCoordinateButton.UseVisualStyleBackColor = true;
            // 
            // xMovementText
            // 
            this.xMovementText.Location = new System.Drawing.Point(106, 37);
            this.xMovementText.Name = "xMovementText";
            this.xMovementText.Size = new System.Drawing.Size(100, 20);
            this.xMovementText.TabIndex = 1;
            this.xMovementText.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(44, 220);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 13);
            this.label25.TabIndex = 12;
            this.label25.Text = "Vel. mm/ss";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(86, 40);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "X";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cMovementText
            // 
            this.cMovementText.Location = new System.Drawing.Point(106, 187);
            this.cMovementText.Name = "cMovementText";
            this.cMovementText.Size = new System.Drawing.Size(100, 20);
            this.cMovementText.TabIndex = 13;
            this.cMovementText.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(86, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Y";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(86, 190);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "C";
            // 
            // yMovementText
            // 
            this.yMovementText.Location = new System.Drawing.Point(106, 67);
            this.yMovementText.Name = "yMovementText";
            this.yMovementText.Size = new System.Drawing.Size(100, 20);
            this.yMovementText.TabIndex = 11;
            this.yMovementText.Text = "0";
            // 
            // bMovementText
            // 
            this.bMovementText.Location = new System.Drawing.Point(106, 157);
            this.bMovementText.Name = "bMovementText";
            this.bMovementText.Size = new System.Drawing.Size(100, 20);
            this.bMovementText.TabIndex = 13;
            this.bMovementText.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(86, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "Z";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(86, 160);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "B";
            // 
            // zMovementText
            // 
            this.zMovementText.Location = new System.Drawing.Point(106, 97);
            this.zMovementText.Name = "zMovementText";
            this.zMovementText.Size = new System.Drawing.Size(100, 20);
            this.zMovementText.TabIndex = 11;
            this.zMovementText.Text = "0";
            // 
            // aMovementText
            // 
            this.aMovementText.Location = new System.Drawing.Point(106, 127);
            this.aMovementText.Name = "aMovementText";
            this.aMovementText.Size = new System.Drawing.Size(100, 20);
            this.aMovementText.TabIndex = 13;
            this.aMovementText.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(86, 130);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "A";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.moveRealtiveToJointButton);
            this.groupBox5.Controls.Add(this.moveToJointButton);
            this.groupBox5.Controls.Add(this.velocityRelMovementText);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.joint6MovementText);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.joint5MovementText);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.joint4MovementText);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.joint3MovementText);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.joint2MovementText);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.joint1MovementText);
            this.groupBox5.Controls.Add(this.joint1MovementLabel);
            this.groupBox5.Location = new System.Drawing.Point(343, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(325, 433);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Joint Movement";
            // 
            // moveRealtiveToJointButton
            // 
            this.moveRealtiveToJointButton.Location = new System.Drawing.Point(66, 301);
            this.moveRealtiveToJointButton.Name = "moveRealtiveToJointButton";
            this.moveRealtiveToJointButton.Size = new System.Drawing.Size(141, 36);
            this.moveRealtiveToJointButton.TabIndex = 14;
            this.moveRealtiveToJointButton.Text = "Move relative to joint";
            this.moveRealtiveToJointButton.UseVisualStyleBackColor = true;
            // 
            // moveToJointButton
            // 
            this.moveToJointButton.Location = new System.Drawing.Point(66, 259);
            this.moveToJointButton.Name = "moveToJointButton";
            this.moveToJointButton.Size = new System.Drawing.Size(141, 36);
            this.moveToJointButton.TabIndex = 14;
            this.moveToJointButton.Text = "Move to joint";
            this.moveToJointButton.UseVisualStyleBackColor = true;
            // 
            // velocityRelMovementText
            // 
            this.velocityRelMovementText.Location = new System.Drawing.Point(107, 217);
            this.velocityRelMovementText.Name = "velocityRelMovementText";
            this.velocityRelMovementText.Size = new System.Drawing.Size(100, 20);
            this.velocityRelMovementText.TabIndex = 13;
            this.velocityRelMovementText.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(63, 220);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Vel. %";
            // 
            // joint6MovementText
            // 
            this.joint6MovementText.Location = new System.Drawing.Point(107, 187);
            this.joint6MovementText.Name = "joint6MovementText";
            this.joint6MovementText.Size = new System.Drawing.Size(100, 20);
            this.joint6MovementText.TabIndex = 13;
            this.joint6MovementText.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Joint 6";
            // 
            // joint5MovementText
            // 
            this.joint5MovementText.Location = new System.Drawing.Point(107, 157);
            this.joint5MovementText.Name = "joint5MovementText";
            this.joint5MovementText.Size = new System.Drawing.Size(100, 20);
            this.joint5MovementText.TabIndex = 13;
            this.joint5MovementText.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Joint 5";
            // 
            // joint4MovementText
            // 
            this.joint4MovementText.Location = new System.Drawing.Point(107, 127);
            this.joint4MovementText.Name = "joint4MovementText";
            this.joint4MovementText.Size = new System.Drawing.Size(100, 20);
            this.joint4MovementText.TabIndex = 13;
            this.joint4MovementText.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Joint 4";
            // 
            // joint3MovementText
            // 
            this.joint3MovementText.Location = new System.Drawing.Point(107, 97);
            this.joint3MovementText.Name = "joint3MovementText";
            this.joint3MovementText.Size = new System.Drawing.Size(100, 20);
            this.joint3MovementText.TabIndex = 11;
            this.joint3MovementText.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(63, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Joint 3";
            // 
            // joint2MovementText
            // 
            this.joint2MovementText.Location = new System.Drawing.Point(107, 67);
            this.joint2MovementText.Name = "joint2MovementText";
            this.joint2MovementText.Size = new System.Drawing.Size(100, 20);
            this.joint2MovementText.TabIndex = 11;
            this.joint2MovementText.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(63, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Joint 2";
            // 
            // joint1MovementText
            // 
            this.joint1MovementText.Location = new System.Drawing.Point(107, 37);
            this.joint1MovementText.Name = "joint1MovementText";
            this.joint1MovementText.Size = new System.Drawing.Size(100, 20);
            this.joint1MovementText.TabIndex = 1;
            this.joint1MovementText.Text = "0";
            // 
            // joint1MovementLabel
            // 
            this.joint1MovementLabel.AutoSize = true;
            this.joint1MovementLabel.Location = new System.Drawing.Point(63, 40);
            this.joint1MovementLabel.Name = "joint1MovementLabel";
            this.joint1MovementLabel.Size = new System.Drawing.Size(38, 13);
            this.joint1MovementLabel.TabIndex = 0;
            this.joint1MovementLabel.Text = "Joint 1";
            // 
            // jointMoveGroup
            // 
            this.jointMoveGroup.Controls.Add(this.gripperStatusHCText);
            this.jointMoveGroup.Controls.Add(this.velStatusHCText);
            this.jointMoveGroup.Controls.Add(this.a6StatusHCText);
            this.jointMoveGroup.Controls.Add(this.a5StatusHCText);
            this.jointMoveGroup.Controls.Add(this.a4StatusHCText);
            this.jointMoveGroup.Controls.Add(this.a3StatusHCText);
            this.jointMoveGroup.Controls.Add(this.a2StatusHCText);
            this.jointMoveGroup.Controls.Add(this.a1StatusHCText);
            this.jointMoveGroup.Controls.Add(this.label46);
            this.jointMoveGroup.Controls.Add(this.label11);
            this.jointMoveGroup.Controls.Add(this.closeGripperButton);
            this.jointMoveGroup.Controls.Add(this.velocityDecreaseButton);
            this.jointMoveGroup.Controls.Add(this.a6DecreaseButton);
            this.jointMoveGroup.Controls.Add(this.a5DecreaseButton);
            this.jointMoveGroup.Controls.Add(this.a4DecreaseButton);
            this.jointMoveGroup.Controls.Add(this.a3DecreaseButton);
            this.jointMoveGroup.Controls.Add(this.a2DecreaseButton);
            this.jointMoveGroup.Controls.Add(this.openGripperButton);
            this.jointMoveGroup.Controls.Add(this.a1DecreaseButton);
            this.jointMoveGroup.Controls.Add(this.velocityIncreaseButton);
            this.jointMoveGroup.Controls.Add(this.a6IncreaseButton);
            this.jointMoveGroup.Controls.Add(this.a5IncreaseButton);
            this.jointMoveGroup.Controls.Add(this.a4IncreaseButton);
            this.jointMoveGroup.Controls.Add(this.a3IncreaseButton);
            this.jointMoveGroup.Controls.Add(this.a2IncreaseButton);
            this.jointMoveGroup.Controls.Add(this.a1IncreaseButton);
            this.jointMoveGroup.Location = new System.Drawing.Point(12, 6);
            this.jointMoveGroup.Name = "jointMoveGroup";
            this.jointMoveGroup.Size = new System.Drawing.Size(325, 433);
            this.jointMoveGroup.TabIndex = 0;
            this.jointMoveGroup.TabStop = false;
            this.jointMoveGroup.Text = "Motion";
            // 
            // gripperStatusHCText
            // 
            this.gripperStatusHCText.AutoSize = true;
            this.gripperStatusHCText.Location = new System.Drawing.Point(136, 355);
            this.gripperStatusHCText.Name = "gripperStatusHCText";
            this.gripperStatusHCText.Size = new System.Drawing.Size(24, 13);
            this.gripperStatusHCText.TabIndex = 4;
            this.gripperStatusHCText.Text = "n/a";
            // 
            // velStatusHCText
            // 
            this.velStatusHCText.AutoSize = true;
            this.velStatusHCText.Location = new System.Drawing.Point(136, 313);
            this.velStatusHCText.Name = "velStatusHCText";
            this.velStatusHCText.Size = new System.Drawing.Size(24, 13);
            this.velStatusHCText.TabIndex = 4;
            this.velStatusHCText.Text = "n/a";
            // 
            // a6StatusHCText
            // 
            this.a6StatusHCText.AutoSize = true;
            this.a6StatusHCText.Location = new System.Drawing.Point(136, 250);
            this.a6StatusHCText.Name = "a6StatusHCText";
            this.a6StatusHCText.Size = new System.Drawing.Size(24, 13);
            this.a6StatusHCText.TabIndex = 4;
            this.a6StatusHCText.Text = "n/a";
            // 
            // a5StatusHCText
            // 
            this.a5StatusHCText.AutoSize = true;
            this.a5StatusHCText.Location = new System.Drawing.Point(136, 208);
            this.a5StatusHCText.Name = "a5StatusHCText";
            this.a5StatusHCText.Size = new System.Drawing.Size(24, 13);
            this.a5StatusHCText.TabIndex = 4;
            this.a5StatusHCText.Text = "n/a";
            // 
            // a4StatusHCText
            // 
            this.a4StatusHCText.AutoSize = true;
            this.a4StatusHCText.Location = new System.Drawing.Point(136, 166);
            this.a4StatusHCText.Name = "a4StatusHCText";
            this.a4StatusHCText.Size = new System.Drawing.Size(24, 13);
            this.a4StatusHCText.TabIndex = 4;
            this.a4StatusHCText.Text = "n/a";
            // 
            // a3StatusHCText
            // 
            this.a3StatusHCText.AutoSize = true;
            this.a3StatusHCText.Location = new System.Drawing.Point(136, 124);
            this.a3StatusHCText.Name = "a3StatusHCText";
            this.a3StatusHCText.Size = new System.Drawing.Size(24, 13);
            this.a3StatusHCText.TabIndex = 4;
            this.a3StatusHCText.Text = "n/a";
            // 
            // a2StatusHCText
            // 
            this.a2StatusHCText.AutoSize = true;
            this.a2StatusHCText.Location = new System.Drawing.Point(136, 82);
            this.a2StatusHCText.Name = "a2StatusHCText";
            this.a2StatusHCText.Size = new System.Drawing.Size(24, 13);
            this.a2StatusHCText.TabIndex = 4;
            this.a2StatusHCText.Text = "n/a";
            // 
            // a1StatusHCText
            // 
            this.a1StatusHCText.AutoSize = true;
            this.a1StatusHCText.Location = new System.Drawing.Point(136, 40);
            this.a1StatusHCText.Name = "a1StatusHCText";
            this.a1StatusHCText.Size = new System.Drawing.Size(24, 13);
            this.a1StatusHCText.TabIndex = 4;
            this.a1StatusHCText.Text = "n/a";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(13, 408);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(256, 13);
            this.label46.TabIndex = 2;
            this.label46.Text = "Keep clicking until the robot is in the desired position.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 3;
            // 
            // closeGripperButton
            // 
            this.closeGripperButton.Location = new System.Drawing.Point(30, 343);
            this.closeGripperButton.Name = "closeGripperButton";
            this.closeGripperButton.Size = new System.Drawing.Size(100, 36);
            this.closeGripperButton.TabIndex = 14;
            this.closeGripperButton.Text = "Close gripper";
            this.closeGripperButton.UseVisualStyleBackColor = true;
            this.closeGripperButton.Click += new System.EventHandler(this.closeGripperButton_Click);
            // 
            // velocityDecreaseButton
            // 
            this.velocityDecreaseButton.Location = new System.Drawing.Point(30, 301);
            this.velocityDecreaseButton.Name = "velocityDecreaseButton";
            this.velocityDecreaseButton.Size = new System.Drawing.Size(100, 36);
            this.velocityDecreaseButton.TabIndex = 14;
            this.velocityDecreaseButton.Text = "-Velocity";
            this.velocityDecreaseButton.UseVisualStyleBackColor = true;
            // 
            // a6DecreaseButton
            // 
            this.a6DecreaseButton.Location = new System.Drawing.Point(30, 238);
            this.a6DecreaseButton.Name = "a6DecreaseButton";
            this.a6DecreaseButton.Size = new System.Drawing.Size(100, 36);
            this.a6DecreaseButton.TabIndex = 14;
            this.a6DecreaseButton.Text = "-A6";
            this.a6DecreaseButton.UseVisualStyleBackColor = true;
            // 
            // a5DecreaseButton
            // 
            this.a5DecreaseButton.Location = new System.Drawing.Point(30, 196);
            this.a5DecreaseButton.Name = "a5DecreaseButton";
            this.a5DecreaseButton.Size = new System.Drawing.Size(100, 36);
            this.a5DecreaseButton.TabIndex = 14;
            this.a5DecreaseButton.Text = "-A5";
            this.a5DecreaseButton.UseVisualStyleBackColor = true;
            // 
            // a4DecreaseButton
            // 
            this.a4DecreaseButton.Location = new System.Drawing.Point(30, 154);
            this.a4DecreaseButton.Name = "a4DecreaseButton";
            this.a4DecreaseButton.Size = new System.Drawing.Size(100, 36);
            this.a4DecreaseButton.TabIndex = 14;
            this.a4DecreaseButton.Text = "-A4";
            this.a4DecreaseButton.UseVisualStyleBackColor = true;
            // 
            // a3DecreaseButton
            // 
            this.a3DecreaseButton.Location = new System.Drawing.Point(30, 112);
            this.a3DecreaseButton.Name = "a3DecreaseButton";
            this.a3DecreaseButton.Size = new System.Drawing.Size(100, 36);
            this.a3DecreaseButton.TabIndex = 14;
            this.a3DecreaseButton.Text = "-A3";
            this.a3DecreaseButton.UseVisualStyleBackColor = true;
            // 
            // a2DecreaseButton
            // 
            this.a2DecreaseButton.Location = new System.Drawing.Point(30, 70);
            this.a2DecreaseButton.Name = "a2DecreaseButton";
            this.a2DecreaseButton.Size = new System.Drawing.Size(100, 36);
            this.a2DecreaseButton.TabIndex = 14;
            this.a2DecreaseButton.Text = "-A2";
            this.a2DecreaseButton.UseVisualStyleBackColor = true;
            // 
            // openGripperButton
            // 
            this.openGripperButton.Location = new System.Drawing.Point(186, 343);
            this.openGripperButton.Name = "openGripperButton";
            this.openGripperButton.Size = new System.Drawing.Size(100, 36);
            this.openGripperButton.TabIndex = 14;
            this.openGripperButton.Text = "Open gripper";
            this.openGripperButton.UseVisualStyleBackColor = true;
            this.openGripperButton.Click += new System.EventHandler(this.openGripperButton_Click);
            // 
            // a1DecreaseButton
            // 
            this.a1DecreaseButton.Location = new System.Drawing.Point(30, 28);
            this.a1DecreaseButton.Name = "a1DecreaseButton";
            this.a1DecreaseButton.Size = new System.Drawing.Size(100, 36);
            this.a1DecreaseButton.TabIndex = 14;
            this.a1DecreaseButton.Text = "-A1";
            this.a1DecreaseButton.UseVisualStyleBackColor = true;
            // 
            // velocityIncreaseButton
            // 
            this.velocityIncreaseButton.Location = new System.Drawing.Point(186, 301);
            this.velocityIncreaseButton.Name = "velocityIncreaseButton";
            this.velocityIncreaseButton.Size = new System.Drawing.Size(100, 36);
            this.velocityIncreaseButton.TabIndex = 14;
            this.velocityIncreaseButton.Text = "+Velocity";
            this.velocityIncreaseButton.UseVisualStyleBackColor = true;
            // 
            // a6IncreaseButton
            // 
            this.a6IncreaseButton.Location = new System.Drawing.Point(186, 238);
            this.a6IncreaseButton.Name = "a6IncreaseButton";
            this.a6IncreaseButton.Size = new System.Drawing.Size(100, 36);
            this.a6IncreaseButton.TabIndex = 14;
            this.a6IncreaseButton.Text = "+A6";
            this.a6IncreaseButton.UseVisualStyleBackColor = true;
            // 
            // a5IncreaseButton
            // 
            this.a5IncreaseButton.Location = new System.Drawing.Point(186, 196);
            this.a5IncreaseButton.Name = "a5IncreaseButton";
            this.a5IncreaseButton.Size = new System.Drawing.Size(100, 36);
            this.a5IncreaseButton.TabIndex = 14;
            this.a5IncreaseButton.Text = "+A5";
            this.a5IncreaseButton.UseVisualStyleBackColor = true;
            // 
            // a4IncreaseButton
            // 
            this.a4IncreaseButton.Location = new System.Drawing.Point(186, 154);
            this.a4IncreaseButton.Name = "a4IncreaseButton";
            this.a4IncreaseButton.Size = new System.Drawing.Size(100, 36);
            this.a4IncreaseButton.TabIndex = 14;
            this.a4IncreaseButton.Text = "+A4";
            this.a4IncreaseButton.UseVisualStyleBackColor = true;
            // 
            // a3IncreaseButton
            // 
            this.a3IncreaseButton.Location = new System.Drawing.Point(186, 112);
            this.a3IncreaseButton.Name = "a3IncreaseButton";
            this.a3IncreaseButton.Size = new System.Drawing.Size(100, 36);
            this.a3IncreaseButton.TabIndex = 14;
            this.a3IncreaseButton.Text = "+A3";
            this.a3IncreaseButton.UseVisualStyleBackColor = true;
            // 
            // a2IncreaseButton
            // 
            this.a2IncreaseButton.Location = new System.Drawing.Point(186, 70);
            this.a2IncreaseButton.Name = "a2IncreaseButton";
            this.a2IncreaseButton.Size = new System.Drawing.Size(100, 36);
            this.a2IncreaseButton.TabIndex = 14;
            this.a2IncreaseButton.Text = "+A2";
            this.a2IncreaseButton.UseVisualStyleBackColor = true;
            // 
            // a1IncreaseButton
            // 
            this.a1IncreaseButton.Location = new System.Drawing.Point(186, 28);
            this.a1IncreaseButton.Name = "a1IncreaseButton";
            this.a1IncreaseButton.Size = new System.Drawing.Size(100, 36);
            this.a1IncreaseButton.TabIndex = 14;
            this.a1IncreaseButton.Text = "+A1";
            this.a1IncreaseButton.UseVisualStyleBackColor = true;
            // 
            // statusPage
            // 
            this.statusPage.BackColor = System.Drawing.Color.Transparent;
            this.statusPage.Controls.Add(this.label30);
            this.statusPage.Location = new System.Drawing.Point(4, 22);
            this.statusPage.Name = "statusPage";
            this.statusPage.Padding = new System.Windows.Forms.Padding(3);
            this.statusPage.Size = new System.Drawing.Size(1011, 445);
            this.statusPage.TabIndex = 1;
            this.statusPage.Text = "Status";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(386, 203);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(239, 39);
            this.label30.TabIndex = 2;
            this.label30.Text = "TO BE DONE!";
            // 
            // statusCoursePage
            // 
            this.statusCoursePage.BackColor = System.Drawing.Color.Transparent;
            this.statusCoursePage.Controls.Add(this.label26);
            this.statusCoursePage.Location = new System.Drawing.Point(4, 22);
            this.statusCoursePage.Name = "statusCoursePage";
            this.statusCoursePage.Padding = new System.Windows.Forms.Padding(3);
            this.statusCoursePage.Size = new System.Drawing.Size(1011, 445);
            this.statusCoursePage.TabIndex = 1;
            this.statusCoursePage.Text = "Status Course";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(384, 208);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(239, 39);
            this.label26.TabIndex = 1;
            this.label26.Text = "TO BE DONE!";
            // 
            // openProgramFileDialog
            // 
            this.openProgramFileDialog.FileName = "openFileDialog";
            this.openProgramFileDialog.InitialDirectory = "C:\\CPRog\\Data\\Programs";
            this.openProgramFileDialog.Title = "Select your program.";
            this.openProgramFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openProgramFileDialog_FileOk);
            // 
            // outputDirBrowserDialog
            // 
            this.outputDirBrowserDialog.Description = "Select the output directory for your data";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(310, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "TEST BUTTON";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CRIDataInterfaceGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 669);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CRIDataInterfaceGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRI Data Interface";
            this.logGroupBox.ResumeLayout(false);
            this.logGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.controlPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.standardPositionsGroup.ResumeLayout(false);
            this.standardPositionsGroup.PerformLayout();
            this.connectionStatusGroup.ResumeLayout(false);
            this.connectionStatusGroup.PerformLayout();
            this.connectionControlGroup.ResumeLayout(false);
            this.connectionControlGroup.PerformLayout();
            this.dataPage.ResumeLayout(false);
            this.dataProgressBarGroup.ResumeLayout(false);
            this.dataProgressBarGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.handControlPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.jointMoveGroup.ResumeLayout(false);
            this.jointMoveGroup.PerformLayout();
            this.statusPage.ResumeLayout(false);
            this.statusPage.PerformLayout();
            this.statusCoursePage.ResumeLayout(false);
            this.statusCoursePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer appTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage controlPage;
        private System.Windows.Forms.TabPage dataPage;
        private System.Windows.Forms.TabPage handControlPage;
        private System.Windows.Forms.TabPage statusPage;
        private System.Windows.Forms.TabPage statusCoursePage;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.GroupBox connectionStatusGroup;
        private System.Windows.Forms.GroupBox connectionControlGroup;
        private System.Windows.Forms.ComboBox comboBoxConnections;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Label emergencyStatusLabel;
        private System.Windows.Forms.Label errorStatusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label connectionStatusText;
        private System.Windows.Forms.Label referencedStatusText;
        private System.Windows.Forms.Label errorStatusText;
        private System.Windows.Forms.GroupBox standardPositionsGroup;
        private System.Windows.Forms.Button zeroPositionButton;
        private System.Windows.Forms.Button testRobotButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pauseProgramButton;
        private System.Windows.Forms.Button startProgramButton;
        private System.Windows.Forms.Button testGripperButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label posLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a1label;
        private System.Windows.Forms.Label a3Label;
        private System.Windows.Forms.Label a2Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label a6StatusText;
        private System.Windows.Forms.Label a5StatusText;
        private System.Windows.Forms.Label a4StatusText;
        private System.Windows.Forms.Label a3StatusText;
        private System.Windows.Forms.Label a2StatusText;
        private System.Windows.Forms.Label a1StatusText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cStatusText;
        private System.Windows.Forms.Label bStatusText;
        private System.Windows.Forms.Label aStatusText;
        private System.Windows.Forms.Label zStatusText;
        private System.Windows.Forms.Label yStatusText;
        private System.Windows.Forms.Label xStatusText;
        private System.Windows.Forms.Label a6CurrentLabel;
        private System.Windows.Forms.Label a5CurrentLabel;
        private System.Windows.Forms.Label a4CurrentLabel;
        private System.Windows.Forms.Label zCurrentLabel;
        private System.Windows.Forms.Label yCurrentLabel;
        private System.Windows.Forms.Label xCurrentLabel;
        private System.Windows.Forms.Button storagePositionButton;
        private System.Windows.Forms.Label selectedProgramStatusText;
        private System.Windows.Forms.Label selectedProgramLabel;
        private System.Windows.Forms.Label dataCollectionStatusLabel;
        private System.Windows.Forms.Label programLoadedStatusText;
        private System.Windows.Forms.Label dataCollectionStatusText;
        private System.Windows.Forms.Label programLoadedStatusLabel;
        private System.Windows.Forms.Label velocityRelStatusText;
        private System.Windows.Forms.Label velocityRelLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox jointMoveGroup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button selectProgramButton;
        private System.Windows.Forms.TextBox velocityAbsMovementText;
        private System.Windows.Forms.TextBox xMovementText;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox cMovementText;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox yMovementText;
        private System.Windows.Forms.TextBox bMovementText;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox zMovementText;
        private System.Windows.Forms.TextBox aMovementText;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox velocityRelMovementText;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox joint6MovementText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox joint5MovementText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox joint4MovementText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox joint3MovementText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox joint2MovementText;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox joint1MovementText;
        private System.Windows.Forms.Label joint1MovementLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button moveRelativeToCoordinateButton;
        private System.Windows.Forms.Button moveToCoordinateButton;
        private System.Windows.Forms.Button moveRealtiveToJointButton;
        private System.Windows.Forms.Button moveToJointButton;
        private System.Windows.Forms.Button velocityDecreaseButton;
        private System.Windows.Forms.Button a6DecreaseButton;
        private System.Windows.Forms.Button a5DecreaseButton;
        private System.Windows.Forms.Button a4DecreaseButton;
        private System.Windows.Forms.Button a3DecreaseButton;
        private System.Windows.Forms.Button a2DecreaseButton;
        private System.Windows.Forms.Button a1DecreaseButton;
        private System.Windows.Forms.Button velocityIncreaseButton;
        private System.Windows.Forms.Button a6IncreaseButton;
        private System.Windows.Forms.Button a5IncreaseButton;
        private System.Windows.Forms.Button a4IncreaseButton;
        private System.Windows.Forms.Button a3IncreaseButton;
        private System.Windows.Forms.Button a2IncreaseButton;
        private System.Windows.Forms.Button a1IncreaseButton;
        private System.Windows.Forms.Button closeGripperButton;
        private System.Windows.Forms.Button openGripperButton;
        private System.Windows.Forms.Button startDataCollectionButton;
        private System.Windows.Forms.Button selectOutputDirectory;
        private System.Windows.Forms.TextBox selectedOutputDirTextBox;
        private System.Windows.Forms.TextBox selectedProgramTextBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button stopDataCollectionButton;
        private System.Windows.Forms.Button moveToStartPosButton;
        private System.Windows.Forms.GroupBox dataProgressBarGroup;
        private System.Windows.Forms.ProgressBar progressBarCollection;
        private System.Windows.Forms.Label progressInPercent;
        private System.Windows.Forms.TextBox repetitionsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox datasetNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button selectProgrammButtonDataPage;
        private System.Windows.Forms.CheckBox hideInUnknownMsgCheckBox;
        private System.Windows.Forms.CheckBox hideInFurtherMsgCheckBox;
        private System.Windows.Forms.CheckBox hideInBasicMsgCheckBox;
        private System.Windows.Forms.CheckBox hideOutAliveMsgCheckBox;
        private System.Windows.Forms.Button loadProgramButton;
        private System.Windows.Forms.Button stopProgramButton;
        private System.Windows.Forms.OpenFileDialog openProgramFileDialog;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.FolderBrowserDialog outputDirBrowserDialog;
        private System.Windows.Forms.Label samplingRateLabel;
        private System.Windows.Forms.TextBox samplingRateTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabelCRIDocumentation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox overrideCheckBox;
        private System.Windows.Forms.CheckBox poscartplatformCheckBox;
        private System.Windows.Forms.CheckBox poscartrobotCheckBox;
        private System.Windows.Forms.CheckBox posjointcurrentCheckBox;
        private System.Windows.Forms.CheckBox posjointsetpointCheckBox;
        private System.Windows.Forms.CheckBox kinstateCheckBox;
        private System.Windows.Forms.CheckBox currentjointsCheckBox;
        private System.Windows.Forms.CheckBox currentallCheckBox;
        private System.Windows.Forms.CheckBox supplyCheckBox;
        private System.Windows.Forms.CheckBox estopCheckBox;
        private System.Windows.Forms.CheckBox dindoutCheckBox;
        private System.Windows.Forms.CheckBox opmodeCheckBox;
        private System.Windows.Forms.CheckBox errorCheckBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label fixedProgramNameText;
        private System.Windows.Forms.Label fixedDatasetNameText;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button fixCollectionSettingsButton;
        private System.Windows.Forms.Label fixedSamplingRateText;
        private System.Windows.Forms.Label fixedRepetitionsText;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label collectionReadyText;
        private System.Windows.Forms.Label fixedOutputDirText;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label fixedOutputDirLabel;
        private System.Windows.Forms.Label collectionRunningText;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label currentRepetitionText;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button clearCollectionSettingsButton;
        private System.Windows.Forms.Button unfixCollectionSettingsButton;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label a1StatusHCText;
        private System.Windows.Forms.Label gripperStatusHCText;
        private System.Windows.Forms.Label velStatusHCText;
        private System.Windows.Forms.Label a6StatusHCText;
        private System.Windows.Forms.Label a5StatusHCText;
        private System.Windows.Forms.Label a4StatusHCText;
        private System.Windows.Forms.Label a3StatusHCText;
        private System.Windows.Forms.Label a2StatusHCText;
        private System.Windows.Forms.CheckBox repeatedProgramCheckBox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button stopMovementButton;
        private System.Windows.Forms.Button dropProgramButton;
        private System.Windows.Forms.Button button2;
    }
}
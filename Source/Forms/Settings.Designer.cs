namespace AutomaticReplayViewer
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.SettingsList = new System.Windows.Forms.ListBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSG = new System.Windows.Forms.Panel();
            this.SGSettings = new System.Windows.Forms.Panel();
            this.DisplayAttackData = new System.Windows.Forms.CheckBox();
            this.DisplayInputs = new System.Windows.Forms.CheckBox();
            this.DisplayHitboxes = new System.Windows.Forms.CheckBox();
            this.SGRightKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.SGMPKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.SGLKKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.SGLPKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.DefaultGame = new System.Windows.Forms.ComboBox();
            this.InputStopHotkey = new AutomaticReplayViewer.TapToSetTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputRecordHotkey = new AutomaticReplayViewer.TapToSetTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numReplays = new System.Windows.Forms.TextBox();
            this.panelROA = new System.Windows.Forms.Panel();
            this.ROALKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.ROAStartKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.UpdatePointers = new System.Windows.Forms.Button();
            this.ptrupdatelabel = new System.Windows.Forms.Label();
            this.panelBBTag = new System.Windows.Forms.Panel();
            this.BBTagSettings = new System.Windows.Forms.Panel();
            this.BBTagHideWindow = new System.Windows.Forms.CheckBox();
            this.BBTagHideGauge = new System.Windows.Forms.CheckBox();
            this.BBTagWindowKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BBTagConfirmKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.BBTagGaugeKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.BBTagUpKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panelGGXrd = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GGXrdHideInputs = new System.Windows.Forms.CheckBox();
            this.GGXrdHideHUD = new System.Windows.Forms.CheckBox();
            this.GGXrdHideWindow = new System.Windows.Forms.CheckBox();
            this.GGXrdInputsKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.GGXrdHUDKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.GGXrdWindowKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.GGXrdConfirmKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelBBCF = new System.Windows.Forms.Panel();
            this.BBCFSettings = new System.Windows.Forms.Panel();
            this.BBCFHideWindow = new System.Windows.Forms.CheckBox();
            this.BBCFHideGauge = new System.Windows.Forms.CheckBox();
            this.BBCFWindowKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.BBCFConfirmKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.BBCFGaugeKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.BBCFUpKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panelSG.SuspendLayout();
            this.SGSettings.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.panelROA.SuspendLayout();
            this.panelBBTag.SuspendLayout();
            this.BBTagSettings.SuspendLayout();
            this.panelGGXrd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsList
            // 
            this.SettingsList.Items.AddRange(new object[] {
            "General",
            "Skullgirls",
            "Rivals of Aether",
            "BBTag",
            "GGXrd Rev 2",
            "BBCF"});
            this.SettingsList.Location = new System.Drawing.Point(12, 12);
            this.SettingsList.Name = "SettingsList";
            this.SettingsList.Size = new System.Drawing.Size(85, 212);
            this.SettingsList.TabIndex = 0;
            this.SettingsList.SelectedIndexChanged += new System.EventHandler(this.SettingsList_SelectedIndexChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(314, 234);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(395, 234);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Default Number of Replays";
            // 
            // panelSG
            // 
            this.panelSG.BackColor = System.Drawing.SystemColors.Control;
            this.panelSG.Controls.Add(this.SGSettings);
            this.panelSG.Controls.Add(this.SGRightKeyboardInput);
            this.panelSG.Controls.Add(this.SGMPKeyboardInput);
            this.panelSG.Controls.Add(this.SGLKKeyboardInput);
            this.panelSG.Controls.Add(this.SGLPKeyboardInput);
            this.panelSG.Controls.Add(this.label7);
            this.panelSG.Controls.Add(this.label6);
            this.panelSG.Controls.Add(this.label5);
            this.panelSG.Controls.Add(this.label4);
            this.panelSG.Location = new System.Drawing.Point(103, 12);
            this.panelSG.Name = "panelSG";
            this.panelSG.Size = new System.Drawing.Size(367, 212);
            this.panelSG.TabIndex = 9;
            // 
            // SGSettings
            // 
            this.SGSettings.Controls.Add(this.DisplayAttackData);
            this.SGSettings.Controls.Add(this.DisplayInputs);
            this.SGSettings.Controls.Add(this.DisplayHitboxes);
            this.SGSettings.Location = new System.Drawing.Point(13, 153);
            this.SGSettings.Name = "SGSettings";
            this.SGSettings.Size = new System.Drawing.Size(340, 18);
            this.SGSettings.TabIndex = 11;
            // 
            // DisplayAttackData
            // 
            this.DisplayAttackData.AutoSize = true;
            this.DisplayAttackData.Location = new System.Drawing.Point(217, 1);
            this.DisplayAttackData.Name = "DisplayAttackData";
            this.DisplayAttackData.Size = new System.Drawing.Size(120, 17);
            this.DisplayAttackData.TabIndex = 11;
            this.DisplayAttackData.Text = "Display Attack Data";
            this.DisplayAttackData.UseVisualStyleBackColor = true;
            // 
            // DisplayInputs
            // 
            this.DisplayInputs.AutoSize = true;
            this.DisplayInputs.Location = new System.Drawing.Point(119, 1);
            this.DisplayInputs.Name = "DisplayInputs";
            this.DisplayInputs.Size = new System.Drawing.Size(92, 17);
            this.DisplayInputs.TabIndex = 10;
            this.DisplayInputs.Text = "Display Inputs";
            this.DisplayInputs.UseVisualStyleBackColor = true;
            // 
            // DisplayHitboxes
            // 
            this.DisplayHitboxes.AutoSize = true;
            this.DisplayHitboxes.Location = new System.Drawing.Point(9, 1);
            this.DisplayHitboxes.Name = "DisplayHitboxes";
            this.DisplayHitboxes.Size = new System.Drawing.Size(104, 17);
            this.DisplayHitboxes.TabIndex = 9;
            this.DisplayHitboxes.Text = "Display Hitboxes";
            this.DisplayHitboxes.UseVisualStyleBackColor = true;
            // 
            // SGRightKeyboardInput
            // 
            this.SGRightKeyboardInput.Location = new System.Drawing.Point(174, 105);
            this.SGRightKeyboardInput.Name = "SGRightKeyboardInput";
            this.SGRightKeyboardInput.ReadOnly = true;
            this.SGRightKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.SGRightKeyboardInput.TabIndex = 7;
            // 
            // SGMPKeyboardInput
            // 
            this.SGMPKeyboardInput.Location = new System.Drawing.Point(174, 75);
            this.SGMPKeyboardInput.Name = "SGMPKeyboardInput";
            this.SGMPKeyboardInput.ReadOnly = true;
            this.SGMPKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.SGMPKeyboardInput.TabIndex = 6;
            // 
            // SGLKKeyboardInput
            // 
            this.SGLKKeyboardInput.Location = new System.Drawing.Point(174, 45);
            this.SGLKKeyboardInput.Name = "SGLKKeyboardInput";
            this.SGLKKeyboardInput.ReadOnly = true;
            this.SGLKKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.SGLKKeyboardInput.TabIndex = 5;
            // 
            // SGLPKeyboardInput
            // 
            this.SGLPKeyboardInput.Location = new System.Drawing.Point(174, 15);
            this.SGLPKeyboardInput.Name = "SGLPKeyboardInput";
            this.SGLPKeyboardInput.ReadOnly = true;
            this.SGLPKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.SGLPKeyboardInput.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Right keyboard input";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "MP keyboard input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "LK keyboard input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "LP keyboard input";
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.label8);
            this.panelGeneral.Controls.Add(this.DefaultGame);
            this.panelGeneral.Controls.Add(this.InputStopHotkey);
            this.panelGeneral.Controls.Add(this.label3);
            this.panelGeneral.Controls.Add(this.InputRecordHotkey);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.numReplays);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Location = new System.Drawing.Point(103, 12);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(367, 212);
            this.panelGeneral.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Default Game";
            // 
            // DefaultGame
            // 
            this.DefaultGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefaultGame.Items.AddRange(new object[] {
            "Skullgirls",
            "Rivals of Aether",
            "BBTag",
            "GGXrd Rev 2",
            "BBCF"});
            this.DefaultGame.Location = new System.Drawing.Point(190, 168);
            this.DefaultGame.Name = "DefaultGame";
            this.DefaultGame.Size = new System.Drawing.Size(121, 21);
            this.DefaultGame.TabIndex = 15;
            // 
            // InputStopHotkey
            // 
            this.InputStopHotkey.Location = new System.Drawing.Point(211, 121);
            this.InputStopHotkey.Name = "InputStopHotkey";
            this.InputStopHotkey.ReadOnly = true;
            this.InputStopHotkey.Size = new System.Drawing.Size(100, 20);
            this.InputStopHotkey.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Default Stop Recording Hotkey";
            // 
            // InputRecordHotkey
            // 
            this.InputRecordHotkey.Location = new System.Drawing.Point(211, 71);
            this.InputRecordHotkey.Name = "InputRecordHotkey";
            this.InputRecordHotkey.ReadOnly = true;
            this.InputRecordHotkey.Size = new System.Drawing.Size(100, 20);
            this.InputRecordHotkey.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Default Start Recording Hotkey";
            // 
            // numReplays
            // 
            this.numReplays.Location = new System.Drawing.Point(211, 21);
            this.numReplays.Name = "numReplays";
            this.numReplays.Size = new System.Drawing.Size(100, 20);
            this.numReplays.TabIndex = 10;
            // 
            // panelROA
            // 
            this.panelROA.BackColor = System.Drawing.SystemColors.Control;
            this.panelROA.Controls.Add(this.ROALKeyboardInput);
            this.panelROA.Controls.Add(this.ROAStartKeyboardInput);
            this.panelROA.Controls.Add(this.label13);
            this.panelROA.Controls.Add(this.label14);
            this.panelROA.Location = new System.Drawing.Point(103, 12);
            this.panelROA.Name = "panelROA";
            this.panelROA.Size = new System.Drawing.Size(367, 212);
            this.panelROA.TabIndex = 11;
            // 
            // ROALKeyboardInput
            // 
            this.ROALKeyboardInput.Location = new System.Drawing.Point(174, 45);
            this.ROALKeyboardInput.Name = "ROALKeyboardInput";
            this.ROALKeyboardInput.ReadOnly = true;
            this.ROALKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.ROALKeyboardInput.TabIndex = 11;
            // 
            // ROAStartKeyboardInput
            // 
            this.ROAStartKeyboardInput.Location = new System.Drawing.Point(174, 15);
            this.ROAStartKeyboardInput.Name = "ROAStartKeyboardInput";
            this.ROAStartKeyboardInput.ReadOnly = true;
            this.ROAStartKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.ROAStartKeyboardInput.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "L keyboard input";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Start keyboard input";
            // 
            // UpdatePointers
            // 
            this.UpdatePointers.Location = new System.Drawing.Point(12, 234);
            this.UpdatePointers.Name = "UpdatePointers";
            this.UpdatePointers.Size = new System.Drawing.Size(92, 23);
            this.UpdatePointers.TabIndex = 12;
            this.UpdatePointers.Text = "Update Pointers";
            this.UpdatePointers.UseVisualStyleBackColor = true;
            this.UpdatePointers.Click += new System.EventHandler(this.UpdatePointers_Click);
            // 
            // ptrupdatelabel
            // 
            this.ptrupdatelabel.AutoSize = true;
            this.ptrupdatelabel.Location = new System.Drawing.Point(110, 239);
            this.ptrupdatelabel.Name = "ptrupdatelabel";
            this.ptrupdatelabel.Size = new System.Drawing.Size(121, 13);
            this.ptrupdatelabel.TabIndex = 13;
            this.ptrupdatelabel.Text = "Last updated: 00/00/00";
            // 
            // panelBBTag
            // 
            this.panelBBTag.BackColor = System.Drawing.SystemColors.Control;
            this.panelBBTag.Controls.Add(this.BBTagSettings);
            this.panelBBTag.Controls.Add(this.BBTagWindowKeyboardInput);
            this.panelBBTag.Controls.Add(this.label15);
            this.panelBBTag.Controls.Add(this.BBTagConfirmKeyboardInput);
            this.panelBBTag.Controls.Add(this.BBTagGaugeKeyboardInput);
            this.panelBBTag.Controls.Add(this.BBTagUpKeyboardInput);
            this.panelBBTag.Controls.Add(this.label18);
            this.panelBBTag.Controls.Add(this.label19);
            this.panelBBTag.Controls.Add(this.label20);
            this.panelBBTag.Location = new System.Drawing.Point(103, 12);
            this.panelBBTag.Name = "panelBBTag";
            this.panelBBTag.Size = new System.Drawing.Size(367, 212);
            this.panelBBTag.TabIndex = 14;
            // 
            // BBTagSettings
            // 
            this.BBTagSettings.Controls.Add(this.BBTagHideWindow);
            this.BBTagSettings.Controls.Add(this.BBTagHideGauge);
            this.BBTagSettings.Location = new System.Drawing.Point(13, 142);
            this.BBTagSettings.Name = "BBTagSettings";
            this.BBTagSettings.Size = new System.Drawing.Size(340, 18);
            this.BBTagSettings.TabIndex = 13;
            // 
            // BBTagHideWindow
            // 
            this.BBTagHideWindow.AutoSize = true;
            this.BBTagHideWindow.Location = new System.Drawing.Point(181, 1);
            this.BBTagHideWindow.Name = "BBTagHideWindow";
            this.BBTagHideWindow.Size = new System.Drawing.Size(90, 17);
            this.BBTagHideWindow.TabIndex = 10;
            this.BBTagHideWindow.Text = "Hide Window";
            this.BBTagHideWindow.UseVisualStyleBackColor = true;
            // 
            // BBTagHideGauge
            // 
            this.BBTagHideGauge.AutoSize = true;
            this.BBTagHideGauge.Location = new System.Drawing.Point(71, 1);
            this.BBTagHideGauge.Name = "BBTagHideGauge";
            this.BBTagHideGauge.Size = new System.Drawing.Size(83, 17);
            this.BBTagHideGauge.TabIndex = 9;
            this.BBTagHideGauge.Text = "Hide Gauge";
            this.BBTagHideGauge.UseVisualStyleBackColor = true;
            // 
            // BBTagWindowKeyboardInput
            // 
            this.BBTagWindowKeyboardInput.Location = new System.Drawing.Point(174, 105);
            this.BBTagWindowKeyboardInput.Name = "BBTagWindowKeyboardInput";
            this.BBTagWindowKeyboardInput.ReadOnly = true;
            this.BBTagWindowKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.BBTagWindowKeyboardInput.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Window keyboard input";
            // 
            // BBTagConfirmKeyboardInput
            // 
            this.BBTagConfirmKeyboardInput.Location = new System.Drawing.Point(174, 45);
            this.BBTagConfirmKeyboardInput.Name = "BBTagConfirmKeyboardInput";
            this.BBTagConfirmKeyboardInput.ReadOnly = true;
            this.BBTagConfirmKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.BBTagConfirmKeyboardInput.TabIndex = 5;
            // 
            // BBTagGaugeKeyboardInput
            // 
            this.BBTagGaugeKeyboardInput.Location = new System.Drawing.Point(174, 75);
            this.BBTagGaugeKeyboardInput.Name = "BBTagGaugeKeyboardInput";
            this.BBTagGaugeKeyboardInput.ReadOnly = true;
            this.BBTagGaugeKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.BBTagGaugeKeyboardInput.TabIndex = 6;
            // 
            // BBTagUpKeyboardInput
            // 
            this.BBTagUpKeyboardInput.Location = new System.Drawing.Point(174, 15);
            this.BBTagUpKeyboardInput.Name = "BBTagUpKeyboardInput";
            this.BBTagUpKeyboardInput.ReadOnly = true;
            this.BBTagUpKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.BBTagUpKeyboardInput.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Gauge keyboard input";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Confirm keyboard input";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Up keyboard input";
            // 
            // panelGGXrd
            // 
            this.panelGGXrd.BackColor = System.Drawing.SystemColors.Control;
            this.panelGGXrd.Controls.Add(this.panel2);
            this.panelGGXrd.Controls.Add(this.GGXrdInputsKeyboardInput);
            this.panelGGXrd.Controls.Add(this.GGXrdHUDKeyboardInput);
            this.panelGGXrd.Controls.Add(this.GGXrdWindowKeyboardInput);
            this.panelGGXrd.Controls.Add(this.GGXrdConfirmKeyboardInput);
            this.panelGGXrd.Controls.Add(this.label9);
            this.panelGGXrd.Controls.Add(this.label10);
            this.panelGGXrd.Controls.Add(this.label11);
            this.panelGGXrd.Controls.Add(this.label12);
            this.panelGGXrd.Location = new System.Drawing.Point(103, 12);
            this.panelGGXrd.Name = "panelGGXrd";
            this.panelGGXrd.Size = new System.Drawing.Size(367, 212);
            this.panelGGXrd.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GGXrdHideInputs);
            this.panel2.Controls.Add(this.GGXrdHideHUD);
            this.panel2.Controls.Add(this.GGXrdHideWindow);
            this.panel2.Location = new System.Drawing.Point(13, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 18);
            this.panel2.TabIndex = 11;
            // 
            // GGXrdHideInputs
            // 
            this.GGXrdHideInputs.AutoSize = true;
            this.GGXrdHideInputs.Location = new System.Drawing.Point(217, 1);
            this.GGXrdHideInputs.Name = "GGXrdHideInputs";
            this.GGXrdHideInputs.Size = new System.Drawing.Size(80, 17);
            this.GGXrdHideInputs.TabIndex = 11;
            this.GGXrdHideInputs.Text = "Hide Inputs";
            this.GGXrdHideInputs.UseVisualStyleBackColor = true;
            // 
            // GGXrdHideHUD
            // 
            this.GGXrdHideHUD.AutoSize = true;
            this.GGXrdHideHUD.Location = new System.Drawing.Point(119, 1);
            this.GGXrdHideHUD.Name = "GGXrdHideHUD";
            this.GGXrdHideHUD.Size = new System.Drawing.Size(75, 17);
            this.GGXrdHideHUD.TabIndex = 10;
            this.GGXrdHideHUD.Text = "Hide HUD";
            this.GGXrdHideHUD.UseVisualStyleBackColor = true;
            // 
            // GGXrdHideWindow
            // 
            this.GGXrdHideWindow.AutoSize = true;
            this.GGXrdHideWindow.Checked = true;
            this.GGXrdHideWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GGXrdHideWindow.Location = new System.Drawing.Point(9, 1);
            this.GGXrdHideWindow.Name = "GGXrdHideWindow";
            this.GGXrdHideWindow.Size = new System.Drawing.Size(90, 17);
            this.GGXrdHideWindow.TabIndex = 9;
            this.GGXrdHideWindow.Text = "Hide Window";
            this.GGXrdHideWindow.UseVisualStyleBackColor = true;
            // 
            // GGXrdInputsKeyboardInput
            // 
            this.GGXrdInputsKeyboardInput.Location = new System.Drawing.Point(174, 105);
            this.GGXrdInputsKeyboardInput.Name = "GGXrdInputsKeyboardInput";
            this.GGXrdInputsKeyboardInput.ReadOnly = true;
            this.GGXrdInputsKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.GGXrdInputsKeyboardInput.TabIndex = 7;
            // 
            // GGXrdHUDKeyboardInput
            // 
            this.GGXrdHUDKeyboardInput.Location = new System.Drawing.Point(174, 75);
            this.GGXrdHUDKeyboardInput.Name = "GGXrdHUDKeyboardInput";
            this.GGXrdHUDKeyboardInput.ReadOnly = true;
            this.GGXrdHUDKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.GGXrdHUDKeyboardInput.TabIndex = 6;
            // 
            // GGXrdWindowKeyboardInput
            // 
            this.GGXrdWindowKeyboardInput.Location = new System.Drawing.Point(174, 45);
            this.GGXrdWindowKeyboardInput.Name = "GGXrdWindowKeyboardInput";
            this.GGXrdWindowKeyboardInput.ReadOnly = true;
            this.GGXrdWindowKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.GGXrdWindowKeyboardInput.TabIndex = 5;
            // 
            // GGXrdConfirmKeyboardInput
            // 
            this.GGXrdConfirmKeyboardInput.Location = new System.Drawing.Point(174, 15);
            this.GGXrdConfirmKeyboardInput.Name = "GGXrdConfirmKeyboardInput";
            this.GGXrdConfirmKeyboardInput.ReadOnly = true;
            this.GGXrdConfirmKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.GGXrdConfirmKeyboardInput.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Inputs keyboard input";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "HUD keyboard input";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Window keyboard input";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Confirm keyboard input";
            // 
            // panelBBCF
            // 
            this.panelBBCF.BackColor = System.Drawing.SystemColors.Control;
            this.panelBBCF.Controls.Add(this.BBCFSettings);
            this.panelBBCF.Controls.Add(this.BBCFWindowKeyboardInput);
            this.panelBBCF.Controls.Add(this.label24);
            this.panelBBCF.Controls.Add(this.BBCFConfirmKeyboardInput);
            this.panelBBCF.Controls.Add(this.BBCFGaugeKeyboardInput);
            this.panelBBCF.Controls.Add(this.BBCFUpKeyboardInput);
            this.panelBBCF.Controls.Add(this.label21);
            this.panelBBCF.Controls.Add(this.label22);
            this.panelBBCF.Controls.Add(this.label23);
            this.panelBBCF.Location = new System.Drawing.Point(103, 12);
            this.panelBBCF.Name = "panelBBCF";
            this.panelBBCF.Size = new System.Drawing.Size(367, 212);
            this.panelBBCF.TabIndex = 14;
            // 
            // BBCFSettings
            // 
            this.BBCFSettings.Controls.Add(this.BBCFHideWindow);
            this.BBCFSettings.Controls.Add(this.BBCFHideGauge);
            this.BBCFSettings.Location = new System.Drawing.Point(13, 142);
            this.BBCFSettings.Name = "BBCFSettings";
            this.BBCFSettings.Size = new System.Drawing.Size(340, 18);
            this.BBCFSettings.TabIndex = 13;
            // 
            // BBCFHideWindow
            // 
            this.BBCFHideWindow.AutoSize = true;
            this.BBCFHideWindow.Location = new System.Drawing.Point(181, 1);
            this.BBCFHideWindow.Name = "BBCFHideWindow";
            this.BBCFHideWindow.Size = new System.Drawing.Size(90, 17);
            this.BBCFHideWindow.TabIndex = 10;
            this.BBCFHideWindow.Text = "Hide Window";
            this.BBCFHideWindow.UseVisualStyleBackColor = true;
            // 
            // BBCFHideGauge
            // 
            this.BBCFHideGauge.AutoSize = true;
            this.BBCFHideGauge.Location = new System.Drawing.Point(71, 1);
            this.BBCFHideGauge.Name = "BBCFHideGauge";
            this.BBCFHideGauge.Size = new System.Drawing.Size(83, 17);
            this.BBCFHideGauge.TabIndex = 9;
            this.BBCFHideGauge.Text = "Hide Gauge";
            this.BBCFHideGauge.UseVisualStyleBackColor = true;
            // 
            // BBCFWindowKeyboardInput
            // 
            this.BBCFWindowKeyboardInput.Location = new System.Drawing.Point(174, 105);
            this.BBCFWindowKeyboardInput.Name = "BBCFWindowKeyboardInput";
            this.BBCFWindowKeyboardInput.ReadOnly = true;
            this.BBCFWindowKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.BBCFWindowKeyboardInput.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(34, 108);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Window keyboard input";
            // 
            // BBCFConfirmKeyboardInput
            // 
            this.BBCFConfirmKeyboardInput.Location = new System.Drawing.Point(174, 45);
            this.BBCFConfirmKeyboardInput.Name = "BBCFConfirmKeyboardInput";
            this.BBCFConfirmKeyboardInput.ReadOnly = true;
            this.BBCFConfirmKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.BBCFConfirmKeyboardInput.TabIndex = 5;
            // 
            // BBCFGaugeKeyboardInput
            // 
            this.BBCFGaugeKeyboardInput.Location = new System.Drawing.Point(174, 75);
            this.BBCFGaugeKeyboardInput.Name = "BBCFGaugeKeyboardInput";
            this.BBCFGaugeKeyboardInput.ReadOnly = true;
            this.BBCFGaugeKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.BBCFGaugeKeyboardInput.TabIndex = 6;
            // 
            // BBCFUpKeyboardInput
            // 
            this.BBCFUpKeyboardInput.Location = new System.Drawing.Point(174, 15);
            this.BBCFUpKeyboardInput.Name = "BBCFUpKeyboardInput";
            this.BBCFUpKeyboardInput.ReadOnly = true;
            this.BBCFUpKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.BBCFUpKeyboardInput.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(34, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Gauge keyboard input";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(34, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Confirm keyboard input";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(34, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Up keyboard input";
            // 
            // Settings
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(482, 269);
            this.Controls.Add(this.panelBBCF);
            this.Controls.Add(this.panelGGXrd);
            this.Controls.Add(this.panelBBTag);
            this.Controls.Add(this.ptrupdatelabel);
            this.Controls.Add(this.UpdatePointers);
            this.Controls.Add(this.panelROA);
            this.Controls.Add(this.panelSG);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.SettingsList);
            this.Controls.Add(this.panelGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.panelSG.ResumeLayout(false);
            this.panelSG.PerformLayout();
            this.SGSettings.ResumeLayout(false);
            this.SGSettings.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panelROA.ResumeLayout(false);
            this.panelROA.PerformLayout();
            this.panelBBTag.ResumeLayout(false);
            this.panelBBTag.PerformLayout();
            this.BBTagSettings.ResumeLayout(false);
            this.BBTagSettings.PerformLayout();
            this.panelGGXrd.ResumeLayout(false);
            this.panelGGXrd.PerformLayout();
            this.panelBBCF.ResumeLayout(false);
            this.panelBBCF.PerformLayout();
            this.BBCFSettings.ResumeLayout(false);
            this.BBCFSettings.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SettingsList;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox numReplays;
        private System.Windows.Forms.ComboBox DefaultGame;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelROA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel SGSettings;
        private System.Windows.Forms.CheckBox DisplayAttackData;
        private System.Windows.Forms.CheckBox DisplayInputs;
        private System.Windows.Forms.CheckBox DisplayHitboxes;
        private TapToSetTextBox SGRightKeyboardInput;
        private TapToSetTextBox SGMPKeyboardInput;
        private TapToSetTextBox SGLKKeyboardInput;
        private TapToSetTextBox SGLPKeyboardInput;
        public TapToSetTextBox InputStopHotkey;
        public TapToSetTextBox InputRecordHotkey;
        private TapToSetTextBox ROALKeyboardInput;
        private TapToSetTextBox ROAStartKeyboardInput;
        private System.Windows.Forms.Button UpdatePointers;
        private System.Windows.Forms.Label ptrupdatelabel;
        private System.Windows.Forms.Panel panelBBTag;
        private TapToSetTextBox BBTagConfirmKeyboardInput;
        private TapToSetTextBox BBTagGaugeKeyboardInput;
        private TapToSetTextBox BBTagUpKeyboardInput;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private TapToSetTextBox BBTagWindowKeyboardInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel BBTagSettings;
        private System.Windows.Forms.CheckBox BBTagHideWindow;
        private System.Windows.Forms.CheckBox BBTagHideGauge;
        private System.Windows.Forms.Panel panelGGXrd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox GGXrdHideInputs;
        private System.Windows.Forms.CheckBox GGXrdHideHUD;
        private System.Windows.Forms.CheckBox GGXrdHideWindow;
        private TapToSetTextBox GGXrdInputsKeyboardInput;
        private TapToSetTextBox GGXrdHUDKeyboardInput;
        private TapToSetTextBox GGXrdWindowKeyboardInput;
        private TapToSetTextBox GGXrdConfirmKeyboardInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelBBCF;
        private TapToSetTextBox BBCFConfirmKeyboardInput;
        private TapToSetTextBox BBCFGaugeKeyboardInput;
        private TapToSetTextBox BBCFUpKeyboardInput;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private TapToSetTextBox BBCFWindowKeyboardInput;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel BBCFSettings;
        private System.Windows.Forms.CheckBox BBCFHideWindow;
        private System.Windows.Forms.CheckBox BBCFHideGauge;
    }
}
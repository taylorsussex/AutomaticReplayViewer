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
            this.ROARightKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.ROALeftKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.ROADownKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.ROAUpKeyboardInput = new AutomaticReplayViewer.TapToSetTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelSG.SuspendLayout();
            this.SGSettings.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.panelROA.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsList
            // 
            this.SettingsList.Items.AddRange(new object[] {
            "General",
            "Skullgirls",
            "Rivals of Aether"});
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
            "Rivals of Aether"});
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
            this.panelROA.Controls.Add(this.ROARightKeyboardInput);
            this.panelROA.Controls.Add(this.ROALeftKeyboardInput);
            this.panelROA.Controls.Add(this.ROADownKeyboardInput);
            this.panelROA.Controls.Add(this.ROAUpKeyboardInput);
            this.panelROA.Controls.Add(this.label9);
            this.panelROA.Controls.Add(this.label10);
            this.panelROA.Controls.Add(this.label11);
            this.panelROA.Controls.Add(this.label12);
            this.panelROA.Location = new System.Drawing.Point(103, 12);
            this.panelROA.Name = "panelROA";
            this.panelROA.Size = new System.Drawing.Size(367, 212);
            this.panelROA.TabIndex = 11;
            // 
            // ROALKeyboardInput
            // 
            this.ROALKeyboardInput.Location = new System.Drawing.Point(174, 165);
            this.ROALKeyboardInput.Name = "ROALKeyboardInput";
            this.ROALKeyboardInput.ReadOnly = true;
            this.ROALKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.ROALKeyboardInput.TabIndex = 11;
            // 
            // ROAStartKeyboardInput
            // 
            this.ROAStartKeyboardInput.Location = new System.Drawing.Point(174, 135);
            this.ROAStartKeyboardInput.Name = "ROAStartKeyboardInput";
            this.ROAStartKeyboardInput.ReadOnly = true;
            this.ROAStartKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.ROAStartKeyboardInput.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "L keyboard input";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Start keyboard input";
            // 
            // ROARightKeyboardInput
            // 
            this.ROARightKeyboardInput.Location = new System.Drawing.Point(174, 105);
            this.ROARightKeyboardInput.Name = "ROARightKeyboardInput";
            this.ROARightKeyboardInput.ReadOnly = true;
            this.ROARightKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.ROARightKeyboardInput.TabIndex = 7;
            // 
            // ROALeftKeyboardInput
            // 
            this.ROALeftKeyboardInput.Location = new System.Drawing.Point(174, 75);
            this.ROALeftKeyboardInput.Name = "ROALeftKeyboardInput";
            this.ROALeftKeyboardInput.ReadOnly = true;
            this.ROALeftKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.ROALeftKeyboardInput.TabIndex = 6;
            // 
            // ROADownKeyboardInput
            // 
            this.ROADownKeyboardInput.Location = new System.Drawing.Point(174, 45);
            this.ROADownKeyboardInput.Name = "ROADownKeyboardInput";
            this.ROADownKeyboardInput.ReadOnly = true;
            this.ROADownKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.ROADownKeyboardInput.TabIndex = 5;
            // 
            // ROAUpKeyboardInput
            // 
            this.ROAUpKeyboardInput.Location = new System.Drawing.Point(174, 15);
            this.ROAUpKeyboardInput.Name = "ROAUpKeyboardInput";
            this.ROAUpKeyboardInput.ReadOnly = true;
            this.ROAUpKeyboardInput.Size = new System.Drawing.Size(100, 20);
            this.ROAUpKeyboardInput.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Right keyboard input";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Left keyboard input";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Down keyboard input";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Up keyboard input";
            // 
            // Settings
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(482, 269);
            this.Controls.Add(this.panelROA);
            this.Controls.Add(this.panelSG);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.SettingsList);
            this.Controls.Add(this.panelGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
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
        private TapToSetTextBox ROARightKeyboardInput;
        private TapToSetTextBox ROALeftKeyboardInput;
        private TapToSetTextBox ROADownKeyboardInput;
        private TapToSetTextBox ROAUpKeyboardInput;
    }
}
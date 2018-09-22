using System.Windows.Forms;

namespace AutomaticReplayViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.numReplays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewerText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.selectGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skullgirlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rivalsOfAetherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bBTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SGSettings = new System.Windows.Forms.Panel();
            this.DisplayAttackData = new System.Windows.Forms.CheckBox();
            this.DisplayInputs = new System.Windows.Forms.CheckBox();
            this.DisplayHitboxes = new System.Windows.Forms.CheckBox();
            this.BBTagSettings = new System.Windows.Forms.Panel();
            this.BBTagHideWindow = new System.Windows.Forms.CheckBox();
            this.BBTagHideGauge = new System.Windows.Forms.CheckBox();
            this.InputStopHotkey = new AutomaticReplayViewer.TapToSetTextBox();
            this.InputRecordHotkey = new AutomaticReplayViewer.TapToSetTextBox();
            this.menuStrip.SuspendLayout();
            this.SGSettings.SuspendLayout();
            this.BBTagSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 33);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(169, 41);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(12, 80);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(169, 41);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // numReplays
            // 
            this.numReplays.Location = new System.Drawing.Point(187, 54);
            this.numReplays.Name = "numReplays";
            this.numReplays.Size = new System.Drawing.Size(100, 20);
            this.numReplays.TabIndex = 2;
            this.numReplays.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of replays";
            // 
            // viewerText
            // 
            this.viewerText.AutoSize = true;
            this.viewerText.Location = new System.Drawing.Point(187, 94);
            this.viewerText.Name = "viewerText";
            this.viewerText.Size = new System.Drawing.Size(53, 13);
            this.viewerText.TabIndex = 4;
            this.viewerText.Text = "Unstarted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start recording hotkey";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stop recording hotkey";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectGameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(340, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip";
            // 
            // selectGameToolStripMenuItem
            // 
            this.selectGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skullgirlsToolStripMenuItem,
            this.rivalsOfAetherToolStripMenuItem,
            this.bBTagToolStripMenuItem,
            this.moreOptionsToolStripMenuItem});
            this.selectGameToolStripMenuItem.Name = "selectGameToolStripMenuItem";
            this.selectGameToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.selectGameToolStripMenuItem.Text = "Select Game";
            // 
            // skullgirlsToolStripMenuItem
            // 
            this.skullgirlsToolStripMenuItem.CheckOnClick = true;
            this.skullgirlsToolStripMenuItem.Name = "skullgirlsToolStripMenuItem";
            this.skullgirlsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.skullgirlsToolStripMenuItem.Text = "Skullgirls";
            this.skullgirlsToolStripMenuItem.Click += new System.EventHandler(this.skullgirlsToolStripMenuItem_Click);
            // 
            // rivalsOfAetherToolStripMenuItem
            // 
            this.rivalsOfAetherToolStripMenuItem.CheckOnClick = true;
            this.rivalsOfAetherToolStripMenuItem.Name = "rivalsOfAetherToolStripMenuItem";
            this.rivalsOfAetherToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.rivalsOfAetherToolStripMenuItem.Text = "Rivals of Aether";
            this.rivalsOfAetherToolStripMenuItem.Click += new System.EventHandler(this.rivalsOfAetherToolStripMenuItem_Click);
            // 
            // bBTagToolStripMenuItem
            // 
            this.bBTagToolStripMenuItem.Name = "bBTagToolStripMenuItem";
            this.bBTagToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.bBTagToolStripMenuItem.Text = "BBTag";
            this.bBTagToolStripMenuItem.Click += new System.EventHandler(this.BBTagToolStripMenuItem_Click);
            // 
            // moreOptionsToolStripMenuItem
            // 
            this.moreOptionsToolStripMenuItem.Name = "moreOptionsToolStripMenuItem";
            this.moreOptionsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.moreOptionsToolStripMenuItem.Text = "More Options...";
            this.moreOptionsToolStripMenuItem.Click += new System.EventHandler(this.moreOptionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readmeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readmeToolStripMenuItem
            // 
            this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
            this.readmeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.readmeToolStripMenuItem.Text = "Readme";
            this.readmeToolStripMenuItem.Click += new System.EventHandler(this.readmeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SGSettings
            // 
            this.SGSettings.Controls.Add(this.DisplayAttackData);
            this.SGSettings.Controls.Add(this.DisplayInputs);
            this.SGSettings.Controls.Add(this.DisplayHitboxes);
            this.SGSettings.Location = new System.Drawing.Point(0, 202);
            this.SGSettings.Name = "SGSettings";
            this.SGSettings.Size = new System.Drawing.Size(340, 18);
            this.SGSettings.TabIndex = 10;
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
            // BBTagSettings
            // 
            this.BBTagSettings.Controls.Add(this.BBTagHideWindow);
            this.BBTagSettings.Controls.Add(this.BBTagHideGauge);
            this.BBTagSettings.Location = new System.Drawing.Point(0, 202);
            this.BBTagSettings.Name = "BBTagSettings";
            this.BBTagSettings.Size = new System.Drawing.Size(340, 18);
            this.BBTagSettings.TabIndex = 12;
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
            // InputStopHotkey
            // 
            this.InputStopHotkey.Location = new System.Drawing.Point(140, 171);
            this.InputStopHotkey.Name = "InputStopHotkey";
            this.InputStopHotkey.ReadOnly = true;
            this.InputStopHotkey.Size = new System.Drawing.Size(100, 20);
            this.InputStopHotkey.TabIndex = 4;
            // 
            // InputRecordHotkey
            // 
            this.InputRecordHotkey.Location = new System.Drawing.Point(12, 171);
            this.InputRecordHotkey.Name = "InputRecordHotkey";
            this.InputRecordHotkey.ReadOnly = true;
            this.InputRecordHotkey.Size = new System.Drawing.Size(100, 20);
            this.InputRecordHotkey.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 232);
            this.Controls.Add(this.BBTagSettings);
            this.Controls.Add(this.SGSettings);
            this.Controls.Add(this.InputStopHotkey);
            this.Controls.Add(this.InputRecordHotkey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewerText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numReplays);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AutomaticReplayViewer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.SGSettings.ResumeLayout(false);
            this.SGSettings.PerformLayout();
            this.BBTagSettings.ResumeLayout(false);
            this.BBTagSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button StartButton;
        public System.Windows.Forms.Button StopButton;
        public System.Windows.Forms.TextBox numReplays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label viewerText;

        private string _labelText;
        public string labelText
        {
            get { return _labelText; }
            set
            {
                _labelText = value;
                updateViewerText(_labelText);
            }
        }

        delegate void updateViewerTextDelegate(string newText);
        private void updateViewerText(string newText)
        {
            if (viewerText.InvokeRequired)
            {
                // this is worker thread
                updateViewerTextDelegate del = new updateViewerTextDelegate(updateViewerText);
                viewerText.Invoke(del, new object[] { newText });
            }
            else
            {
                // this is UI thread
                viewerText.Text = newText;
            }
        }
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Keys RecordHotkey;
        public Keys StopHotkey;
        private MenuStrip menuStrip;
        private ToolStripMenuItem selectGameToolStripMenuItem;
        private ToolStripMenuItem skullgirlsToolStripMenuItem;
        private ToolStripMenuItem rivalsOfAetherToolStripMenuItem;
        private ToolStripMenuItem moreOptionsToolStripMenuItem;
        private Panel SGSettings;
        private CheckBox DisplayAttackData;
        private CheckBox DisplayInputs;
        private CheckBox DisplayHitboxes;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem readmeToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem bBTagToolStripMenuItem;
        public TapToSetTextBox InputRecordHotkey;
        public TapToSetTextBox InputStopHotkey;
        private Panel BBTagSettings;
        private CheckBox BBTagHideWindow;
        private CheckBox BBTagHideGauge;
    }
}


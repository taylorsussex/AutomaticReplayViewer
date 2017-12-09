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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.numReplays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewerText = new System.Windows.Forms.Label();
            this.InputRecordHotkey = new System.Windows.Forms.TextBox();
            this.InputStopHotkey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayHitboxes = new System.Windows.Forms.CheckBox();
            this.DisplayInputs = new System.Windows.Forms.CheckBox();
            this.DisplayAttackData = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 12);
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
            this.StopButton.Location = new System.Drawing.Point(12, 59);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(169, 41);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // numReplays
            // 
            this.numReplays.Location = new System.Drawing.Point(187, 33);
            this.numReplays.Name = "numReplays";
            this.numReplays.Size = new System.Drawing.Size(100, 20);
            this.numReplays.TabIndex = 2;
            this.numReplays.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of replays";
            // 
            // viewerText
            // 
            this.viewerText.AutoSize = true;
            this.viewerText.Location = new System.Drawing.Point(187, 73);
            this.viewerText.Name = "viewerText";
            this.viewerText.Size = new System.Drawing.Size(53, 13);
            this.viewerText.TabIndex = 4;
            this.viewerText.Text = "Unstarted";
            // 
            // InputRecordHotkey
            // 
            this.InputRecordHotkey.Location = new System.Drawing.Point(12, 150);
            this.InputRecordHotkey.Name = "InputRecordHotkey";
            this.InputRecordHotkey.Size = new System.Drawing.Size(100, 20);
            this.InputRecordHotkey.TabIndex = 5;
            // 
            // InputStopHotkey
            // 
            this.InputStopHotkey.Location = new System.Drawing.Point(140, 150);
            this.InputStopHotkey.Name = "InputStopHotkey";
            this.InputStopHotkey.Size = new System.Drawing.Size(100, 20);
            this.InputStopHotkey.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start recording hotkey";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stop recording hotkey";
            // 
            // DisplayHitboxes
            // 
            this.DisplayHitboxes.AutoSize = true;
            this.DisplayHitboxes.Location = new System.Drawing.Point(11, 188);
            this.DisplayHitboxes.Name = "DisplayHitboxes";
            this.DisplayHitboxes.Size = new System.Drawing.Size(104, 17);
            this.DisplayHitboxes.TabIndex = 6;
            this.DisplayHitboxes.Text = "Display Hitboxes";
            this.DisplayHitboxes.UseVisualStyleBackColor = true;
            // 
            // DisplayInputs
            // 
            this.DisplayInputs.AutoSize = true;
            this.DisplayInputs.Location = new System.Drawing.Point(121, 188);
            this.DisplayInputs.Name = "DisplayInputs";
            this.DisplayInputs.Size = new System.Drawing.Size(92, 17);
            this.DisplayInputs.TabIndex = 7;
            this.DisplayInputs.Text = "Display Inputs";
            this.DisplayInputs.UseVisualStyleBackColor = true;
            // 
            // DisplayAttackData
            // 
            this.DisplayAttackData.AutoSize = true;
            this.DisplayAttackData.Location = new System.Drawing.Point(219, 188);
            this.DisplayAttackData.Name = "DisplayAttackData";
            this.DisplayAttackData.Size = new System.Drawing.Size(120, 17);
            this.DisplayAttackData.TabIndex = 8;
            this.DisplayAttackData.Text = "Display Attack Data";
            this.DisplayAttackData.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 213);
            this.Controls.Add(this.DisplayAttackData);
            this.Controls.Add(this.DisplayInputs);
            this.Controls.Add(this.DisplayHitboxes);
            this.Controls.Add(this.InputStopHotkey);
            this.Controls.Add(this.InputRecordHotkey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewerText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numReplays);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "AutomaticReplayViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
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

        public System.Windows.Forms.TextBox InputRecordHotkey;
        public System.Windows.Forms.TextBox InputStopHotkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Keys RecordHotkey;
        public Keys StopHotkey;
        private CheckBox DisplayHitboxes;
        private CheckBox DisplayInputs;
        private CheckBox DisplayAttackData;
    }
}


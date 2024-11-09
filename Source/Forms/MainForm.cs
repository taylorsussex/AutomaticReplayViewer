using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AutomaticReplayViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Check if config file exists and make a default one if not
            if (!File.Exists("AutomaticReplayViewer.exe.config"))
            {
                GenerateConfigFile();
                ConfigurationManager.RefreshSection("appSettings");
            }

            // Initialise keys
            SetKeys();

            // Initialise ReplayViewer objects
            viewSG = new SGReplayViewer();
            viewROA = new ROAReplayViewer();
            viewBBTag = new BBCFReplayViewer();
            viewGGXrd = new GGXrdReplayViewer();
            viewBBCF = new BBCFReplayViewer();

            // Initialise event handlers
            viewSG.PropertyChanged += ProgressText_PropertyChanged;
            viewSG.LoopEnded += ResetUI;
            viewROA.PropertyChanged += ProgressText_PropertyChanged;
            viewROA.LoopEnded += ResetUI;
            viewBBTag.PropertyChanged += ProgressText_PropertyChanged;
            viewBBTag.LoopEnded += ResetUI;
            viewGGXrd.PropertyChanged += ProgressText_PropertyChanged;
            viewGGXrd.LoopEnded += ResetUI;
            viewBBCF.PropertyChanged += ProgressText_PropertyChanged;
            viewBBCF.LoopEnded += ResetUI;

            // Set initial values of forms from config file
            numReplays.Text = ConfigurationManager.AppSettings["DefaultNumberOfReplays"];
            InputRecordHotkey.Text = ConfigurationManager.AppSettings["DefaultRecordHotkey"];
            InputStopHotkey.Text = ConfigurationManager.AppSettings["DefaultStopHotkey"];
            DisplayHitboxes.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["DefaultDisplayHitboxes"]);
            DisplayInputs.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["DefaultDisplayInputs"]);
            DisplayAttackData.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["DefaultDisplayAttackData"]);
            BBTagHideGauge.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["BBTag Hide Gauge"]);
            BBTagHideWindow.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["BBTag Hide Window"]);
            GGXrdHideWindow.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["GGXrd Hide Window"]);
            GGXrdHideHUD.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["GGXrd Hide HUD"]);
            GGXrdHideInputs.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["GGXrd Hide Inputs"]);
            BBCFHideGauge.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["BBCF Hide Gauge"]);
            BBCFHideWindow.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["BBCF Hide Window"]);
            switch (ConfigurationManager.AppSettings["DefaultGame"])
            {
                default:
                    skullgirlsToolStripMenuItem_Click(skullgirlsToolStripMenuItem, new EventArgs());
                    break;
                case "Rivals of Aether":
                    rivalsOfAetherToolStripMenuItem_Click(rivalsOfAetherToolStripMenuItem, new EventArgs());
                    break;
                case "BBTag":
                    BBTagToolStripMenuItem_Click(bBTagToolStripMenuItem, new EventArgs());
                    break;
                case "GGXrd Rev 2":
                    gGXrdRev2ToolStripMenuItem_Click(gGXrdRev2ToolStripMenuItem, new EventArgs());
                    break;
                case "BBCF":
                    BBCFToolStripMenuItem_Click(BBCFToolStripMenuItem, new EventArgs());
                    break;
            }

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TapToSetTextBox)
                {
                    boxes.Add(ctrl);
                }
                else if (ctrl is Panel)
                {
                    foreach (Control _ctrl in ctrl.Controls)
                    {
                        if (_ctrl is TapToSetTextBox)
                        {
                            boxes.Add(_ctrl);
                        }
                    }
                }
            }

            foreach (TapToSetTextBox box in boxes)
            {
                box.WaitingForKey += Box_WaitingForKey;
            }
        }

        private void Box_WaitingForKey(object sender, EventArgs e)
        {
            SuppressKeys = true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Parse and store the number of replays to be played
            string inputText = numReplays.Text;
            int ReplaysToPlay = 1;

            if (!string.IsNullOrEmpty(inputText))
            {
                int.TryParse(inputText, out ReplaysToPlay);
                if (ReplaysToPlay < 1)
                    ReplaysToPlay = 1;
            }

            // Parse and store the hotkeys for recording/stopping
            RecordHotkey = ParseKeys(InputRecordHotkey.Text);
            StopHotkey = ParseKeys(InputStopHotkey.Text);

            // Toggle the button states
            StartButton.Enabled = false;
            StopButton.Enabled = true;
            numReplays.Text = ReplaysToPlay.ToString();
            numReplays.Enabled = false;
            InputRecordHotkey.Enabled = false;
            InputStopHotkey.Enabled = false;
            menuStrip.Enabled = false;
            SGSettings.Enabled = false;
            BBTagSettings.Enabled = false;
            GGXrdSettings.Enabled = false;

            // Start main loop
            switch (currentGame)
            {
                default:
                    viewSG.StartLoop(ReplaysToPlay, SGLP, SGLK, SGMP, SGRight, RecordHotkey, StopHotkey, DisplayHitboxes.Checked, DisplayInputs.Checked, DisplayAttackData.Checked);
                    break;
                case "Rivals of Aether":
                    viewROA.StartLoop(ReplaysToPlay, ROAStart, ROAL, RecordHotkey, StopHotkey);
                    break;
                case "BBTag":
                    viewBBTag.StartLoop(ReplaysToPlay, BBTagUp, BBTagConfirm, BBTagGauge, BBTagWindow, RecordHotkey, StopHotkey, BBTagHideGauge.Checked, BBTagHideWindow.Checked);
                    break;
                case "Guilty Gear Xrd Rev 2":
                    viewGGXrd.StartLoop(ReplaysToPlay, GGXrdConfirm, GGXrdHUD, GGXrdWindow, GGXrdInputs, RecordHotkey, StopHotkey, GGXrdHideHUD.Checked, GGXrdHideWindow.Checked, GGXrdHideInputs.Checked);
                    break;
                case "BlazBlue Centralfiction":
                    viewBBCF.StartLoop(ReplaysToPlay, BBTagUp, BBTagConfirm, BBTagGauge, BBTagWindow, RecordHotkey, StopHotkey, BBCFHideGauge.Checked, BBCFHideWindow.Checked);
                    break;
            }

            StopButton.Focus();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            viewSG.ProcessRunning = false;
            viewROA.ProcessRunning = false;
            viewBBTag.ProcessRunning = false;
            viewGGXrd.ProcessRunning = false;
            viewBBCF.ProcessRunning = false;
        }

        private void ResetUI(object sender, EventArgs e)
         {
            this.BeginInvoke((Action)delegate () { this.Enabled = true; this.Focus(); });
            StartButton.BeginInvoke((Action)delegate () { StartButton.Enabled = true; StartButton.Focus(); });
            StopButton.BeginInvoke((Action)delegate () { StopButton.Enabled = false; });
            numReplays.BeginInvoke((Action)delegate () { numReplays.Enabled = true; });
            InputRecordHotkey.BeginInvoke((Action)delegate () { InputRecordHotkey.Enabled = true; });
            InputStopHotkey.BeginInvoke((Action)delegate () { InputStopHotkey.Enabled = true; });
            menuStrip.BeginInvoke((Action)delegate () { menuStrip.Enabled = true; });
            SGSettings.BeginInvoke((Action)delegate () { SGSettings.Enabled = true; });
            BBTagSettings.BeginInvoke((Action)delegate () { BBTagSettings.Enabled = true; });
            GGXrdSettings.BeginInvoke((Action)delegate () { GGXrdSettings.Enabled = true; });
        }

        private void ProgressText_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (currentGame)
            {
                default:
                    labelText = viewSG.ProgressText;
                    break;
                case "Rivals of Aether":
                    labelText = viewROA.ProgressText;
                    break;
                case "BBTag":
                    labelText = viewBBTag.ProgressText;
                    break;
                case "Guilty Gear Xrd Rev 2":
                    labelText = viewGGXrd.ProgressText;
                    break;
                case "BlazBlue Centralfiction":
                    labelText = viewBBCF.ProgressText;
                    break;
            }
        }

        public static Keys ParseKeys(string input)
        {
            Keys output = Keys.None;

            if (!string.IsNullOrEmpty(input))
                Enum.TryParse(input, out output);

            return output;
        }

        private static void GenerateConfigFile()
        {
            // Update for new config file w BBTag stuff
            System.Text.StringBuilder sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sb.AppendLine("<configuration>");
            sb.AppendLine("  <appSettings>");
            sb.AppendLine("    <!--Relevant Key Bindings in SG-->");
            sb.AppendLine("    <!--It is essential that the keys here match the bindings that you have in SG-->");
            sb.AppendLine("    <!--All key settings must be as they are for System.Windows.Forms.Keys-->");
            sb.AppendLine("    <!--This list can be checked here msdn.microsoft.com/en-us/library/system.windows.forms.keys.aspx-->");
            sb.AppendLine("    <add key=\"SG LP keyboard input\" value=\"A\" />");
            sb.AppendLine("    <add key=\"SG LK keyboard input\" value=\"Z\" />");
            sb.AppendLine("    <add key=\"SG MP keyboard input\" value=\"S\" />");
            sb.AppendLine("    <add key=\"SG Right keyboard input\" value=\"Right\" />");
            sb.AppendLine("    <add key=\"DefaultDisplayHitboxes\" value=\"False\" />");
            sb.AppendLine("    <add key=\"DefaultDisplayInputs\" value=\"False\" />");
            sb.AppendLine("    <add key=\"DefaultDisplayAttackData\" value=\"False\" />");
            sb.AppendLine("    <!--SG Pointers-->");
            sb.AppendLine("    <add key=\"SGMenuState\" value=\"4416540\" />");
            sb.AppendLine("    <!--Relevant Key Bindings in ROA-->");
            sb.AppendLine("    <add key=\"ROA Start keyboard input\" value=\"Return\" />");
            sb.AppendLine("    <add key=\"ROA L keyboard input\" value=\"A\" />");
            sb.AppendLine("    <!--ROA Pointers-->");
            sb.AppendLine("    <add key=\"ROAMenuState\" value=\"0x59A8A40\" />");
            sb.AppendLine("    <add key=\"ROACursorX\" value=\"0x059A8A18,0x80,0xA0\" />");
            sb.AppendLine("    <add key=\"ROACursorY\" value=\"0x059A8A18,0x80,0xA4\" />");
            sb.AppendLine("    <!--Relevant Key Bindings in BBTag-->");
            sb.AppendLine("    <add key=\"BBTag Up keyboard input\" value=\"W\" />");
            sb.AppendLine("    <add key=\"BBTag Confirm keyboard input\" value=\"J\" />");
            sb.AppendLine("    <add key=\"BBTag Gauge keyboard input\" value=\"U\" />");
            sb.AppendLine("    <add key=\"BBTag Window keyboard input\" value=\"I\" />");
            sb.AppendLine("    <add key=\"BBTag Hide Gauge\" value=\"False\" />");
            sb.AppendLine("    <add key=\"BBTag Hide Window\" value=\"True\" />");
            sb.AppendLine("    <!--BBTag Pointers-->");
            sb.AppendLine("    <add key=\"BBTagReplayTheaterActive\" value=\"0x172FEC8\" />");
            sb.AppendLine("    <add key=\"BBTagReplayPlaying\" value=\"0x5FE488\" />");
            sb.AppendLine("    <add key=\"BBTagCursor\" value=\"0x10CBD58\" />");
            sb.AppendLine("    <!--Relevant Key Bindings in GGXrd-->");
            sb.AppendLine("    <add key=\"GGXrd Confirm keyboard input\" value=\"U\" />");
            sb.AppendLine("    <add key=\"GGXrd Window keyboard input\" value=\"I\" />");
            sb.AppendLine("    <add key=\"GGXrd HUD keyboard input\" value=\"J\" />");
            sb.AppendLine("    <add key=\"GGXrd Inputs keyboard input\" value=\"L\" />");
            sb.AppendLine("    <add key=\"GGXrd Hide Window\" value=\"True\" />");
            sb.AppendLine("    <add key=\"GGXrd Hide HUD\" value=\"False\" />");
            sb.AppendLine("    <add key=\"GGXrd Hide Inputs\" value=\"False\" />");
            sb.AppendLine("    <!--GGXrd Pointers-->");
            sb.AppendLine("    <add key=\"GGXrdMenuState\" value=\"0x0173A674,0x94,0x4\" />");
            sb.AppendLine("    <add key=\"GGXrdOutroPlaying\" value=\"0x1937DEC\" />");
            sb.AppendLine("    <add key=\"GGXrdCursor\" value=\"0x0173A670,0x14,0x4,0x60,0x1BC\" />");
            sb.AppendLine("    <!--Relevant Key Bindings in BBCF-->");
            sb.AppendLine("    <add key=\"BBCF Up keyboard input\" value=\"W\" />");
            sb.AppendLine("    <add key=\"BBCF Confirm keyboard input\" value=\"J\" />");
            sb.AppendLine("    <add key=\"BBCF Gauge keyboard input\" value=\"U\" />");
            sb.AppendLine("    <add key=\"BBCF Window keyboard input\" value=\"I\" />");
            sb.AppendLine("    <add key=\"BBCF Hide Gauge\" value=\"False\" />");
            sb.AppendLine("    <add key=\"BBCF Hide Window\" value=\"True\" />");
            sb.AppendLine("    <!--BBCF Pointers-->");
            sb.AppendLine("    <add key=\"BBCFMenuState\" value=\"0x6235FC\" />");
            sb.AppendLine("    <add key=\"BBCFReplayPlaying\" value=\"0x65C210\" />");
            sb.AppendLine("    <add key=\"BBCFCursor\" value=\"0xE9329C\" />");
            sb.AppendLine("    <!--Default Settings on Load-->");
            sb.AppendLine("    <add key=\"DefaultNumberOfReplays\" value=\"1\" />");
            sb.AppendLine("    <add key=\"DefaultRecordHotkey\" value=\"\" />");
            sb.AppendLine("    <add key=\"DefaultStopHotkey\" value=\"\" />");
            sb.AppendLine("    <add key=\"DefaultGame\" value=\"Skullgirls\" />");
            sb.AppendLine("    <add key=\"LastTimePointersUpdated\" value=\"19/09/22\" />");
            sb.AppendLine("  </appSettings>");
            sb.AppendLine("</configuration>");

            string loc = Assembly.GetEntryAssembly().Location;
            System.IO.File.WriteAllText(String.Concat(loc, ".config"), sb.ToString());
        }

        private void SettingsClosed(object sender, EventArgs e)
        {
            SetKeys();
            ResetUI(sender, e);
        }

        private void SetKeys()
        {
            // Initialise keys
            SGLP = ParseKeys(ConfigurationManager.AppSettings["SG LP keyboard input"]);
            SGLK = ParseKeys(ConfigurationManager.AppSettings["SG LK keyboard input"]);
            SGMP = ParseKeys(ConfigurationManager.AppSettings["SG MP keyboard input"]);
            SGRight = ParseKeys(ConfigurationManager.AppSettings["SG Right keyboard input"]);
            ROAStart = ParseKeys(ConfigurationManager.AppSettings["ROA Start keyboard input"]);
            ROAL = ParseKeys(ConfigurationManager.AppSettings["ROA L keyboard input"]);
            BBTagUp = ParseKeys(ConfigurationManager.AppSettings["BBTag Up keyboard input"]);
            BBTagConfirm = ParseKeys(ConfigurationManager.AppSettings["BBTag Confirm keyboard input"]);
            BBTagGauge = ParseKeys(ConfigurationManager.AppSettings["BBTag Gauge keyboard input"]);
            BBTagWindow = ParseKeys(ConfigurationManager.AppSettings["BBTag Window keyboard input"]);
            GGXrdConfirm = ParseKeys(ConfigurationManager.AppSettings["GGXrd Confirm keyboard input"]);
            GGXrdWindow = ParseKeys(ConfigurationManager.AppSettings["GGXrd Window keyboard input"]);
            GGXrdHUD = ParseKeys(ConfigurationManager.AppSettings["GGXrd HUD keyboard input"]);
            GGXrdInputs = ParseKeys(ConfigurationManager.AppSettings["GGXrd Inputs keyboard input"]);
        }

        private SGReplayViewer viewSG;
        private ROAReplayViewer viewROA;
        private BBCFReplayViewer viewBBTag;
        private GGXrdReplayViewer viewGGXrd;
        private BBCFReplayViewer viewBBCF;
        private Keys SGLP = Keys.A;
        private Keys SGLK = Keys.Z;
        private Keys SGMP = Keys.S;
        private Keys SGRight = Keys.Right;
        private Keys ROAStart = Keys.Return;
        private Keys ROAL = Keys.A;
        private Keys BBTagUp = Keys.W;
        private Keys BBTagConfirm = Keys.J;
        private Keys BBTagGauge = Keys.U;
        private Keys BBTagWindow = Keys.I;
        private Keys GGXrdConfirm = Keys.U;
        private Keys GGXrdWindow = Keys.I;
        private Keys GGXrdHUD = Keys.J;
        private Keys GGXrdInputs = Keys.L;
        private string currentGame = "Skullgirls";

        private void skullgirlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentGame = viewSG.game;
            skullgirlsToolStripMenuItem.Checked = true;
            rivalsOfAetherToolStripMenuItem.Checked = false;
            bBTagToolStripMenuItem.Checked = false;
            gGXrdRev2ToolStripMenuItem.Checked = false;
            BBCFToolStripMenuItem.Checked = false;
            SGSettings.Visible = true;
            BBTagSettings.Visible = false;
            GGXrdSettings.Visible = false;
            BBCFSettings.Visible = false;
        }

        private void rivalsOfAetherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentGame = viewROA.game;
            skullgirlsToolStripMenuItem.Checked = false;
            rivalsOfAetherToolStripMenuItem.Checked = true;
            bBTagToolStripMenuItem.Checked = false;
            gGXrdRev2ToolStripMenuItem.Checked = false;
            BBCFToolStripMenuItem.Checked = false;
            SGSettings.Visible = false;
            BBTagSettings.Visible = false;
            GGXrdSettings.Visible = false;
            BBCFSettings.Visible = false;
        }

        private void BBTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentGame = viewBBTag.game;
            skullgirlsToolStripMenuItem.Checked = false;
            rivalsOfAetherToolStripMenuItem.Checked = false;
            bBTagToolStripMenuItem.Checked = true;
            gGXrdRev2ToolStripMenuItem.Checked = false;
            BBCFToolStripMenuItem.Checked = false;
            SGSettings.Visible = false;
            BBTagSettings.Visible = true;
            GGXrdSettings.Visible = false;
            BBCFSettings.Visible = false;
        }

        private void gGXrdRev2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentGame = viewGGXrd.game;
            skullgirlsToolStripMenuItem.Checked = false;
            rivalsOfAetherToolStripMenuItem.Checked = false;
            bBTagToolStripMenuItem.Checked = false;
            gGXrdRev2ToolStripMenuItem.Checked = true;
            BBCFToolStripMenuItem.Checked = false;
            SGSettings.Visible = false;
            BBTagSettings.Visible = false;
            GGXrdSettings.Visible = true;
            BBCFSettings.Visible = false;
        }

        private void BBCFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentGame = viewBBCF.game;
            skullgirlsToolStripMenuItem.Checked = false;
            rivalsOfAetherToolStripMenuItem.Checked = false;
            bBTagToolStripMenuItem.Checked = false;
            gGXrdRev2ToolStripMenuItem.Checked = false;
            BBCFToolStripMenuItem.Checked = true;
            SGSettings.Visible = false;
            BBTagSettings.Visible = false;
            GGXrdSettings.Visible = false;
            BBCFSettings.Visible = true;
        }

        private void moreOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            this.Enabled = false;
            settings.FormClosed += SettingsClosed;
            settings.Show();
        }

        private void readmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "README.txt");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            this.Enabled = false;
            about.FormClosed += ResetUI;
            about.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (SuppressKeys)
            {
                foreach (TapToSetTextBox box in boxes)
                {
                    if (box.Focused == true)
                    {
                        box.SetKey(this, new KeyEventArgs(keyData));
                        break;
                    }
                }
                SuppressKeys = false;
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private bool SuppressKeys = false;
        private List<Control> boxes = new List<Control>();
    }
}
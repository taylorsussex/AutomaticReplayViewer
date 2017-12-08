using System;
using System.ComponentModel;
using System.Configuration;
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
            if (File.Exists("AutomaticReplayViewer.exe.config"))
            {
                // Initialise keys
                LK = ParseKeys(ConfigurationManager.AppSettings["SG LK keyboard input"]);
                Right = ParseKeys(ConfigurationManager.AppSettings["SG Right keyboard input"]);
            }
            else
            {
                GenerateConfigFile();
            }

            // Initialise SGReplayViewer object
            viewSG = new SGReplayViewer();

            // Initialise event handlers
            viewSG.PropertyChanged += ProgressText_PropertyChanged;
            viewSG.LoopEnded += ResetUI;

            numReplays.Text = ConfigurationManager.AppSettings["DefaultNumberOfReplays"];
            InputRecordHotkey.Text = ConfigurationManager.AppSettings["DefaultRecordHotkey"];
            InputStopHotkey.Text = ConfigurationManager.AppSettings["DefaultStopHotkey"];
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

            // Start main loop
            viewSG.StartLoop(ReplaysToPlay, LK, Right, RecordHotkey, StopHotkey);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            viewSG.ProcessRunning = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ResetUI(object sender, EventArgs e)
        {
            StartButton.BeginInvoke((Action)delegate () { StartButton.Enabled = true; });
            StopButton.BeginInvoke((Action)delegate () { StopButton.Enabled = false; });
            numReplays.BeginInvoke((Action)delegate () { numReplays.Enabled = true; });
            InputRecordHotkey.BeginInvoke((Action)delegate () { InputRecordHotkey.Enabled = true; });
            InputStopHotkey.BeginInvoke((Action)delegate () { InputStopHotkey.Enabled = true; });
        }

        private void ProgressText_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            labelText = viewSG.ProgressText;
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
            System.Text.StringBuilder sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sb.AppendLine("<configuration>");
            sb.AppendLine("  <appSettings>");
            sb.AppendLine("    <!--Relevant Key Bindings in SG-->");
            sb.AppendLine("    <!--It is essential that the keys here match the bindings that you have in SG-->");
            sb.AppendLine("    <!--All key settings must be as they are for System.Windows.Forms.Keys-->");
            sb.AppendLine("    <!--This list can be checked here msdn.microsoft.com/en-us/library/system.windows.forms.keys.aspx-->");
            sb.AppendLine("    <add key=\"SG LK keyboard input\" value=\"Z\" />");
            sb.AppendLine("    <add key=\"SG Right keyboard input\" value=\"Right\" />");
            sb.AppendLine("");
            sb.AppendLine("    <!--Default Settings on Load-->");
            sb.AppendLine("    <add key=\"DefaultNumberOfReplays\" value=\"1\" />");
            sb.AppendLine("    <add key=\"DefaultRecordHotkey\" value=\"\" />");
            sb.AppendLine("    <add key=\"DefaultStopHotkey\" value=\"\" />");
            sb.AppendLine("  </appSettings>");
            sb.AppendLine("</configuration>");

            string loc = Assembly.GetEntryAssembly().Location;
            System.IO.File.WriteAllText(String.Concat(loc, ".config"), sb.ToString());
        }

        private SGReplayViewer viewSG;
        private Keys LK = Keys.Z;
        private new Keys Right = Keys.Right;
    }
}
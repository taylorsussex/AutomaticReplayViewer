using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace AutomaticReplayViewer
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            SettingsList.SelectedIndex = 0;

            numReplays.Text = ConfigurationManager.AppSettings["DefaultNumberOfReplays"];
            InputRecordHotkey.Text = ConfigurationManager.AppSettings["DefaultRecordHotkey"];
            InputStopHotkey.Text = ConfigurationManager.AppSettings["DefaultStopHotkey"];
            DefaultGame.Text = ConfigurationManager.AppSettings["DefaultGame"];
            SGLPKeyboardInput.Text = ConfigurationManager.AppSettings["SG LP keyboard input"];
            SGLKKeyboardInput.Text = ConfigurationManager.AppSettings["SG LK keyboard input"];
            SGMPKeyboardInput.Text = ConfigurationManager.AppSettings["SG MP keyboard input"];
            SGRightKeyboardInput.Text = ConfigurationManager.AppSettings["SG Right keyboard input"];
            DisplayHitboxes.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["DefaultDisplayHitboxes"]);
            DisplayInputs.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["DefaultDisplayInputs"]);
            DisplayAttackData.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["DefaultDisplayAttackData"]);
            ROAStartKeyboardInput.Text = ConfigurationManager.AppSettings["ROA Start keyboard input"];
            ROALKeyboardInput.Text = ConfigurationManager.AppSettings["ROA L keyboard input"];
            BBTagUpKeyboardInput.Text = ConfigurationManager.AppSettings["BBTag Up keyboard input"];
            BBTagConfirmKeyboardInput.Text = ConfigurationManager.AppSettings["BBTag Confirm keyboard input"];
            BBTagGaugeKeyboardInput.Text = ConfigurationManager.AppSettings["BBTag Gauge keyboard input"];
            BBTagWindowKeyboardInput.Text = ConfigurationManager.AppSettings["BBTag Window keyboard input"];
            BBTagHideGauge.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["BBTag Hide Gauge"]);
            BBTagHideWindow.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["BBTag Hide Window"]);
            ptrupdatelabel.Text = "Last Updated:" + ConfigurationManager.AppSettings["LastTimePointersUpdated"];

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

            this.MouseClick += Settings_MouseClick;
        }

        private void Settings_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Box_WaitingForKey(object sender, EventArgs e)
        {
            SuppressKeys = true;
        }

        private void SettingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SettingsList.SelectedIndex)
            {
                default:
                    panelGeneral.Visible = true;
                    panelSG.Visible = false;
                    panelROA.Visible = false;
                    panelBBTag.Visible = false;
                    break;
                case 1:
                    panelGeneral.Visible = false;
                    panelSG.Visible = true;
                    panelROA.Visible = false;
                    panelBBTag.Visible = false;
                    break;
                case 2:
                    panelGeneral.Visible = false;
                    panelSG.Visible = false;
                    panelROA.Visible = true;
                    panelBBTag.Visible = false;
                    break;
                case 3:
                    panelGeneral.Visible = false;
                    panelSG.Visible = false;
                    panelROA.Visible = false;
                    panelBBTag.Visible = true;
                    break;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            string loc = Assembly.GetEntryAssembly().Location;
            xmlDoc.Load(String.Concat(loc, ".config"));

            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes == null)
                            continue;
                        switch (node.Attributes[0].Value)
                        {
                            case "DefaultNumberOfReplays":
                                ConfigurationManager.AppSettings["DefaultNumberOfReplays"] = numReplays.Text;
                                node.Attributes[1].Value = numReplays.Text;
                                break;
                            case "DefaultRecordHotkey":
                                ConfigurationManager.AppSettings["DefaultRecordHotkey"] = InputRecordHotkey.Text;
                                node.Attributes[1].Value = InputRecordHotkey.Text;
                                break;
                            case "DefaultStopHotkey":
                                ConfigurationManager.AppSettings["DefaultStopHotkey"] = InputStopHotkey.Text;
                                node.Attributes[1].Value = InputStopHotkey.Text;
                                break;
                            case "DefaultGame":
                                ConfigurationManager.AppSettings["DefaultGame"] = DefaultGame.Text;
                                node.Attributes[1].Value = DefaultGame.Text;
                                break;
                            case "SG LP keyboard input":
                                ConfigurationManager.AppSettings["SG LP keyboard input"] = SGLPKeyboardInput.Text;
                                node.Attributes[1].Value = SGLPKeyboardInput.Text;
                                break;
                            case "SG LK keyboard input":
                                ConfigurationManager.AppSettings["SG LK keyboard input"] = SGLKKeyboardInput.Text;
                                node.Attributes[1].Value = SGLKKeyboardInput.Text;
                                break;
                            case "SG MP keyboard input":
                                ConfigurationManager.AppSettings["SG MP keyboard input"] = SGMPKeyboardInput.Text;
                                node.Attributes[1].Value = SGMPKeyboardInput.Text;
                                break;
                            case "SG Right keyboard input":
                                ConfigurationManager.AppSettings["SG Right keyboard input"] = SGRightKeyboardInput.Text;
                                node.Attributes[1].Value = SGRightKeyboardInput.Text;
                                break;
                            case "DefaultDisplayHitboxes":
                                ConfigurationManager.AppSettings["DefaultDisplayHitboxes"] = DisplayHitboxes.Checked.ToString();
                                node.Attributes[1].Value = DisplayHitboxes.Checked.ToString();
                                break;
                            case "DefaultDisplayInputs":
                                ConfigurationManager.AppSettings["DefaultDisplayInputs"] = DisplayInputs.Checked.ToString();
                                node.Attributes[1].Value = DisplayInputs.Checked.ToString();
                                break;
                            case "DefaultDisplayAttackData":
                                ConfigurationManager.AppSettings["DefaultDisplayAttackData"] = DisplayAttackData.Checked.ToString();
                                node.Attributes[1].Value = DisplayAttackData.Checked.ToString();
                                break;
                            case "ROA Start keyboard input":
                                ConfigurationManager.AppSettings["ROA Start keyboard input"] = ROAStartKeyboardInput.Text;
                                node.Attributes[1].Value = ROAStartKeyboardInput.Text;
                                break;
                            case "ROA L keyboard input":
                                ConfigurationManager.AppSettings["ROA L keyboard input"] = ROALKeyboardInput.Text;
                                node.Attributes[1].Value = ROALKeyboardInput.Text;
                                break;
                            case "BBTag Up keyboard input":
                                ConfigurationManager.AppSettings["BBTag Up keyboard input"] = BBTagUpKeyboardInput.Text;
                                node.Attributes[1].Value = BBTagUpKeyboardInput.Text;
                                break;
                            case "BBTag Confirm keyboard input":
                                ConfigurationManager.AppSettings["BBTag Left keyboard input"] = BBTagConfirmKeyboardInput.Text;
                                node.Attributes[1].Value = BBTagConfirmKeyboardInput.Text;
                                break;
                            case "BBTag Gauge keyboard input":
                                ConfigurationManager.AppSettings["BBTag Gauge keyboard input"] = BBTagGaugeKeyboardInput.Text;
                                node.Attributes[1].Value = BBTagGaugeKeyboardInput.Text;
                                break;
                            case "BBTag Window keyboard input":
                                ConfigurationManager.AppSettings["BBTag Window keyboard input"] = BBTagWindowKeyboardInput.Text;
                                node.Attributes[1].Value = BBTagWindowKeyboardInput.Text;
                                break;
                            case "BBTag Hide Gauge":
                                ConfigurationManager.AppSettings["BBTag Hide Gauge"] = BBTagHideGauge.Checked.ToString();
                                node.Attributes[1].Value = BBTagHideGauge.Checked.ToString();
                                break;
                            case "BBTag Hide Window":
                                ConfigurationManager.AppSettings["BBTag Hide Window"] = BBTagHideWindow.Checked.ToString();
                                node.Attributes[1].Value = BBTagHideWindow.Checked.ToString();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            xmlDoc.Save(String.Concat(loc, ".config"));

            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
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

        private void UpdatePointers_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            string SGMenuState, ROAMenuState, ROACursorX, ROACursorY, BBTagReplayTheaterActive, BBTagReplayPlaying, BBTagCursor, LastTimePointersUpdated;
            bool AlreadyUpToDate = false;
            SGMenuState = ROAMenuState = ROACursorX = ROACursorY = BBTagReplayTheaterActive = BBTagReplayPlaying = BBTagCursor = LastTimePointersUpdated = "";

            string url = "https://drive.google.com/uc?export=download&id=1brS3pncZNdeWSUX26YwBjipefdrZrkhk";
            XmlDocument ptrXML = new XmlDocument();
            try
            {
                ptrXML.Load(url);
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Unable to access pointers. Please connect to the internet in order to update.");
                this.Enabled = true;
                return;
            }
            foreach (XmlElement element in ptrXML.SelectNodes("*"))
            {
                foreach (XmlNode node in element.ChildNodes)
                {
                    if (node.Attributes == null)
                        continue;
                    switch (node.Attributes[0].Value)
                    {
                        case "SGMenuState":
                            SGMenuState = node.Attributes[1].Value;
                            break;
                        case "ROAMenuState":
                            ROAMenuState = node.Attributes[1].Value;
                            break;
                        case "ROACursorX":
                            ROACursorX = node.Attributes[1].Value;
                            break;
                        case "ROACursorY":
                            ROACursorY = node.Attributes[1].Value;
                            break;
                        case "BBTagReplayTheaterActive":
                            BBTagReplayTheaterActive = node.Attributes[1].Value;
                            break;
                        case "BBTagCursor":
                            BBTagCursor = node.Attributes[1].Value;
                            break;
                        case "BBTagReplayPlaying":
                            BBTagReplayPlaying = node.Attributes[1].Value;
                            break;
                        case "LastTimePointersUpdated":
                            LastTimePointersUpdated = node.Attributes[1].Value;
                            break;
                        default:
                            break;
                    }
                }
            }

            AlreadyUpToDate = (LastTimePointersUpdated == ConfigurationManager.AppSettings["LastTimePointersUpdated"]);

            XmlDocument xmlDoc = new XmlDocument();
            string loc = Assembly.GetEntryAssembly().Location;
            xmlDoc.Load(String.Concat(loc, ".config"));

            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes == null)
                            continue;
                        switch (node.Attributes[0].Value)
                        {
                            case "SGMenuState":
                                ConfigurationManager.AppSettings["SGMenuState"] = SGMenuState;
                                node.Attributes[1].Value = SGMenuState;
                                break;
                            case "ROAMenuState":
                                ConfigurationManager.AppSettings["ROAMenuState"] = ROAMenuState;
                                node.Attributes[1].Value = ROAMenuState;
                                break;
                            case "ROACursorX":
                                ConfigurationManager.AppSettings["ROACursorX"] = ROACursorX;
                                node.Attributes[1].Value = ROACursorX;
                                break;
                            case "ROACursorY":
                                ConfigurationManager.AppSettings["ROACursorY"] = ROACursorY;
                                node.Attributes[1].Value = ROACursorY;
                                break;
                            case "BBTagReplayTheaterActive":
                                ConfigurationManager.AppSettings["BBTagReplayTheaterActive"] = BBTagReplayTheaterActive;
                                node.Attributes[1].Value = BBTagReplayTheaterActive;
                                break;
                            case "BBTagCursor":
                                ConfigurationManager.AppSettings["BBTagCursor"] = BBTagCursor;
                                node.Attributes[1].Value = BBTagCursor;
                                break;
                            case "BBTagReplayPlaying":
                                ConfigurationManager.AppSettings["BBTagReplayPlaying"] = BBTagReplayPlaying;
                                node.Attributes[1].Value = BBTagReplayPlaying;
                                break;
                            case "LastTimePointersUpdated":
                                ConfigurationManager.AppSettings["LastTimePointersUpdated"] = LastTimePointersUpdated;
                                node.Attributes[1].Value = LastTimePointersUpdated;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            xmlDoc.Save(String.Concat(loc, ".config"));

            ptrupdatelabel.Text = "Last Updated:" + ConfigurationManager.AppSettings["LastTimePointersUpdated"];
            MessageBox.Show(AlreadyUpToDate ? "Pointers already up to date" : "Pointers succesfully updated");

            this.Enabled = true;
        }

        private bool SuppressKeys = false;
        private List<Control> boxes = new List<Control>();
    }
}
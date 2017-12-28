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
            ROAUpKeyboardInput.Text = ConfigurationManager.AppSettings["ROA Up keyboard input"];
            ROADownKeyboardInput.Text = ConfigurationManager.AppSettings["ROA Down keyboard input"];
            ROALeftKeyboardInput.Text = ConfigurationManager.AppSettings["ROA Left keyboard input"];
            ROARightKeyboardInput.Text = ConfigurationManager.AppSettings["ROA Right keyboard input"];
            ROAAKeyboardInput.Text = ConfigurationManager.AppSettings["ROA A keyboard input"];
            ROALKeyboardInput.Text = ConfigurationManager.AppSettings["ROA L keyboard input"];

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
                    break;
                case 1:
                    panelGeneral.Visible = false;
                    panelSG.Visible = true;
                    panelROA.Visible = false;
                    break;
                case 2:
                    panelGeneral.Visible = false;
                    panelSG.Visible = false;
                    panelROA.Visible = true;
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
                            case "ROA Up keyboard input":
                                ConfigurationManager.AppSettings["ROA Up keyboard input"] = ROAUpKeyboardInput.Text;
                                node.Attributes[1].Value = ROAUpKeyboardInput.Text;
                                break;
                            case "ROA Down keyboard input":
                                ConfigurationManager.AppSettings["ROA Down keyboard input"] = ROADownKeyboardInput.Text;
                                node.Attributes[1].Value = ROADownKeyboardInput.Text;
                                break;
                            case "ROA Left keyboard input":
                                ConfigurationManager.AppSettings["ROA Left keyboard input"] = ROALeftKeyboardInput.Text;
                                node.Attributes[1].Value = ROALeftKeyboardInput.Text;
                                break;
                            case "ROA Right keyboard input":
                                ConfigurationManager.AppSettings["ROA Right keyboard input"] = ROARightKeyboardInput.Text;
                                node.Attributes[1].Value = ROARightKeyboardInput.Text;
                                break;
                            case "ROA A keyboard input":
                                ConfigurationManager.AppSettings["ROA A keyboard input"] = ROAAKeyboardInput.Text;
                                node.Attributes[1].Value = ROAAKeyboardInput.Text;
                                break;
                            case "ROA L keyboard input":
                                ConfigurationManager.AppSettings["ROA L keyboard input"] = ROALKeyboardInput.Text;
                                node.Attributes[1].Value = ROALKeyboardInput.Text;
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

        private bool SuppressKeys = false;
        private List<Control> boxes = new List<Control>();
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace AutomaticReplayViewer
{
    public partial class TapToSetTextBox : TextBox
    {
        public TapToSetTextBox()
        {
            InitializeComponent();
            this.MouseDown += TapToSetTextBox_MouseDown;
            this.GotFocus += WaitForKeyPress;
        }

        private void TapToSetTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.ContextMenu = new ContextMenu();
                this.Text = "";
                return;
            }
        }

        private void WaitForKeyPress(object sender, EventArgs e)
        {
            WaitingForKey?.Invoke(this, e);
            HideCaret(this.Handle);
            this.BackColor = SystemColors.ControlDark;

            this.KeyDown += SetKey;
            this.LostFocus += TapToSetTextBox_LostFocus;
            this.DoubleClick += TapToSetTextBox_LostFocus;
        }

        private void TapToSetTextBox_LostFocus(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            this.Enabled = false;
            this.Enabled = true;
        }

        public void SetKey(object sender, KeyEventArgs e)
        {
            this.Text = e.KeyCode.ToString();
            this.BackColor = SystemColors.Control;
            SendKeys.Send("{TAB}");
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public event EventHandler WaitingForKey;

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
    }
}

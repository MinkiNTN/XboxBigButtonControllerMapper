using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XboxBigButton;

namespace XboxBigButtonMapper
{
    public partial class BigButtonMapper : Form
    {
        /// <summary>
        /// The big button controller
        /// </summary>
        private XboxBigButtonDevice _device;

        /// <summary>
        /// Time when the last keypress was received from the controller, use this to discard excessive repeating keys
        /// </summary>
        private Tuple<Controller, Buttons, DateTime> _lastKeyTime = null;

        public BigButtonMapper()
        {
            InitializeComponent();

            _device = new XboxBigButtonDevice();
            _device.ButtonStateChanged += _device_ButtonStateChanged;

            _device.Connect();
        }

        private void _device_ButtonStateChanged(object sender, XboxBigButtonDeviceEventArgs e)
        {
            if (this.InvokeRequired)
                this.BeginInvoke(new Action(() => this.SendKeysToWindow(e.Controller, e.ButtonState)));
            else
                this.SendKeysToWindow(e.Controller, e.ButtonState);
        }

        private void SendKeysToWindow(Controller controller, Buttons buttons)
        {
            var timeNow = DateTime.Now;
            if (_lastKeyTime != null &&
                _lastKeyTime.Item1 == controller &&
                _lastKeyTime.Item2 == buttons &&
                (timeNow - _lastKeyTime.Item3).TotalSeconds < .5d)
            {
                // If the last key event was within tolerance then don't process it (if key events happen too quickly)
                return;
            }

            // Save the time if we successfully sent keys
            _lastKeyTime = new Tuple<Controller, Buttons, DateTime>(controller, buttons, timeNow);

            switch (controller)
            {
                case Controller.Green:
                    this.currentControllerLabel.Text = "Green";
                    break;
                case Controller.Red:
                    this.currentControllerLabel.Text = "Red";
                    break;
                case Controller.Blue:
                    this.currentControllerLabel.Text = "Blue";
                    break;
                case Controller.Yellow:
                    this.currentControllerLabel.Text = "Yellow";
                    break;
                default:
                    this.currentControllerLabel.Text = "N/A";
                    break;
            }

            switch (buttons)
            {
                case Buttons.Up:
                    this.currentButtonLabel.Text = "Up";
                    break;
                case Buttons.Down:
                    this.currentButtonLabel.Text = "Down";
                    break;
                case Buttons.Left:
                    this.currentButtonLabel.Text = "Left";
                    break;
                case Buttons.Right:
                    this.currentButtonLabel.Text = "Right";
                    break;
                case Buttons.BigButton:
                    this.currentButtonLabel.Text = "Big Button";
                    break;
                case Buttons.A:
                    this.currentButtonLabel.Text = "A";
                    break;
                case Buttons.B:
                    this.currentButtonLabel.Text = "B";
                    break;
                case Buttons.X:
                    this.currentButtonLabel.Text = "X";
                    break;
                case Buttons.Y:
                    this.currentButtonLabel.Text = "Y";
                    break;
                case Buttons.Back:
                    this.currentButtonLabel.Text = "Back";
                    break;
                case Buttons.Start:
                    this.currentButtonLabel.Text = "Start";
                    break;
                case Buttons.Home:
                    this.currentButtonLabel.Text = "Home";
                    break;
                default:
                    this.currentButtonLabel.Text = "N/A";
                    break;
            }

            //if (buttons.IsPressed(Buttons.Start))
            //{
            //    return;
            //}
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
                components = null;

                _device?.Disconnect();
                _device = null;
            }

            base.Dispose(disposing);
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            _device?.Disconnect();
        }
    }
}

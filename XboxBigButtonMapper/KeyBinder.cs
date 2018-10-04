using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XboxBigButtonMapper
{
    public partial class KeyBinder : Form
    {

        private string currentButtonName;

        public KeyBinder()
        {
            InitializeComponent();
        }

        public string CurrentButtonName {
            get => currentButtonName;
            set
            {
                currentButtonName = value;
                label1.Text = value;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

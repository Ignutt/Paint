using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class loadingScreen : Form
    {
        public loadingScreen()
        {
            InitializeComponent();
        }
        Form mainForm = new Form1();
        int timeValue = 3, counterSeconds = 0;
        private void loadingScreenTimer_Tick(object sender, EventArgs e)
        {
            counterSeconds++;
            if (counterSeconds == timeValue)
            {
                loadingScreenTimer.Enabled = false;
                this.Hide();
                mainForm.ShowDialog();
            }
        }
    }
}

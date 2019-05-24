using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Paint
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void aboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void linkDeveloper_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/a0b0c0d0e0f0g0h0");
        }

        private void linkDeveloper_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void linkDeveloper_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/StepByStepForSuccess/Paint");
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}

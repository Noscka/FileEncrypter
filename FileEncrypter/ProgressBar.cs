using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEncrypter
{
    public partial class ProgressBar : Form
    {
        Main MyParent;
        public ProgressBar(Main MyParent)
        {
            InitializeComponent();
            this.MyParent = MyParent;
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {

        }

        public void UpdateProgressBar(string copyingText, int value, int Mode)
        {
            CopyingTextLabel.Text = copyingText;
            progressBar1.Value = value;
            switch (Mode)
            {
                case 1:
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    break;
            }
        }

        private void ProgressBar_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

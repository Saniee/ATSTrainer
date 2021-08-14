using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace ATSTrainer
{
    public partial class MainWindow : Form
    {
        Mem m = new Mem();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        bool ProcOpen = false;

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess("amtrucks");

            Thread.Sleep(100);
            BGWorker.ReportProgress(0);
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                ProcOpenLabel.ForeColor = Color.Green;
                ProcOpenLabel.Text = "Yes";
            } 
            else
            {
                ProcOpenLabel.ForeColor = Color.Red;
                ProcOpenLabel.Text = "N/A";
                return;
            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void SetMoney_Click(object sender, EventArgs e)
        {
            if (MoneyAmount.Text == "")
            {
                MoneyAmount.Text = "Type in a number.";
            }
            else
            {
                // Public Beta 1.41
                m.WriteMemory("amtrucks.exe+01931738,10,10", "int", MoneyAmount.Text);
            }
        }

        private void SetEXP_Click(object sender, EventArgs e)
        {
            if (EXPAmount.Text == "")
            {
                EXPAmount.Text = "Type in a number.";
            }
            else
            {
                // Public Beta 1.41
                m.WriteMemory("amtrucks.exe+01931738,195C", "int", EXPAmount.Text);
            }
        }

        private void rgch_CheckedChanged(object sender, EventArgs e)
        {
            if (rgch.Checked)
            {
                m.WriteMemory("amtrucks.exe+A31FA8", "bytes", "83 79 10 00");
            }
            else
            {
                m.WriteMemory("amtrucks.exe+A31FA8", "bytes", "48 39 41 10");
            }
        }

        private void rmd_CheckedChanged(object sender, EventArgs e)
        {
            if (rmd.Checked)
            {
                m.WriteMemory("amtrucks.exe+6B36EE", "bytes", "48 01 D8");
            }
            else
            {
                m.WriteMemory("amtrucks.exe+6B36EE", "bytes", "48 29 D8");
            }
        }
    }
}

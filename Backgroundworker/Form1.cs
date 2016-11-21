using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgroundworker_Bsp
{
    public partial class Form1 : Form
    {
        private Int32 iMax = 10000;
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < iMax; i++)
            {
                if (i % 31 == 0)
                {
                    (sender as BackgroundWorker).ReportProgress(i);
                    System.Threading.Thread.Sleep(10);
                }

            }
                e.Result = iMax;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label_Ausgabe_Background.Text = e.ProgressPercentage.ToString();
            label_Ausgabe_Background.Refresh();
            if ((sender as BackgroundWorker).IsBusy)
                button_Start.BackColor = Color.Yellow;
            else
                button_Start.BackColor = SystemColors.Control;
        }

        private void textBox_Eingabe_Validated(object sender, EventArgs e)
        {
            label_Ausgabe_Vordergrund.Text = textBox_Eingabe.Text;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
            else
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_Ausgabe_Background.Text = null == e.Result ? "fertig" : e.Result.ToString();
            label_Ausgabe_Background.Refresh();
            if ((sender as BackgroundWorker).IsBusy)
                button_Start.BackColor = Color.Yellow;
            else
                button_Start.BackColor = Color.Green;
        }
    }
}

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
            BackgroundWorker bw = (BackgroundWorker)sender;
            for (int i = 0; i < iMax; i++)
            {
                // führt zur Exception:
                // label_Ausgabe_Background.Text = "In _DoWork";
                if (bw.CancellationPending)
                {
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(1);
                    if (i % 31 == 0)
                    {
                        bw.ReportProgress(i);
                    }
                }
            }

            if (!bw.CancellationPending)
                e.Result = iMax;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label_Ausgabe_Background.Text = e.ProgressPercentage.ToString();
            label_Ausgabe_Background.Refresh();

            // nicht wirklich genial
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
            // Wenn schon aktiv, dann abbrechen, sonst starten
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
            else
                backgroundWorker1.RunWorkerAsync();

            // Status ändert sich
            if (backgroundWorker1.IsBusy)
                button_Start.Text = "&Abbruch";
            else
                button_Start.Text = "&Start Background";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (null == e.Result)
            {
                label_Ausgabe_Background.Text += " - Abbruch!";
            }
            else
            {
                label_Ausgabe_Background.Text = e.Result.ToString();
            }

            label_Ausgabe_Background.Refresh();
            if ((sender as BackgroundWorker).IsBusy)
            {
                button_Start.BackColor = Color.Yellow;
                button_Start.Text = "&Abbruch";
            }
            else
            {
                button_Start.BackColor = Color.Green;
                button_Start.Text = "&Start Background";
            }
        }
    }
}

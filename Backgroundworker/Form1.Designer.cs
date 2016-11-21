namespace Backgroundworker_Bsp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Ausgabe_Background = new System.Windows.Forms.Label();
            this.textBox_Eingabe = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_Ausgabe_Vordergrund = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Ausgabe_Background
            // 
            this.label_Ausgabe_Background.AutoSize = true;
            this.label_Ausgabe_Background.Location = new System.Drawing.Point(12, 240);
            this.label_Ausgabe_Background.Name = "label_Ausgabe_Background";
            this.label_Ausgabe_Background.Size = new System.Drawing.Size(78, 13);
            this.label_Ausgabe_Background.TabIndex = 0;
            this.label_Ausgabe_Background.Text = "noch nichts los";
            // 
            // textBox_Eingabe
            // 
            this.textBox_Eingabe.Location = new System.Drawing.Point(46, 42);
            this.textBox_Eingabe.Name = "textBox_Eingabe";
            this.textBox_Eingabe.Size = new System.Drawing.Size(100, 20);
            this.textBox_Eingabe.TabIndex = 1;
            this.textBox_Eingabe.Validated += new System.EventHandler(this.textBox_Eingabe_Validated);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label_Ausgabe_Vordergrund
            // 
            this.label_Ausgabe_Vordergrund.AutoSize = true;
            this.label_Ausgabe_Vordergrund.Location = new System.Drawing.Point(46, 69);
            this.label_Ausgabe_Vordergrund.Name = "label_Ausgabe_Vordergrund";
            this.label_Ausgabe_Vordergrund.Size = new System.Drawing.Size(35, 13);
            this.label_Ausgabe_Vordergrund.TabIndex = 2;
            this.label_Ausgabe_Vordergrund.Text = "label1";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(46, 150);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "&Start Background";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Ausgabe_Vordergrund);
            this.Controls.Add(this.textBox_Eingabe);
            this.Controls.Add(this.label_Ausgabe_Background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Ausgabe_Background;
        private System.Windows.Forms.TextBox textBox_Eingabe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_Ausgabe_Vordergrund;
        private System.Windows.Forms.Button button_Start;
    }
}


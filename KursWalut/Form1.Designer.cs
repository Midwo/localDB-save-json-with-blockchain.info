namespace KursWalut
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.lMinuty = new System.Windows.Forms.Label();
            this.lWykonujCo = new System.Windows.Forms.Label();
            this.nUDCoIleMinut = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nUDCoIleMinut)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pobieraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lMinuty
            // 
            this.lMinuty.AutoSize = true;
            this.lMinuty.Location = new System.Drawing.Point(236, 11);
            this.lMinuty.Name = "lMinuty";
            this.lMinuty.Size = new System.Drawing.Size(42, 13);
            this.lMinuty.TabIndex = 24;
            this.lMinuty.Text = "sekund";
            // 
            // lWykonujCo
            // 
            this.lWykonujCo.AutoSize = true;
            this.lWykonujCo.Location = new System.Drawing.Point(9, 9);
            this.lWykonujCo.Name = "lWykonujCo";
            this.lWykonujCo.Size = new System.Drawing.Size(149, 13);
            this.lWykonujCo.TabIndex = 23;
            this.lWykonujCo.Text = "Wykonuj pobranie danych co:";
            // 
            // nUDCoIleMinut
            // 
            this.nUDCoIleMinut.Location = new System.Drawing.Point(164, 7);
            this.nUDCoIleMinut.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDCoIleMinut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDCoIleMinut.Name = "nUDCoIleMinut";
            this.nUDCoIleMinut.Size = new System.Drawing.Size(62, 20);
            this.nUDCoIleMinut.TabIndex = 22;
            this.nUDCoIleMinut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(289, 64);
            this.Controls.Add(this.lMinuty);
            this.Controls.Add(this.lWykonujCo);
            this.Controls.Add(this.nUDCoIleMinut);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MD json kurs BitCoin";
            ((System.ComponentModel.ISupportInitialize)(this.nUDCoIleMinut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lMinuty;
        private System.Windows.Forms.Label lWykonujCo;
        private System.Windows.Forms.NumericUpDown nUDCoIleMinut;
        private System.Windows.Forms.Timer timer1;
    }
}


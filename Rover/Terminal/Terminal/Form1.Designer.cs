namespace Terminal
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.iniziaB = new System.Windows.Forms.Button();
            this.stopB = new System.Windows.Forms.Button();
            this.pausaB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iniziaB
            // 
            this.iniziaB.Location = new System.Drawing.Point(34, 137);
            this.iniziaB.Name = "iniziaB";
            this.iniziaB.Size = new System.Drawing.Size(115, 106);
            this.iniziaB.TabIndex = 0;
            this.iniziaB.Text = "INIZIA";
            this.iniziaB.UseVisualStyleBackColor = true;
            // 
            // stopB
            // 
            this.stopB.Location = new System.Drawing.Point(202, 137);
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(115, 106);
            this.stopB.TabIndex = 1;
            this.stopB.Text = "STOP";
            this.stopB.UseVisualStyleBackColor = true;
            // 
            // pausaB
            // 
            this.pausaB.Location = new System.Drawing.Point(365, 137);
            this.pausaB.Name = "pausaB";
            this.pausaB.Size = new System.Drawing.Size(115, 106);
            this.pausaB.TabIndex = 2;
            this.pausaB.Text = "PAUSA";
            this.pausaB.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 300);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 69);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 413);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pausaB);
            this.Controls.Add(this.stopB);
            this.Controls.Add(this.iniziaB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniziaB;
        private System.Windows.Forms.Button stopB;
        private System.Windows.Forms.Button pausaB;
        private System.Windows.Forms.TextBox textBox1;
    }
}


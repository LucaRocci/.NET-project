
namespace PrimaAPP2804
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
            this.textOp1 = new System.Windows.Forms.TextBox();
            this.textOp2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textOp1
            // 
            this.textOp1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textOp1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textOp1.Location = new System.Drawing.Point(12, 12);
            this.textOp1.Name = "textOp1";
            this.textOp1.Size = new System.Drawing.Size(154, 20);
            this.textOp1.TabIndex = 0;
            this.textOp1.Text = "first number";
            // 
            // textOp2
            // 
            this.textOp2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textOp2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textOp2.Location = new System.Drawing.Point(12, 56);
            this.textOp2.Name = "textOp2";
            this.textOp2.Size = new System.Drawing.Size(154, 20);
            this.textOp2.TabIndex = 1;
            this.textOp2.Text = "Second number";
            // 
            // btn1
            // 
            this.btn1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn1.Location = new System.Drawing.Point(43, 98);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(71, 34);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Somma";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 398);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textOp2);
            this.Controls.Add(this.textOp1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textOp1;
        private System.Windows.Forms.TextBox textOp2;
        private System.Windows.Forms.Button btn1;
    }
}


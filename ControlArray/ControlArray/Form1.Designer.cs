
namespace ControlArray
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnesegui1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.Yellow;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(37, 29);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt1.Size = new System.Drawing.Size(153, 58);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt1_KeyDown);
            // 
            // btnesegui1
            // 
            this.btnesegui1.Location = new System.Drawing.Point(257, 29);
            this.btnesegui1.Name = "btnesegui1";
            this.btnesegui1.Size = new System.Drawing.Size(122, 52);
            this.btnesegui1.TabIndex = 1;
            this.btnesegui1.Text = "Premi";
            this.btnesegui1.UseVisualStyleBackColor = true;
            this.btnesegui1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(763, 500);
            this.Controls.Add(this.btnesegui1);
            this.Controls.Add(this.txt1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnesegui1;
    }
}


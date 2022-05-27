
namespace ConnesioneDB2
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgTitles = new System.Windows.Forms.DataGridView();
            this.btnLeggi = new System.Windows.Forms.Button();
            this.Autore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.synopsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTitles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTitles
            // 
            this.dgTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTitles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Autore,
            this.titleno,
            this.synopsis,
            this.Titolo});
            this.dgTitles.Location = new System.Drawing.Point(12, 49);
            this.dgTitles.Name = "dgTitles";
            this.dgTitles.Size = new System.Drawing.Size(507, 346);
            this.dgTitles.TabIndex = 0;
            // 
            // btnLeggi
            // 
            this.btnLeggi.ForeColor = System.Drawing.Color.Red;
            this.btnLeggi.Location = new System.Drawing.Point(14, 13);
            this.btnLeggi.Name = "btnLeggi";
            this.btnLeggi.Size = new System.Drawing.Size(113, 22);
            this.btnLeggi.TabIndex = 1;
            this.btnLeggi.Text = "LEGGI";
            this.btnLeggi.UseVisualStyleBackColor = true;
            this.btnLeggi.Click += new System.EventHandler(this.btnLeggi_Click);
            // 
            // Autore
            // 
            this.Autore.DataPropertyName = "author";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.Autore.DefaultCellStyle = dataGridViewCellStyle2;
            this.Autore.HeaderText = "Autore";
            this.Autore.Name = "Autore";
            // 
            // titleno
            // 
            this.titleno.HeaderText = "Column1";
            this.titleno.Name = "titleno";
            this.titleno.Visible = false;
            // 
            // synopsis
            // 
            this.synopsis.DataPropertyName = "synopsis";
            this.synopsis.HeaderText = "Column1";
            this.synopsis.Name = "synopsis";
            this.synopsis.Visible = false;
            // 
            // Titolo
            // 
            this.Titolo.DataPropertyName = "title";
            this.Titolo.HeaderText = "Titolo Libro";
            this.Titolo.Name = "Titolo";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(189, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "AGGIORNA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLeggi);
            this.Controls.Add(this.dgTitles);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgTitles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTitles;
        private System.Windows.Forms.Button btnLeggi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autore;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn synopsis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titolo;
        private System.Windows.Forms.Button button1;
    }
}

namespace ProveWindowsForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chkBLu = new System.Windows.Forms.CheckBox();
            this.chkRosso = new System.Windows.Forms.CheckBox();
            this.chkVerde = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radiobtnRight = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioBtnR = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvaToolStripMenuItem1,
            this.chiudiToolStripMenuItem});
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salvaToolStripMenuItem.Text = "Menu";
            // 
            // salvaToolStripMenuItem1
            // 
            this.salvaToolStripMenuItem1.Name = "salvaToolStripMenuItem1";
            this.salvaToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.salvaToolStripMenuItem1.Text = "Salva";
            this.salvaToolStripMenuItem1.Click += new System.EventHandler(this.salvaToolStripMenuItem1_Click);
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.chiudiToolStripMenuItem.Text = "Chiudi";
            this.chiudiToolStripMenuItem.Click += new System.EventHandler(this.chiudiToolStripMenuItem_Click);
            // 
            // chkBLu
            // 
            this.chkBLu.AutoSize = true;
            this.chkBLu.Location = new System.Drawing.Point(397, 27);
            this.chkBLu.Name = "chkBLu";
            this.chkBLu.Size = new System.Drawing.Size(41, 17);
            this.chkBLu.TabIndex = 1;
            this.chkBLu.Text = "Blu";
            this.chkBLu.UseVisualStyleBackColor = true;
            this.chkBLu.CheckedChanged += new System.EventHandler(this.chkBLu_CheckedChanged);
            // 
            // chkRosso
            // 
            this.chkRosso.AutoSize = true;
            this.chkRosso.Location = new System.Drawing.Point(444, 27);
            this.chkRosso.Name = "chkRosso";
            this.chkRosso.Size = new System.Drawing.Size(56, 17);
            this.chkRosso.TabIndex = 2;
            this.chkRosso.Text = "Rosso";
            this.chkRosso.UseVisualStyleBackColor = true;
            this.chkRosso.CheckedChanged += new System.EventHandler(this.chkRosso_CheckedChanged);
            // 
            // chkVerde
            // 
            this.chkVerde.AutoSize = true;
            this.chkVerde.Location = new System.Drawing.Point(506, 27);
            this.chkVerde.Name = "chkVerde";
            this.chkVerde.Size = new System.Drawing.Size(54, 17);
            this.chkVerde.TabIndex = 3;
            this.chkVerde.Text = "Verde";
            this.chkVerde.UseVisualStyleBackColor = true;
            this.chkVerde.CheckedChanged += new System.EventHandler(this.chkVerde_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Parigi";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radiobtnRight
            // 
            this.radiobtnRight.AutoSize = true;
            this.radiobtnRight.Location = new System.Drawing.Point(33, 42);
            this.radiobtnRight.Name = "radiobtnRight";
            this.radiobtnRight.Size = new System.Drawing.Size(53, 17);
            this.radiobtnRight.TabIndex = 5;
            this.radiobtnRight.TabStop = true;
            this.radiobtnRight.Text = "Roma";
            this.radiobtnRight.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(33, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Berlino";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(33, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(64, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Pechino";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(369, 405);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(111, 37);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(581, 27);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 425);
            this.vScrollBar1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radiobtnRight);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(22, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "La capitale dell\'Italia?";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(34, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "1930";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(34, 40);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(49, 17);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "1697";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioBtnR
            // 
            this.radioBtnR.AutoSize = true;
            this.radioBtnR.Location = new System.Drawing.Point(34, 63);
            this.radioBtnR.Name = "radioBtnR";
            this.radioBtnR.Size = new System.Drawing.Size(49, 17);
            this.radioBtnR.TabIndex = 13;
            this.radioBtnR.TabStop = true;
            this.radioBtnR.Text = "1492";
            this.radioBtnR.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(34, 86);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(49, 17);
            this.radioButton7.TabIndex = 14;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "1495";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioBtnR);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(22, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 118);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anno scoperta dell\'America?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.chkVerde);
            this.Controls.Add(this.chkRosso);
            this.Controls.Add(this.chkBLu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox chkBLu;
        private System.Windows.Forms.CheckBox chkRosso;
        private System.Windows.Forms.CheckBox chkVerde;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radiobtnRight;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioBtnR;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


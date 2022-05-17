
namespace Controlli
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
            this.chk_red = new System.Windows.Forms.CheckBox();
            this.chk_blu = new System.Windows.Forms.CheckBox();
            this.chk_green = new System.Windows.Forms.CheckBox();
            this.btn_conferma = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioBlu = new System.Windows.Forms.RadioButton();
            this.radio_confirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_red
            // 
            this.chk_red.AutoSize = true;
            this.chk_red.Location = new System.Drawing.Point(119, 27);
            this.chk_red.Name = "chk_red";
            this.chk_red.Size = new System.Drawing.Size(46, 17);
            this.chk_red.TabIndex = 0;
            this.chk_red.Text = "Red";
            this.chk_red.UseVisualStyleBackColor = true;
            this.chk_red.CheckedChanged += new System.EventHandler(this.chk_red_CheckedChanged);
            // 
            // chk_blu
            // 
            this.chk_blu.AutoSize = true;
            this.chk_blu.Location = new System.Drawing.Point(119, 50);
            this.chk_blu.Name = "chk_blu";
            this.chk_blu.Size = new System.Drawing.Size(47, 17);
            this.chk_blu.TabIndex = 1;
            this.chk_blu.Text = "Blue";
            this.chk_blu.UseVisualStyleBackColor = true;
            this.chk_blu.CheckedChanged += new System.EventHandler(this.chk_blu_CheckedChanged);
            // 
            // chk_green
            // 
            this.chk_green.AutoSize = true;
            this.chk_green.Location = new System.Drawing.Point(119, 73);
            this.chk_green.Name = "chk_green";
            this.chk_green.Size = new System.Drawing.Size(55, 17);
            this.chk_green.TabIndex = 2;
            this.chk_green.Text = "Green";
            this.chk_green.UseVisualStyleBackColor = true;
            this.chk_green.CheckedChanged += new System.EventHandler(this.chk_green_CheckedChanged);
            // 
            // btn_conferma
            // 
            this.btn_conferma.Location = new System.Drawing.Point(73, 100);
            this.btn_conferma.Name = "btn_conferma";
            this.btn_conferma.Size = new System.Drawing.Size(171, 51);
            this.btn_conferma.TabIndex = 3;
            this.btn_conferma.Text = "Conferma";
            this.btn_conferma.UseVisualStyleBackColor = true;
            this.btn_conferma.Click += new System.EventHandler(this.btn_conferma_Click);
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.Location = new System.Drawing.Point(468, 56);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(166, 33);
            this.btn_change.TabIndex = 4;
            this.btn_change.Text = "Press Here";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(335, 66);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "label1";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Location = new System.Drawing.Point(27, 14);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(45, 17);
            this.radioRed.TabIndex = 6;
            this.radioRed.TabStop = true;
            this.radioRed.Text = "Red";
            this.radioRed.UseVisualStyleBackColor = true;
            this.radioRed.CheckedChanged += new System.EventHandler(this.radioRed_CheckedChanged);
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Location = new System.Drawing.Point(27, 37);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(54, 17);
            this.radioGreen.TabIndex = 7;
            this.radioGreen.TabStop = true;
            this.radioGreen.Text = "Green";
            this.radioGreen.UseVisualStyleBackColor = true;
            this.radioGreen.CheckedChanged += new System.EventHandler(this.radioGreen_CheckedChanged);
            // 
            // radioBlu
            // 
            this.radioBlu.AutoSize = true;
            this.radioBlu.Location = new System.Drawing.Point(27, 60);
            this.radioBlu.Name = "radioBlu";
            this.radioBlu.Size = new System.Drawing.Size(40, 17);
            this.radioBlu.TabIndex = 8;
            this.radioBlu.TabStop = true;
            this.radioBlu.Text = "Blu";
            this.radioBlu.UseVisualStyleBackColor = true;
            this.radioBlu.CheckedChanged += new System.EventHandler(this.radioBlu_CheckedChanged);
            // 
            // radio_confirm
            // 
            this.radio_confirm.Location = new System.Drawing.Point(53, 291);
            this.radio_confirm.Name = "radio_confirm";
            this.radio_confirm.Size = new System.Drawing.Size(144, 39);
            this.radio_confirm.TabIndex = 9;
            this.radio_confirm.Text = "Conferma";
            this.radio_confirm.UseVisualStyleBackColor = true;
            this.radio_confirm.Click += new System.EventHandler(this.radio_confirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBlu);
            this.groupBox1.Controls.Add(this.radioGreen);
            this.groupBox1.Controls.Add(this.radioRed);
            this.groupBox1.Location = new System.Drawing.Point(69, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 83);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 58);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 81);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(462, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 123);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ROSSO",
            "VERDE",
            "GIALLO",
            "BLu"});
            this.comboBox1.Location = new System.Drawing.Point(426, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(749, 27);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(42, 388);
            this.vScrollBar1.TabIndex = 17;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.chiudiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apriToolStripMenuItem.Text = "Apri";
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvaToolStripMenuItem.Text = "Salva";
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chiudiToolStripMenuItem.Text = "Chiudi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radio_confirm);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_conferma);
            this.Controls.Add(this.chk_green);
            this.Controls.Add(this.chk_blu);
            this.Controls.Add(this.chk_red);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_red;
        private System.Windows.Forms.CheckBox chk_blu;
        private System.Windows.Forms.CheckBox chk_green;
        private System.Windows.Forms.Button btn_conferma;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.RadioButton radioBlu;
        private System.Windows.Forms.Button radio_confirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
    }
}


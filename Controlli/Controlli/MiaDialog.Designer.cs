
namespace Controlli
{
    partial class MiaDialog
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn2_green = new System.Windows.Forms.Button();
            this.btn_black = new System.Windows.Forms.Button();
            this.btn_blue = new System.Windows.Forms.Button();
            this.labelScelta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "RED";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2_green
            // 
            this.btn2_green.Location = new System.Drawing.Point(12, 12);
            this.btn2_green.Name = "btn2_green";
            this.btn2_green.Size = new System.Drawing.Size(70, 37);
            this.btn2_green.TabIndex = 1;
            this.btn2_green.Text = "GREEN";
            this.btn2_green.UseVisualStyleBackColor = true;
            this.btn2_green.Click += new System.EventHandler(this.btn2_green_Click);
            // 
            // btn_black
            // 
            this.btn_black.Location = new System.Drawing.Point(161, 140);
            this.btn_black.Name = "btn_black";
            this.btn_black.Size = new System.Drawing.Size(70, 37);
            this.btn_black.TabIndex = 2;
            this.btn_black.Text = "BLACK";
            this.btn_black.UseVisualStyleBackColor = true;
            this.btn_black.Click += new System.EventHandler(this.btn_black_Click);
            // 
            // btn_blue
            // 
            this.btn_blue.Location = new System.Drawing.Point(161, 12);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(70, 37);
            this.btn_blue.TabIndex = 3;
            this.btn_blue.Text = "BLUE";
            this.btn_blue.UseVisualStyleBackColor = true;
            this.btn_blue.Click += new System.EventHandler(this.btn_blue_Click);
            // 
            // labelScelta
            // 
            this.labelScelta.AutoSize = true;
            this.labelScelta.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScelta.Location = new System.Drawing.Point(23, 79);
            this.labelScelta.Name = "labelScelta";
            this.labelScelta.Size = new System.Drawing.Size(199, 28);
            this.labelScelta.TabIndex = 4;
            this.labelScelta.Text = "Scegli il tuo colore";
            // 
            // MiaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 191);
            this.Controls.Add(this.labelScelta);
            this.Controls.Add(this.btn_blue);
            this.Controls.Add(this.btn_black);
            this.Controls.Add(this.btn2_green);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiaDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MiaDialog";
            this.Activated += new System.EventHandler(this.MiaDialog_Activated);
            this.Deactivate += new System.EventHandler(this.MiaDialog_Deactivate);
            this.Load += new System.EventHandler(this.MiaDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn2_green;
        private System.Windows.Forms.Button btn_black;
        private System.Windows.Forms.Button btn_blue;
        private System.Windows.Forms.Label labelScelta;
    }
}
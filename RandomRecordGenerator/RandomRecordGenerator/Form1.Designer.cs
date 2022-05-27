namespace RandomRecordGenerator
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtConnectionString = new System.Windows.Forms.TextBox();
      this.txtHowMany = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnGO = new System.Windows.Forms.Button();
      this.lblStatus = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(234, 31);
      this.label1.TabIndex = 0;
      this.label1.Text = "Connection string:";
      // 
      // txtConnectionString
      // 
      this.txtConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtConnectionString.Location = new System.Drawing.Point(18, 49);
      this.txtConnectionString.Name = "txtConnectionString";
      this.txtConnectionString.Size = new System.Drawing.Size(886, 38);
      this.txtConnectionString.TabIndex = 1;
      this.txtConnectionString.Text = "server=.;database=Library;uid=sa;pwd=maggio";
      // 
      // txtHowMany
      // 
      this.txtHowMany.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtHowMany.Location = new System.Drawing.Point(267, 100);
      this.txtHowMany.Name = "txtHowMany";
      this.txtHowMany.Size = new System.Drawing.Size(159, 38);
      this.txtHowMany.TabIndex = 3;
      this.txtHowMany.Text = "10000";
      this.txtHowMany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(13, 103);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(233, 31);
      this.label2.TabIndex = 2;
      this.label2.Text = "Generate records:";
      // 
      // btnGO
      // 
      this.btnGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGO.Location = new System.Drawing.Point(467, 99);
      this.btnGO.Name = "btnGO";
      this.btnGO.Size = new System.Drawing.Size(96, 38);
      this.btnGO.TabIndex = 4;
      this.btnGO.Text = "GO!";
      this.btnGO.UseVisualStyleBackColor = true;
      this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblStatus.Location = new System.Drawing.Point(601, 103);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(93, 31);
      this.lblStatus.TabIndex = 5;
      this.lblStatus.Text = "Ready";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(916, 176);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.btnGO);
      this.Controls.Add(this.txtHowMany);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtConnectionString);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "RandomRecordGenerator for Library DB";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtConnectionString;
    private System.Windows.Forms.TextBox txtHowMany;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnGO;
    private System.Windows.Forms.Label lblStatus;
  }
}


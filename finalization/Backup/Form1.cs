using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.IO;

namespace Finalization2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdCreate;
		private System.Windows.Forms.Button cmdDereference;
		private System.Windows.Forms.Button cmdCleanup;
		private System.Windows.Forms.Button cmdClose;
		private System.Windows.Forms.Button cmdViewLog;
		private System.Windows.Forms.Button cmdClearLog;
		private System.Windows.Forms.CheckBox chkSuppressFinalize;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmdCreate = new System.Windows.Forms.Button();
			this.cmdDereference = new System.Windows.Forms.Button();
			this.cmdCleanup = new System.Windows.Forms.Button();
			this.cmdClose = new System.Windows.Forms.Button();
			this.cmdViewLog = new System.Windows.Forms.Button();
			this.cmdClearLog = new System.Windows.Forms.Button();
			this.chkSuppressFinalize = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// cmdCreate
			// 
			this.cmdCreate.Location = new System.Drawing.Point(16, 16);
			this.cmdCreate.Name = "cmdCreate";
			this.cmdCreate.Size = new System.Drawing.Size(200, 23);
			this.cmdCreate.TabIndex = 0;
			this.cmdCreate.Text = "Create an instance";
			this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
			// 
			// cmdDereference
			// 
			this.cmdDereference.Location = new System.Drawing.Point(16, 56);
			this.cmdDereference.Name = "cmdDereference";
			this.cmdDereference.Size = new System.Drawing.Size(200, 23);
			this.cmdDereference.TabIndex = 1;
			this.cmdDereference.Text = "Dereference instance";
			this.cmdDereference.Click += new System.EventHandler(this.cmdDereference_Click);
			// 
			// cmdCleanup
			// 
			this.cmdCleanup.Location = new System.Drawing.Point(16, 96);
			this.cmdCleanup.Name = "cmdCleanup";
			this.cmdCleanup.Size = new System.Drawing.Size(200, 23);
			this.cmdCleanup.TabIndex = 2;
			this.cmdCleanup.Text = "Close instance with cleanup";
			this.cmdCleanup.Click += new System.EventHandler(this.cmdCleanup_Click);
			// 
			// cmdClose
			// 
			this.cmdClose.Location = new System.Drawing.Point(16, 160);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(200, 23);
			this.cmdClose.TabIndex = 3;
			this.cmdClose.Text = "Close Application";
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// cmdViewLog
			// 
			this.cmdViewLog.Location = new System.Drawing.Point(16, 192);
			this.cmdViewLog.Name = "cmdViewLog";
			this.cmdViewLog.Size = new System.Drawing.Size(96, 23);
			this.cmdViewLog.TabIndex = 4;
			this.cmdViewLog.Text = "View Log in IE";
			this.cmdViewLog.Click += new System.EventHandler(this.cmdViewLog_Click);
			// 
			// cmdClearLog
			// 
			this.cmdClearLog.Location = new System.Drawing.Point(120, 192);
			this.cmdClearLog.Name = "cmdClearLog";
			this.cmdClearLog.Size = new System.Drawing.Size(96, 23);
			this.cmdClearLog.TabIndex = 5;
			this.cmdClearLog.Text = "Clear Log";
			this.cmdClearLog.Click += new System.EventHandler(this.cmdClearLog_Click);
			// 
			// chkSuppressFinalize
			// 
			this.chkSuppressFinalize.Location = new System.Drawing.Point(22, 120);
			this.chkSuppressFinalize.Name = "chkSuppressFinalize";
			this.chkSuppressFinalize.Size = new System.Drawing.Size(202, 23);
			this.chkSuppressFinalize.TabIndex = 6;
			this.chkSuppressFinalize.Text = "GC.SuppressFinalize() in Dispose()";
			this.chkSuppressFinalize.CheckedChanged += new System.EventHandler(this.chkSuppressFinalize_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(234, 231);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.chkSuppressFinalize,
																		  this.cmdClearLog,
																		  this.cmdViewLog,
																		  this.cmdClose,
																		  this.cmdCleanup,
																		  this.cmdDereference,
																		  this.cmdCreate});
			this.Name = "Form1";
			this.Text = "Finalization Sample";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}


		MiaClasse MioObj;

		private void cmdCreate_Click(object sender, System.EventArgs e)
		{
	        MioObj = new MiaClasse();
		}

		private void cmdDereference_Click(object sender, System.EventArgs e)
		{
			MioObj = null;
			// --> Nondeterministic finalization
		}

		private void cmdClose_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void cmdCleanup_Click(object sender, System.EventArgs e)
		{
			MioObj.Dispose();
			// --> Deterministic cleanup
			MioObj = null;
		}

		private void chkSuppressFinalize_CheckedChanged(object sender, System.EventArgs e)
		{
			MiaClasse.ExecSuppressFinalize = chkSuppressFinalize.Checked;
		}

		private void cmdClearLog_Click(object sender, System.EventArgs e)
		{
			try
			{
				File.Delete(Application.StartupPath + @"\LogFile.htm");
			}
			catch
			{}
			finally
			{
				StreamWriter w = File.AppendText(Application.StartupPath + @"\LogFile.htm");
				w.Close();
			}
        }

		private void cmdViewLog_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start(Application.StartupPath + @"\LogFile.htm");
			}
			catch
			{
				MessageBox.Show("File di Log non trovato.");
			}
		}
	}


	public class MiaClasse : IDisposable
	{
		public static bool ExecSuppressFinalize = false;
		
		public MiaClasse()
		{
			Log("MiaClasse.New()");
		}
	
		~MiaClasse()
		{
			Log("MiaClasse.Finalize()");
			CleanUp();
		}
	
		public void Dispose()
		{
			Log("MiaClasse.Dispose()");
			CleanUp();
			if (ExecSuppressFinalize)
				GC.SuppressFinalize(this);
		}

		protected virtual void CleanUp()
		{
			// TODO: Effettivo codice di cleanup
			Log("Cleanup for MiaClasse...");
		}

		private void Log(string logMessage)
		{
			StreamWriter w = File.AppendText(Application.StartupPath + @"\LogFile.htm");
			w.Write("{0}", DateTime.Now.ToString());
			w.Write(" - {0}", logMessage);
			w.WriteLine("<BR>");
			w.Flush();
			w.Close();
		}
	}
}

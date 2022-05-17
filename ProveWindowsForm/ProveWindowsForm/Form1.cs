using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProveWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salvaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png";
           // saveFileDialog1.FilterIndex = 2;  // PNG as default
            saveFileDialog1.Title = "Che vuoi?!";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
             
               // Bitmap bitmap = new Bitmap(this.Width, this.Height, PixelFormat.Format24bppRgb);
              // Graphics g = Graphics.FromImage(bitmap);
               // g.CopyFromScreen(new Point(this.Location.X + this.Location.X + 8, this.Location.Y + pictureBox1.Location.Y + 31), Point.Empty, pictureBox1.Size);
               // bitmap.Save(filename);
               // bitmap.Dispose();
                //g.Dispose();
            }

        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //cambio di colore
        private void chkBLu_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void chkRosso_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void chkVerde_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(radiobtnRight.Checked && radioBtnR.Checked)
            {
                MessageBox.Show("Risposta corretta scemo!");
            }
            else
                MessageBox.Show("Ci sono delle risposte sbagliate scemo!");
        }


        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //        private void radiobtnRight_CheckedChanged(object sender, EventArgs e)
        //        {
        //            MessageBox.Show("Risposta corretta scemo!");
        //;        }
    }
}

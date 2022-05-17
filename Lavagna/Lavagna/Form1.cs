using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavagna
{
    public partial class Form1 : Form
    {

        int oldX, oldY;
        Pen CurrentPen=new Pen(Color.Blue);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CurrentPen.Width = int.Parse(txtSpessore.Text);
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(CurrentPen, e.X, e.Y, oldX, oldY);
                oldX = e.X;
                oldY = e.Y;
                g.Dispose();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);
            g.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    private void btnSave_Click(object sender, EventArgs e)
    {
      saveFileDialog1.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png";
      saveFileDialog1.FilterIndex = 2;  // PNG as default
      saveFileDialog1.Title = "Chwe vuoi?!";
      if (saveFileDialog1.ShowDialog()==DialogResult.OK)
      {
        string filename = saveFileDialog1.FileName;
        Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height, PixelFormat.Format24bppRgb);
        Graphics g = Graphics.FromImage(bitmap);
        g.CopyFromScreen(new Point(this.Location.X+pictureBox1.Location.X+8, this.Location.Y + pictureBox1.Location.Y+31), Point.Empty, pictureBox1.Size);
        bitmap.Save(filename);
        bitmap.Dispose();
        g.Dispose();
      }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PenColor.ShowDialog() == DialogResult.OK)
            {
                CurrentPen = new Pen (PenColor.Color);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oldX = e.X;
                oldY = e.Y;
            }
        }
    }
}

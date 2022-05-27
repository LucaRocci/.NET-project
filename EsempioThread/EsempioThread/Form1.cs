using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsempioThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
        System.Threading.Thread t;
        private void button2_Click(object sender, EventArgs e)
        {
            ThreadStart ts =
                new ThreadStart(ApriForm);

            t = new System.Threading.Thread(ts);

            t.Start();
        }

        private void ApriForm()
        {
            try
            {
                Form2 f = new Form2();
                f.Show();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t.Suspend();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t.Resume();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            t.Abort();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsempioThread
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        long c;
        private void Form2_Activated(object sender, EventArgs e)
        {

            while (c < 1000000)
            {
                c++;
                label1.Text = c.ToString();
                Application.DoEvents();
            }

        }
    }
}

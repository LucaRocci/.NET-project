using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaAPP2804
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int o1 = int.Parse(textOp1.Text);
            int o2 = int.Parse(textOp2.Text);
            int sum = o1 + o2;
            MessageBox.Show("Risultato: "+sum.ToString());
        }
    }
}

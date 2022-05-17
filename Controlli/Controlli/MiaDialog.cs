using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlli
{
    public partial class MiaDialog : Form
    {
        public string scelta = " ";
        public string domanda = " ";
        public MiaDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scelta = "Rosso";
            this.Close();
        }

        private void btn_black_Click(object sender, EventArgs e)
        {
            scelta = "Nero";
            this.Close();
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            scelta = "Blu";
            this.Close();
        }

        private void btn2_green_Click(object sender, EventArgs e)
        {
            scelta = "Verde";
            this.Close();
        }

        private void MiaDialog_Load(object sender, EventArgs e)
        {
            labelScelta.Text = domanda;
        }

        private void MiaDialog_Activated(object sender, EventArgs e)          //atrtivato e deattivato//
        {
            BackColor = Color.AliceBlue;
        }

        private void MiaDialog_Deactivate(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }
    }
}

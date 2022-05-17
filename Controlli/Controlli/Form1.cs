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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chk_red_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_blu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_green_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_conferma_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Sei sicuro?", "RICHIESTA CONFERMA",MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            int count = 0;
           
            MiaDialog f = new MiaDialog();
            f.domanda = "Colore preferito";
            f.Show();  // diverso da show ShowDialog esegue solo quel form fino alla sua chiusura
           
            btn_change.Text=f.scelta;
            count++;
           // lblCount.Text= count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }


        //radio button 
        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void radioBlu_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void radio_confirm_Click(object sender, EventArgs e)
        {
            if (radioBlu.Checked)
            {
                MessageBox.Show("BLU");
            }
            if (radioGreen.Checked)
            {
                MessageBox.Show("GREEN");
            }
            if (radioRed.Checked)
            {
                MessageBox.Show("RED");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ROSSO")
            {
                this.BackColor = Color.Red;
            }
            if (comboBox1.Text == "GIALLO")
            {
                this.BackColor = Color.Yellow;        
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Opacity = vScrollBar1.Value / 100.0;
        }
    }
}

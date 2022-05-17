using System;
using System.Windows.Forms;

namespace CalcolatriceProva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private char operatore;
        public string primoNumero;
        public string secondoNumero;
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(btn9.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(btn0.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        // definizione numeri e operatori
        private void btnSomma_Click(object sender, EventArgs e)
        {
          //  textBox1.AppendText(btnSomma.Text);
            primoNumero = textBox1.Text;
            btnSomma.BackColor = System.Drawing.Color.Fuchsia;
            operatore = '+';
        }

        private void btnMeno_Click(object sender, EventArgs e)
        {
          //  textBox1.AppendText(btnMeno.Text);
            primoNumero= textBox1.Text;
            btnMeno.BackColor = System.Drawing.Color.Fuchsia;
            operatore = '-';
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
           // textBox1.AppendText(btnPer.Text);
            primoNumero = textBox1.Text;
            btnPer.BackColor = System.Drawing.Color.Fuchsia;
            operatore = '*';
        }

        private void btnDiviso_Click(object sender, EventArgs e)
        {
           // textBox1.AppendText(btnDiviso.Text);
            primoNumero = textBox1.Text;
            btnDiviso.BackColor = System.Drawing.Color.Fuchsia;
            operatore = '/';
        }

        private void btnVirgola_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(btnVirgola.Text);
        }

        private void btnUguale_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Casella vuota");
            }
            else
            {
                int l1 = primoNumero.Length;

              string Espressione = textBox1.Text;
            //    // string listaOperatori = "+-*/";
                for (int i = l1; i < textBox1.TextLength; i++)
                {
                    secondoNumero= ;
                }

                //     //while ("+-*/".Contains(textBox1.Text) /*|| .Length != 1*/);
                MessageBox.Show(primoNumero.ToString()+operatore+secondoNumero.ToString());

       
            }
        }
    }
}

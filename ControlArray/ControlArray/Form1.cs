using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    MessageBox.Show("hai scritto: " + txt1.Text);  //txt1 è la textbox 

            //    txt1.Text = "MIAO";

            try
            {
                int Quanti = int.Parse(txt1.Text);

                for (int i = 0; i < Quanti; i++)
                {
                    Button b;
                    b = new Button();   //è un oggetto
                    b.Location = new Point(200 + (10 * i), 200 + (30 * i));
                    b.Name = "NuovoBottone " + i.ToString();
                    b.Text = "NUOVO BOTTONE " + i.ToString();
                    b.Size = new Size(300, 30);
                    this.Controls.Add(b);     //crea un nuovo botton
                    b.Click += new System.EventHandler(this.btnNuovo_Click);  //genera un nuovo evento 
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Valore non valido");
            }

            //btnesegui1.Enabled = false;   //disattivo il tasto dopo il primo tocco 
            //btnesegui1.Visible = false;   // lo rimuove 
        }
        private void btnNuovo_Click(object sender,EventArgs e)     //pressione sul nuovo tasto
        {
            Button b = (Button)sender;   //operazione di casting
            MessageBox.Show("hai premuto: " + b.Name);


        }

        private void txt1_KeyDown(object sender, KeyEventArgs e)  //tasto premuto 
        {
            System.Diagnostics.Debug.WriteLine("tasto premuto: "+e.KeyCode.ToString());
        }
    }
}

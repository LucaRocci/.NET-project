using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessoDati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //server indirizzo ip o nome macchina  nome DB / nome  e  password 
            string ConnectionString = "server=BSI21-23-22;database=Library;uid=sa;pwd=susa2002";
            SqlConnection cnn = new SqlConnection();
            //SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.ConnectionString = ConnectionString;
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT TOP 100 * FROM member";
            SqlDataReader dr= cmd.ExecuteReader();  //

            StringBuilder sb = new StringBuilder();
            while (dr.Read())
            {
             //textBox1.Text +=  dr["lastname"].ToString();
             //   textBox1.Text += "\r\n";
                sb.Append(dr["lastname"].ToString());
                sb.Append("\r\n");
               // Application.DoEvents();
            }
            textBox1.Text = sb.ToString();

            dr.Close();
            cnn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //server indirizzo ip o nome macchina  nome DB / nome  e  password 
            string ConnectionString = "server=BSI21-23-22;database=Library;uid=sa;pwd=susa2002";
            //SqlConnection cnn = new SqlConnection();
            SqlConnection cnn  = new SqlConnection(ConnectionString);
           // cnn.ConnectionString = ConnectionString;
          
            SqlCommand cmd = cnn.CreateCommmand();
            cmd.CommandText= "INSERT title "
            cmd.Open();
        }
    }
}

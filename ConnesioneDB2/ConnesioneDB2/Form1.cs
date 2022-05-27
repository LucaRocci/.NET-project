using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnesioneDB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titolo = textTitolo.Text;
            string autore = textAutore.Text;
            //server indirizzo ip o nome macchina  nome DB / nome  e  password 
            string ConnectionString = "server=BSI-2123-22;database=Library;uid=sa;pwd=susa2002";
           // SqlConnection cnn = new SqlConnection();
            SqlConnection cnn = new SqlConnection(ConnectionString);
            //   cnn.ConnectionString = ConnectionString;
      
            SqlCommand cmd = cnn.CreateCommand();
            titolo.Replace("'", "''");
            autore.Replace("'", "''");   //necassario per la corretta esecuzione del comando SQL

            cmd.CommandText = "INSERT title (title,author) VALUES (";
            cmd.CommandText += "'" + titolo + "',";
            cmd.CommandText += "'" + autore + "')";

            cnn.Open();
            int records = cmd.ExecuteNonQuery();  //

            cnn.Close();

        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = Creaconnssione("SELECT COUNT(*) FROM title");
            cmd.Connection.Open();
            int records = (int)cmd.ExecuteScalar();
            textBox1.Text=records.ToString();
            cmd.Connection.Close();
        }

        private SqlCommand Creaconnssione(string cmdtext)
        {
            //server indirizzo ip o nome macchina  nome DB / nome  e  password 
            string ConnectionString = "server=BSI-2123-22;database=Library;uid=sa;pwd=susa2002";
            // SqlConnection cnn = new SqlConnection();
            SqlConnection cnn = new SqlConnection(ConnectionString);
            //   cnn.ConnectionString = ConnectionString;
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = cmdtext;
            return cmd;
        }
        Form2 f = null;
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] photo = GetPhoto(@"Z:\WINDOWS\logo.png");

            SqlConnection connection = new SqlConnection("server = BSI-2123-22; database = Library; uid = sa; pwd = susa2002");

                SqlCommand command = new SqlCommand(
                  "UPDATE member SET photograph=@Photo" +" WHERE member_no=1" , connection);

            command.Parameters.Add("@Photo",
                SqlDbType.Image, photo.Length).Value = photo;

            connection.Open();
            command.ExecuteNonQuery();
        }
        public static byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();

        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=BSI-2123-22;database=Library;uid=sa;pwd=susa2002";
            string estraiDati = " SELECT * FROM member"+" WHERE member_no=1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(estraiDati, ConnectionString);
            da.Fill(dt);
            byte[] img=(byte[])dt.Rows[0]["photograph"];
            Bitmap bmp = (Bitmap)Image.FromStream(new MemoryStream(img));
            pictureBox1.Image = bmp;
        }
    }
}

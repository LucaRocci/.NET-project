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

namespace ConnesioneDB2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlDataAdapter da;
        private void btnLeggi_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=BSI-2123-22;database=Library;uid=sa;pwd=susa2002";
            string estraiDati = " SELECT * FROM title";
             dt = new DataTable();
            da = new SqlDataAdapter(estraiDati,ConnectionString);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
          
            da.Fill(dt);
            dgTitles.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.Update(dt);

        }
    }
}

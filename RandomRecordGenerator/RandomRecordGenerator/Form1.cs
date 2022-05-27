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

namespace RandomRecordGenerator
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    DataTable dtStartData = new DataTable();
    private void btnGO_Click(object sender, EventArgs e)
    {
      string SQLstr="SELECT TOP 100 * FROM member m";
      SQLstr += " INNER JOIN adult a ON a.member_no=m.member_no";
      SqlDataAdapter da = new SqlDataAdapter(SQLstr, txtConnectionString.Text);
      da.Fill(dtStartData);

      SqlConnection cnn = new SqlConnection(txtConnectionString.Text);
      cnn.Open();

      DateTime StartTime = DateTime.Now;

      int HowMany = int.Parse(txtHowMany.Text);
      for (int i = 0; i < HowMany; i++)
      {
        lblStatus.Text = i.ToString();
        Application.DoEvents();
        GenerateRandomRecord(cnn);
      }

      DateTime EndTime = DateTime.Now;
      TimeSpan ElapsedTime = EndTime.Subtract(StartTime);
      System.Diagnostics.Debug.WriteLine(ElapsedTime.TotalMilliseconds.ToString());

      cnn.Close();
    }

    private void GenerateRandomRecord(SqlConnection cnn)
    {
      string lastname = (string)GetRandomValue("lastname");
      string firstname = (string)GetRandomValue("firstname");
      string middleinitial = (string)GetRandomValue("middleinitial");
      string street = (string)GetRandomValue("street");
      string city = (string)GetRandomValue("city");
      string state = (string)GetRandomValue("state");
      string zip = (string)GetRandomValue("zip");
      string phone_no = (string)GetRandomValue("phone_no");
      DateTime expr_date = (DateTime)GetRandomValue("expr_date");

      SqlTransaction t = cnn.BeginTransaction();

      string SQLstr1="INSERT member (lastname,firstname,middleinitial)";
      SQLstr1+=" VALUES ('" + lastname.Replace("'","''") + "',";
      SQLstr1+=" '" + firstname.Replace("'","''") + "',";
      SQLstr1+=" '" + middleinitial.Replace("'","''") + "')";
      SQLstr1+=" SELECT @@IDENTITY";
      SqlCommand cmd1 = cnn.CreateCommand();
      cmd1.Transaction = t;
      cmd1.CommandText=SQLstr1;

      int member_no=int.Parse(cmd1.ExecuteScalar().ToString());

      string SQLstr2="INSERT adult (member_no,street,city,state,zip,phone_no,expr_date)";
      SQLstr2+=" VALUES (" + member_no.ToString() + ",";
      SQLstr2+=" '" + street.Replace("'","''") + "',";
      SQLstr2+=" '" + city.Replace("'","''") + "',";
      SQLstr2+=" '" + state.Replace("'","''") + "',";
      SQLstr2+=" '" + zip.Replace("'","''") + "',";
      SQLstr2+=" '" + phone_no.Replace("'","''") + "',";
      SQLstr2+=" '" + expr_date.ToString("yyyy-MM-dd") + "')";
      SqlCommand cmd2 = cnn.CreateCommand();
      cmd2.Transaction = t; 
      cmd2.CommandText = SQLstr2;

      cmd2.ExecuteNonQuery();

      t.Commit();
    }
    
    Random rnd = new Random();      
    private object GetRandomValue(string fieldname)
    {
      return dtStartData.Rows[(int)rnd.Next(0, 100)][fieldname];
    }
  }
}

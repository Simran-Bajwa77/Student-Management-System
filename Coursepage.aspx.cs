using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Coursepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void ButCourse_Click(object sender, EventArgs e)
    {
        

            string mainconn = ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[course](Cname,Duration,CFees) values (@Cname,@Duration,@CFees)";
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            sqlcom.Parameters.AddWithValue("@Cname", TxtCoursename.Text);
            sqlcom.Parameters.AddWithValue("@Duration", TxtDuration.Text);
            sqlcom.Parameters.AddWithValue("@CFees", TxtFees.Text);
            sqlcom.ExecuteNonQuery();
            Labelmsg.Text = "The Course " + TxtCoursename.Text + " Is Inserted Successfully..";
            TxtCoursename.Text = "";
            TxtDuration.Text = "";
            TxtFees.Text = "";
            sqlconn.Close();
        
    }
}
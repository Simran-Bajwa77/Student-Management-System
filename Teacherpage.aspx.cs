using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Teacherpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
          
    }
    protected void BtnTeacher_Click(object sender, EventArgs e)
    {
        
            string mainconn = ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[teacher] (Tname,Temail,Tphone,Tcourse,Tqualification) values (@Tname,@Temail,@Tphone,@Tcourse,@Tqualification)";
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            sqlcom.Parameters.AddWithValue("@Tname", TxtTeachername.Text);
            sqlcom.Parameters.AddWithValue("@Temail", TxtEmail.Text);
            sqlcom.Parameters.AddWithValue("@Tphone", TxtPhone.Text);
            sqlcom.Parameters.AddWithValue("@Tcourse", DDLCourse.SelectedItem.Text);
            sqlcom.Parameters.AddWithValue("@Tqualification", TxtQualification.Text);
            sqlcom.ExecuteNonQuery();
            Labelmsg.Text = "The details of " + TxtTeachername.Text + " are Inserted Successfully..";
            TxtTeachername.Text = "";
            TxtEmail.Text = "";
            TxtPhone.Text = "";
            TxtQualification.Text = "";
            sqlconn.Close();
        
    }
}
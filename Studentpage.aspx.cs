using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Studentpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void BtnStudent_Click(object sender, EventArgs e)
    {
       
            string mainconn = ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[Student] (Stfname,Stlname,StFathername,StFatherphone,StMothername,StEmail,Stphone,Coursejoin,CourseFees,FirstInstallment,FeesDue,Address) values (@Stfname,@Stlname,@StFathername,@StFatherphone,@StMothername,@StEmail,@Stphone,@Coursejoin,@CourseFees,@FirstInstallment,@FeesDue,@Address)";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Stfname", TxtStFname.Text);
            sqlcomm.Parameters.AddWithValue("@Stlname", TxtStLname.Text);
            sqlcomm.Parameters.AddWithValue("@StFathername", TxtFathername.Text);
            sqlcomm.Parameters.AddWithValue("@StFatherphone", TxtFatherphone.Text);
            sqlcomm.Parameters.AddWithValue("@StMothername", Txtmothername.Text);
            sqlcomm.Parameters.AddWithValue("@StEmail", TxtStEmail.Text);
            sqlcomm.Parameters.AddWithValue("@Stphone", TxtPhone.Text);
            sqlcomm.Parameters.AddWithValue("@Coursejoin", DDLCourseName.SelectedItem.Text);
            sqlcomm.Parameters.AddWithValue("@CourseFees", LabCourseFees.Text);
            sqlcomm.Parameters.AddWithValue("@FirstInstallment", TxtCourseInstallment.Text);
            sqlcomm.Parameters.AddWithValue("@FeesDue", LabDueFees.Text);
            sqlcomm.Parameters.AddWithValue("@Address", Txtaddress.Text);
            sqlcomm.ExecuteNonQuery();
            Lblmsg.Text = "The Student " + TxtStFname.Text + " Is Inserted . ";






            sqlconn.Close();
        

    }
   

    protected void DDLCourseName_SelectedIndexChanged(object sender, EventArgs e)
    {
        string mainconn = ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(mainconn);
        string sqlquery = "select * from [dbo].[course] where Cname=@Cname";
        sqlconn.Open();
        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
        sqlcomm.Parameters.AddWithValue("@Cname", DDLCourseName.SelectedItem.Text);
        SqlDataReader sdr = sqlcomm.ExecuteReader();
        while(sdr.Read())
        {
            LabCourseFees.Text = sdr["CFees"].ToString();
        }
        sqlconn.Close();

    }
    protected void TxtCourseInstallment_TextChanged(object sender, EventArgs e)
    {
        int balance = Convert.ToInt32(LabCourseFees.Text) - Convert.ToInt32(TxtCourseInstallment.Text);
        LabDueFees.Text = balance.ToString();
    }
}
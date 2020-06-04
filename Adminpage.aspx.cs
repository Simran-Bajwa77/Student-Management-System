using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Adminpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButSubmit_Click(object sender, EventArgs e)
    {
        string mainconn = ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(mainconn);
        string sqlquery = "select * from " + DropDownList1.SelectedItem.Text;
        sqlconn.Open();
        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
        SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
        DataTable dt = new DataTable();
        sda.Fill(dt);

        if (DropDownList1.SelectedItem.Text == "course")
        {
            Gdcourse.Visible = true;
            Gdstudent.Visible = false;
            Gdteacher.Visible = false;
            Gdcourse.DataSource = dt;
            Gdcourse.DataBind();
        }
        else if (DropDownList1.SelectedItem.Text == "Student")
        {
            Gdstudent.Visible = true;
            Gdcourse.Visible = false;
            Gdteacher.Visible = false;
            Gdstudent.DataSource = dt;
            Gdstudent.DataBind();
        }
        else
        {
            Gdstudent.Visible = false;
            Gdcourse.Visible = false;
            Gdteacher.Visible = true;
            Gdteacher.DataSource = dt;
            Gdteacher.DataBind();
        }


        sqlconn.Close();
    }
    protected void Gdcourse_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        Gdcourse.EditIndex = -1;
    }
    protected void Gdcourse_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = Gdcourse.Rows[e.RowIndex];

        int courseid = Convert.ToInt32(Gdcourse.DataKeys[e.RowIndex].Values[0]);
        string Cname = (row.Cells[2].Controls[0] as TextBox).Text;
        string Duration = (row.Cells[3].Controls[0] as TextBox).Text;
        string CFees = (row.Cells[4].Controls[0] as TextBox).Text;

        string mainconn = ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(mainconn);
        string sqlquery = "update course set Cname=@Cname,Duration=@Duration,CFees=@CFees where Cid=@Cid";
        sqlconn.Open();
        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
        sqlcomm.Parameters.AddWithValue("@Cid", courseid);
        sqlcomm.Parameters.AddWithValue("@Cname", Cname);
        sqlcomm.Parameters.AddWithValue("@Duration", Duration);
        sqlcomm.Parameters.AddWithValue("@CFees", CFees);
        sqlcomm.ExecuteNonQuery();
        sqlconn.Close();

    }
    protected void Gdcourse_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Gdcourse.EditIndex = e.NewEditIndex;
    }
    protected void Gdcourse_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int courseid = Convert.ToInt32(Gdcourse.DataKeys[e.RowIndex].Values[0]);

        string mainconn = ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(mainconn);
        string sqlquery = "delete from course where Cid=@Cid";
        sqlconn.Open();
        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
        sqlcomm.Parameters.AddWithValue("@Cid", courseid);
        sqlcomm.ExecuteNonQuery();
        sqlconn.Close();

    }

    protected void Gdstudent_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        Gdstudent.EditIndex = -1;
    }
    protected void Gdstudent_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = Gdstudent.Rows[e.RowIndex];

        int Stid = Convert.ToInt32(Gdstudent.DataKeys[e.RowIndex].Values[0]);
        string Stfname = (row.Cells[2].Controls[0] as TextBox).Text;
        string Stlname = (row.Cells[3].Controls[0] as TextBox).Text;
        string StFathername = (row.Cells[4].Controls[0] as TextBox).Text;
        string StFatherphone = (row.Cells[5].Controls[0] as TextBox).Text;
        string StMothername = (row.Cells[6].Controls[0] as TextBox).Text;
        string StEmail = (row.Cells[7].Controls[0] as TextBox).Text;
        string Stphone = (row.Cells[8].Controls[0] as TextBox).Text;
        string Coursejoin = (row.Cells[9].Controls[0] as TextBox).Text;
        string CourseFees = (row.Cells[10].Controls[0] as TextBox).Text;
        string FirstInstallment = (row.Cells[11].Controls[0] as TextBox).Text;
        string FeesDue = (row.Cells[12].Controls[0] as TextBox).Text;
        string Address = (row.Cells[13].Controls[0] as TextBox).Text;

        string mainconn = ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(mainconn);
        string sqlquery = "update Student set Stfname=@Stfname,Stlname=@Stlname,StFathername=@StFathername,StFatherphone=@StFatherphone,StMothername=@StMothername,StEmail=@StEmail,Stphone=@Stphone,Coursejoin=@Coursejoin,CourseFees=@CourseFees,FirstInstallment=@FirstInstallment,FeesDue=@FeesDue,Address=@Address where Stid=@Stid";
        sqlconn.Open();
        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
        sqlcomm.Parameters.AddWithValue("@Stid", Stid);
        sqlcomm.Parameters.AddWithValue("@Stfname", Stfname);
        sqlcomm.Parameters.AddWithValue("@Stlname", Stlname);
        sqlcomm.Parameters.AddWithValue("@StFathername", StFathername);
        sqlcomm.Parameters.AddWithValue("@StFatherphone", StFatherphone);
        sqlcomm.Parameters.AddWithValue("@StMothername", StMothername);
        sqlcomm.Parameters.AddWithValue("@StEmail", StEmail);
        sqlcomm.Parameters.AddWithValue("@Stphone", Stphone);
        sqlcomm.Parameters.AddWithValue("@Coursejoin", Coursejoin);
        sqlcomm.Parameters.AddWithValue("@CourseFees", CourseFees);
        sqlcomm.Parameters.AddWithValue("@FirstInstallment", FirstInstallment);
        sqlcomm.Parameters.AddWithValue("@FeesDue", FeesDue);
        sqlcomm.Parameters.AddWithValue("@Address", Address);
        sqlcomm.ExecuteNonQuery();
        sqlconn.Close();
    }
    protected void Gdstudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int Stid = Convert.ToInt32(Gdstudent.DataKeys[e.RowIndex].Values[0]);

        string mainconn = ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(mainconn);
        string sqlquery = "delete from Student where Stid=@Stid";
        sqlconn.Open();
        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
        sqlcomm.Parameters.AddWithValue("@Stid", Stid);
        sqlcomm.ExecuteNonQuery();
        sqlconn.Close();
    }
    protected void Gdstudent_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Gdstudent.EditIndex = e.NewEditIndex;
    }
    protected void Gdteacher_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        Gdteacher.EditIndex = -1;
    }
    protected void Gdteacher_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = Gdteacher.Rows[e.RowIndex];

        int Tid = Convert.ToInt32(Gdteacher.DataKeys[e.RowIndex].Values[0]);
        string Tname = (row.Cells[2].Controls[0] as TextBox).Text;
        string Temail = (row.Cells[3].Controls[0] as TextBox).Text;
        string Tphone = (row.Cells[4].Controls[0] as TextBox).Text;
        string Tcourse = (row.Cells[5].Controls[0] as TextBox).Text;
        string Tqualification = (row.Cells[6].Controls[0] as TextBox).Text;

        string mainconn = ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(mainconn);
        string sqlquery = "update teacher set Tname=@Tname,Temail=@Temail,Tphone=@Tphone,Tcourse=@Tcourse,Tqualification=@Tqualification where Tid=@Tid";
        sqlconn.Open();
        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
        sqlcomm.Parameters.AddWithValue("@Tid", Tid);
        sqlcomm.Parameters.AddWithValue("@Tname", Tname);
        sqlcomm.Parameters.AddWithValue("@Temail", Temail);
        sqlcomm.Parameters.AddWithValue("@Tphone", Tphone);
        sqlcomm.Parameters.AddWithValue("@Tcourse", Tcourse);
        sqlcomm.Parameters.AddWithValue("@Tqualification", Tqualification);
        sqlcomm.ExecuteNonQuery();
        sqlconn.Close();
    }
    protected void Gdteacher_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int Tid = Convert.ToInt32(Gdteacher.DataKeys[e.RowIndex].Values[0]);

        string mainconn = ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(mainconn);
        string sqlquery = "delete from teacher where Tid=@Tid";
        sqlconn.Open();
        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
        sqlcomm.Parameters.AddWithValue("@Tid", Tid);
        sqlcomm.ExecuteNonQuery();
        sqlconn.Close();
    }
    protected void Gdteacher_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Gdteacher.EditIndex = e.NewEditIndex;
    }
}














using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SMS : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Adminname"] != null)
        {
            Labeluserlogin.Text = Session["Adminname"].ToString();
        }
        else 
        {
            Response.Redirect("Homepage.aspx");
        
        }
    }
    protected void LinkCourse_Click(object sender, EventArgs e)
    {
        Response.Redirect("Coursepage.aspx");
    }
    protected void LinkTeacher_Click(object sender, EventArgs e)
    {
        Response.Redirect("Teacherpage.aspx");
    }
    protected void LinkStudent_Click(object sender, EventArgs e)
    {
        Response.Redirect("Studentpage.aspx");
    }
    protected void Linklogout_Click(object sender, EventArgs e)
    {
        HttpContext.Current.Session.Abandon();
        Response.Redirect("Homepage.aspx");
    }
    protected void LinkAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Adminpage.aspx");
    
    }
}

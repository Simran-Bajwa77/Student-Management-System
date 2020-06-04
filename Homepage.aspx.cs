using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        if (TxtadminId.Text == "Admin" && TxtpasswordAdmin.Text == "Password123")
        {


            Session["Adminname"] = "WELCOME  " +  TxtadminId.Text;
            Response.Redirect("Adminpage.aspx");

        }
        else 
        {
            Lblmsg.Text = "*****INVALID LOGIN DETAILS*****";
        
        }
    }
}
<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="none" CodeFile="Homepage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style13 {
            width: 332px;
            height: 64px;
        }
        .auto-style14 {
            height: 64px;
            width: 466px;
        }
        .auto-style15 {
            width: 332px;
            height: 60px;
        }
        .auto-style16 {
            height: 60px;
            width: 466px;
        }
    
        #form1 {
            height: 745px;
        }
    
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center style="height: 744px; width: 1388px">
      <h1 style="border: thick ridge navy; margin: 20px; padding: 20px; font-family: 'Arial Rounded MT Bold'; font-size: 100px; font-weight: bolder; font-style: normal; font-variant: normal; text-transform: capitalize; color: navy; line-height: normal; background-color: ghostwhite; background-image: url('IMAGES/images (5).jpg');">STUDENT MANAGEMENT SYSTEM </h1>  
        <img src="IMAGES/admin.png" style="border-style: inset; border-width: medium; border-color: navy; height: 173px; width: 220px" /><br />
        &nbsp;<div style="border: thin solid navy; background-color:ghostwhite; height:215px; width:431px; border-collapse: collapse; border-spacing: 20px;">
        <table border="1" style="border: thin ridge navy; height: 215px; width: 431px; background-color:gainsboro;">
            <tr>
                <td class="auto-style13" style="font-family: 'Arial Rounded MT Bold'; font-size: x-large; color: navy; background-color: ghostwhite; font-weight: bolder;">ADMIN USER ID</td>
                <td class="auto-style14" style="background-color: ghostwhite"><asp:TextBox ID="TxtadminId" runat="server" Width="198px" Height="23px" style="margin-left: 0px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style13" style="font-family: 'Arial Rounded MT Bold'; font-size: x-large; color: navy; background-color: ghostwhite; font-weight: bolder;">PASSWORD</td>
                <td class="auto-style14" style="background-color: ghostwhite"><asp:TextBox ID="TxtpasswordAdmin" runat="server" TextMode="Password" Width="198px" style="margin-left: 0px" Height="23px"></asp:TextBox></td>
             </tr>
            <tr>
                <td class="auto-style15" style="background-color: ghostwhite"><asp:Button ID="btnlogin" runat="server" Text="LOGIN" OnClick="btnlogin_Click" BorderColor="Navy" BorderStyle="Inset" Font-Bold="True" Font-Size="X-Large" ForeColor="Navy" Width="127px"></asp:Button></td>
                <td class="auto-style16" style="background-color: ghostwhite"><asp:Label ID="Lblmsg" runat="server" ForeColor="MediumVioletRed" Font-Bold="True" Font-Size="Medium"></asp:Label></td>

            </tr>




        </table>
            </div>
    </center>

    </div>
        
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.master" UnobtrusiveValidationMode="none" AutoEventWireup="true" CodeFile="Coursepage.aspx.cs" Inherits="Coursepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 style="border-style: double; border-width: medium; font-family: 'Arial Rounded MT Bold'; font-size: xx-large; font-weight: bolder; color: firebrick; text-transform: capitalize;">THIS PAGE REPRESENTS DETAILS OF THE COURSES.....</h1>
    <div style="height: 175px; width: 500px;">
    <table border="1" style="height: 175px; width: 500px" >
        <tr>
            <td style="font-family: 'Arial Rounded MT Bold'; font-size: large; font-weight: bolder">Course Name</td>
            <td style="width: 549px">
            <asp:TextBox ID="TxtCoursename" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 31px; font-family: 'Arial Rounded MT Bold'; font-size: large; font-weight: bolder;">Course Duration</td>
            <td style="height: 31px; width: 549px"><asp:TextBox ID="TxtDuration" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Arial Rounded MT Bold'; font-size: large; font-weight: bolder; height: 33px;">Course Fees</td>
            <td style="width: 549px; height: 31px;"><asp:TextBox ID="TxtFees" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            
            <td style="height: 31px"><asp:Button ID="ButCourse" runat="server" Text="Insert New Course" Height="39px" OnClick="ButCourse_Click" Width="274px" BorderColor="Firebrick" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Names="Arial Rounded MT Bold" Font-Size="Larger" ForeColor="Firebrick" BackColor="White" /></td>
            <td style="width: 549px; height: 31px">
            <asp:Label ID="Labelmsg" runat="server" ForeColor="SpringGreen" Font-Bold="True" Font-Names="Arial Rounded MT Bold"></asp:Label></td>
        </tr>





    </table>
        </div>

</asp:Content>


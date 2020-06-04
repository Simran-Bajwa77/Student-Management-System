<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.master" UnobtrusiveValidationMode="none" AutoEventWireup="true" CodeFile="Teacherpage.aspx.cs" Inherits="Teacherpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 style="border-style: double; border-width: medium; font-family: 'Arial Rounded MT Bold'; font-size: xx-large; font-weight: bold; font-style: normal; text-transform: capitalize; color: crimson">THIS  PAGE REPRESENTS DETAILS OF THE TEACHERS..... </h1>
    <div style="width: 490px; height: 346px; font-family: 'Arial Rounded MT Bold'; font-size: large; font-weight: bolder;">
        <table border="1" ;  style="height: 346px; width: 490px;">
            <tr>
                <td style="width: 237px; height: 47px">Teacher Name</td>
                <td style="width: 356px; height: 49px"><asp:TextBox ID="TxtTeachername" runat="server" Width="201px"></asp:TextBox>
                </td> 
            </tr>
            <tr>
                <td style="width: 237px; height: 47px">Teacher Email</td>
                <td style="width: 356px; height: 49px">
                    <asp:TextBox ID="TxtEmail" runat="server" Width="201px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TxtEmail" ErrorMessage="*Enter Correct format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 237px; height: 47px">Teacher Phone Number</td>
                <td style="width: 356px; height: 49px">
                    <asp:TextBox ID="TxtPhone" runat="server" Width="201px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtPhone" ErrorMessage="*Enter correct format" ForeColor="Red" ValidationExpression="\d{10}" Display="Dynamic"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 237px; height: 47px;">Teacher Course</td>
                <td style="width: 356px; height: 49px;">
                    <asp:DropDownList ID="DDLCourse" runat="server" DataSourceID="SqlDataSource1" AppendDataBoundItems="true" DataTextField="Cname" DataValueField="Cname">
                        <asp:ListItem Value="0" Text="SELECT COURSES"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:My Connection %>" SelectCommand="SELECT [Cname] FROM [course]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 237px; height: 47px">Qualification&nbsp;&nbsp;&nbsp; </td>
                <td style="width: 356px; height: 49px">
                    <asp:TextBox ID="TxtQualification" runat="server" Width="201px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 47px; width: 237px;">
                    &nbsp;<asp:Button ID="BtnTeacher" runat="server" Text="Insert" Width="177px" OnClick="BtnTeacher_Click" BackColor="White" BorderColor="Crimson" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Names="Arial Rounded MT Bold" Font-Size="Large" ForeColor="Crimson" /></td>
                <td style="height: 49px; width: 356px;">
                    <asp:Label ID="Labelmsg" runat="server" ForeColor="SpringGreen" Font-Bold="True" Font-Names="Arial Rounded MT Bold" Font-Size="Large"></asp:Label></td>
            </tr>

        </table>


    </div>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.master" UnobtrusiveValidationMode="none" AutoEventWireup="true" CodeFile="Studentpage.aspx.cs" Inherits="Studentpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 style="font-family: 'Arial Rounded MT Bold'; font-size: xx-large; font-weight: bolder; text-transform: capitalize; color: olive; border-style: double; border-width: medium">THIS PAGE REPRESENTS STUDENTS DETAILS.....</h1>
    <div style="height: 500px; width: 500px;">
        <table border="1" style="width: 500px; height:500px;font-family: 'Arial Rounded MT Bold'; font-size: large; font-weight: bolder; margin-left: 0px; margin-right: 0px; margin-bottom: 0px;">
            <tr>
                <td style="width: 351px">Student First Name</td>
                <td style="width: 291px">
                    <asp:TextBox ID="TxtStFname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 351px">Student Last Name</td>
                <td style="width: 291px">
                    <asp:TextBox ID="TxtStLname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 351px">Father's Name</td>
                <td style="width: 291px">
                    <asp:TextBox ID="TxtFathername" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 351px">Father's Phone Number</td>
                <td style="width: 291px">
                    <asp:TextBox ID="TxtFatherphone" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TxtFatherphone" ErrorMessage="*enter correct format" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 351px">Mother's Name</td>
                <td style="width: 291px">
                    <asp:TextBox ID="Txtmothername" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 55px; width: 351px">Student Email</td>
                <td style="width: 291px; height: 55px;">
                    <asp:TextBox ID="TxtStEmail" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TxtStEmail" ErrorMessage="*Enter correct email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 351px; height: 56px;">Student Phone Number</td>
                <td style="width: 291px; height: 56px;">
                    <asp:TextBox ID="TxtPhone" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TxtPhone" ErrorMessage="*Enter correct format" ForeColor="Red" ValidationExpression="\d{10}" Display="Dynamic"></asp:RegularExpressionValidator>
                </td>

                </tr>
            <tr>
                <td style="width: 351px">Course Name</td>
                <td style="width: 291px">
                    <asp:DropDownList ID="DDLCourseName" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" AppendDataBoundItems="true" DataTextField="Cname" DataValueField="Cname" OnSelectedIndexChanged="DDLCourseName_SelectedIndexChanged">
                    <asp:ListItem Value="0" Text="SELECT COURSE"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:My Connection %>" SelectCommand="SELECT [Cname] FROM [course]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 351px">
                    Course Fees
                </td>
                <td style="width: 291px">
                    <asp:Label ID="LabCourseFees" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 351px">Installment</td>
                <td style="width: 291px">
                    <asp:TextBox ID="TxtCourseInstallment" runat="server" AutoPostBack="true" OnTextChanged="TxtCourseInstallment_TextChanged"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 351px">Fees Due</td>
                <td style="width: 291px">
                    <asp:Label ID="LabDueFees" runat="server" Text=""></asp:Label></td>
            </tr>
            
             <tr>
            
                <td style="width: 351px">Address</td>
                <td style="width: 291px">
                    <asp:TextBox ID="Txtaddress" runat="server"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td style="height: 58px; width: 351px;">
                    <asp:Button ID="BtnStudent" runat="server" Text="INSERT RECORD" OnClick="BtnStudent_Click" BorderColor="Olive" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Names="Arial Rounded MT Bold" Font-Size="Larger" ForeColor="Olive" /></td>
                <td style="width: 291px; height: 58px">
                    <asp:Label ID="Lblmsg" runat="server" ForeColor="SpringGreen" Font-Bold="True" Font-Names="Arial Rounded MT Bold" Font-Size="Larger"></asp:Label></td>
            </tr>
        </table>

    </div>

</asp:Content>


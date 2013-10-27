<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Account.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label runat="server" Text="Kullanıcı Adı" />
            </td>
            <td>
                <asp:TextBox ID="username" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" Text="Şifre" />
            </td>
            <td>
                <asp:TextBox ID="password" runat="server" TextMode="Password" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" Text="Şifre (Tekrar)" />
            </td>
            <td>
                <asp:TextBox ID="passwordRepeat" runat="server" TextMode="Password" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" Text="E-Mail" />
            </td>
            <td>
                <asp:TextBox ID="email" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="errMsg" runat="server" ForeColor="DarkRed" />
            </td>
            <td align="right">
                <asp:Button ID="register" runat="server" Text="Kaydet" OnClick="register_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td align="center">
                <asp:LinkButton ID="newUser" runat="server" Text="Yeni Kullanıcı" OnClick="newUser_Click" />
            </td>
        </tr>
        <tr>
            <td />
        </tr>
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
                <asp:Label ID="errMsg" runat="server" Text="Hatalı Kullanıcı Adı/Şifre" ForeColor="DarkRed" Visible="false" />
            </td>
            <td align="right">
                <asp:Button ID="enter" runat="server" Text="Giriş" OnClick="enter_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

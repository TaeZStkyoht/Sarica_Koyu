<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script type="text/javascript" src="../Scripts/jquery-1.4.1.js"></script>
    <script type="text/javascript">
        //$(window.document).ready(function () {
        //    var table = document.getElementById('haberlerTable');
        //    if (table) {
        //        var rows = table.getElementsByTagName('tr');
        //        for (var i = 0; i < rows.length; i++)
        //            rows[i].children[0].style.visibility = 'hidden';
        //        table.style.border = "1px";
        //    }
        //});
    </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="mainDiv">
        <h2 id="welcomeMsg" runat="server">Sarıca diyarına hoşgelmişsin
        </h2>
    </div>
    <br /><br />
    <div>
        <asp:GridView ID="haberlerTable" ClientIDMode="Static" runat="server"
            AutoGenerateColumns="False"
            AutoGenerateSelectButton="True" BackColor="White" BorderColor="#999999"
            BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" 
            GridLines="Vertical" OnSelectedIndexChanged="haberlerTable_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="baslik" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </div>
</asp:Content>

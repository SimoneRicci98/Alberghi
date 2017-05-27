<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dettagli.aspx.cs" Inherits="Dettagli" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlace1">
    <div class="col-md-12" style="margin-top:5%;font-size:20px;">
    <div class="col-md-12">
    <asp:Image ID="Image3" runat="server" Height="296px" Width="90%" />
    </div>
        <div class="col-md-12">
    <div class="col-md-4" style="margin-top:2%">
        <asp:Label ID="lblPrd" runat="server"></asp:Label>
        <br />
        <br />
    </div>
    <div class="col-md-4" style="margin-top:2%;height:auto;width:auto">
        <asp:Label ID="lblPrezzo" runat="server"></asp:Label>
        <br />
        <br />
    </div>
    <div class="col-md-12" style="margin-top:2%">
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="95%" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="g1_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ID_stanza" HeaderText="ID_stanza" />
                <asp:BoundField DataField="Cat" HeaderText="Categoria" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Vista" HeaderText="Vista" />
                <asp:BoundField DataField="Nletti" HeaderText="Nletti" />
                <asp:BoundField DataField="Prezzo" HeaderText="Prezzo per notte" />
                <asp:ButtonField HeaderText="Prenota" Text="Prenota ora!" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    </div>
    </div>
    </div>
</asp:Content>
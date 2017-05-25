<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="AreaPersonale.aspx.cs" Inherits="AreaPersonale" %>

<asp:Content ContentPlaceHolderID="ContentPlace1" runat="server">
    Le tue prenotazioni: 
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="95%">
        <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="NomeHotel" HeaderText="Nome dell'hotel" />
                <asp:BoundField DataField="DataArrivo" HeaderText="Data arrivo" />
                <asp:BoundField DataField="DataPartenza" HeaderText="Data partenza" />
                <asp:BoundField DataField="NumPersone" HeaderText="Numero persone" />
                <asp:BoundField DataField="Costo" HeaderText="Prezzo totale" />
                <asp:ButtonField HeaderText="Messaggio" Text="Messaggio aggiuntivo" />
            </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>

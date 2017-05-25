<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VisualizzaHotel.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="VisualizzaHotel" %>


<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlace1">
    <div class="col-md-12">

        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="85%" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="g1_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ImageField DataImageUrlField="img" HeaderText="Immagine" ItemStyle-Width="40px" ControlStyle-Width="100" ControlStyle-Height="100">
<ControlStyle Height="100px" Width="100px"></ControlStyle>

<ItemStyle Width="40px"></ItemStyle>
                </asp:ImageField>
                <asp:BoundField DataField="nome" HeaderText="Nome dell'hotel" />
                <asp:BoundField DataField="zona" HeaderText="Zona" />
                <asp:BoundField DataField="ind" HeaderText="Indirizzo" />
                <asp:ButtonField HeaderText="Per saperne di più" Text="Pulsante" />
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
</asp:Content>

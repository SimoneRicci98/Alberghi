<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Prenota.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="Prenota" %>

<asp:Content ContentPlaceHolderID="ContentPlace1" runat="server">
    <div class="col-md-12">
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <div class="col-md-12">
            Nome hotel:
            <asp:Label ID="lblNome" runat="server"></asp:Label>
        </div>
        <div class="col-md-12">
            Data arrivo:
            <asp:Label ID="lblDataArrivo" runat="server"></asp:Label>
        </div>
        <div class="col-md-12">
            Data partenza:
            <asp:Label ID="lblDataPartenza" runat="server"></asp:Label>
        </div>
        <div class="col-md-12">
            Prezzo complessivo:
            <asp:Label ID="lblPrezzo" runat="server"></asp:Label>
        </div>
        <div class="col-md-12">
            <asp:Label ID="lblMsg" Text="Vuoi aggiungere qualcosa per la tua prenotazione? Scrivilo qui!" runat="server"></asp:Label><br />
            <asp:TextBox ID="txtMsg" TextMode="MultiLine" Width="40%" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-12">
            <asp:Button ID="Button4" runat="server" Text="Procedi all'acquisto" OnClick="Button4_Click" />
        </div>
    </div>
</asp:Content>

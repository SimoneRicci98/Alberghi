<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="MasterPage.master" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlace1">
    <div class="col-md-12">
      <asp:ImageButton ID="ImageButton1" runat="server" Height="291px" Width="85%" />
        
        <br />
        <div class="col-md-12">
            <asp:Label ID="lblLuogo" runat="server"></asp:Label>
        </div>
        <div class="col-md-12">
            <asp:Label ID="lblDescr" runat="server"></asp:Label>
        </div>
        <div class="col-md-12">
            <asp:Label ID="lblAttr" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>



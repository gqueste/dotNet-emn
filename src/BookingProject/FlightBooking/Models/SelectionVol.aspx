<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="SelectionVol.aspx.cs" Inherits="FlightBooking.Models.SelectionVol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">


    <h2> Votre recherche :</h2>
    <div class="container" style="border: solid 1px;">
        Date de départ: <asp:Label ID ="lblDemandeDate" runat="server" visible ="false"/>
        <br />
        Ville de départ: <asp:Label ID="lblVilleDepart" runat="server" Visible="false" />
        <br />
        Ville d'arrivee: <asp:Label ID="lblVilleArrivee" runat="server" Visible="false" />
    </div>
    <h2>Résultats :</h2>

    <form runat="server">
      <asp:GridView AutoGenerateColumns="false" runat="server" ID="grdCustomPagging"> 
        <Columns>
            <asp:BoundField DataField="RowNumber" HeaderText="RowNumber" />
            <asp:BoundField DataField="DealId" HeaderText="DealID" />
            <asp:BoundField DataField="Dealtitle" HeaderText="DealTitle" />
            <asp:TemplateField HeaderText="View">
            <ItemTemplate>
            <asp:LinkButton runat="server" ID="lnkView" CommandArgument='<%#Eval("DealId") %>'
                CommandName="VIEW">View Deal</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    </form>
       
  

</asp:Content>

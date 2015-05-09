<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="SelectionVol.aspx.cs" Inherits="FlightBooking.Models.SelectionVol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    
    <h2>Votre recherche :</h2>
    <div class="jumbotron jumbotron-info">
        Date de départ:
        <asp:Label ID="lblDemandeDate" runat="server" />
        <br />
        Ville de départ:
        <asp:Label ID="lblVilleDepart" runat="server" />
        <br />
        Ville d'arrivee:
        <asp:Label ID="lblVilleArrivee" runat="server" />
    </div>

    <h2>Résultats :</h2>
    <form runat="server">
         <asp:GridView AutoGenerateColumns="false" runat="server" ID="grdViewVols" CssClass="table table-hover table-bordered">
            <Columns>
                <asp:BoundField DataField="idVol" HeaderText="N°" />
                <asp:BoundField DataField="nomVol" HeaderText="Nom" />
                <asp:BoundField DataField="companie" HeaderText="Companie" />
                <asp:BoundField DataField="dateVol" HeaderText="Date" />
                <asp:BoundField DataField="duree" HeaderText="Durée" />
                <asp:BoundField DataField="villeDepart" HeaderText="Départ" />
                <asp:BoundField DataField="villeArrivee" HeaderText="Arrivée" />
                <asp:TemplateField HeaderText="Choix">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lnkBtnSelection" OnClick="lnkBtnSelection_Click" CssClass="btn btn-primary">Sélectionner</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label runat="server" ID="lblNoResults" Text="Aucun vol ne correspond à votre recherche" CssClass="alert" Visible="false" />
        <asp:Button runat="server" ID="btnNouvelleRecherche" Text="Rechercher un autre vol" CssClass="btn btn-default" OnClick="btnNouvelleRecherche_Click" />
    </form>
</asp:Content>

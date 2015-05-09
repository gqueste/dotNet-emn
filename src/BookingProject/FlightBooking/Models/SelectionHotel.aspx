<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="SelectionHotel.aspx.cs" Inherits="FlightBooking.Models.SelectionHotel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    
    <h2>Votre recherche :</h2>
    <div class="jumbotron jumbotron-info">
        Hôtel pour ces critères :
        <br />
        Date d'arrivée:
        <asp:Label ID="lblDate" runat="server" />
        <br />
        Ville d'arrivee:
        <asp:Label ID="lblVilleArrivee" runat="server" />
    </div>

    <h2>Résultats :</h2>
    <form runat="server">
         <asp:GridView AutoGenerateColumns="false" runat="server" ID="grdViewHotels" CssClass="table table-hover table-bordered">
            <HeaderStyle CssClass="thead" />
            <Columns>
                <asp:BoundField DataField="nomHotel" HeaderText="Nom" />
                <asp:BoundField DataField="descriptionHotel" HeaderText="Description" />
                <asp:BoundField DataField="ville" HeaderText="Ville" />
                <asp:TemplateField HeaderText="Choix">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lnkBtnSelection" OnClick="lnkBtnSelection_Click" CssClass="btn btn-primary">Sélectionner</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label runat="server" ID="lblNoResults" Text="Aucun hôtel dans cette ville d'arrivée !" CssClass="alert" Visible="false" />
        <asp:Button runat="server" ID="btnNouvelleRecherche" Text="Rechercher une nouvelle destination" CssClass="btn btn-default" OnClick="btnNouvelleRecherche_Click" />
    </form>
</asp:Content>

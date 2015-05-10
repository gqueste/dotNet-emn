<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="Panier.aspx.cs" Inherits="FlightBooking.Models.Panier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form runat="server">
        <h1>Votre Panier :</h1>
        <hr />

        <asp:Panel runat="server" ID="pnlPanierVide" Visible="false">
            <asp:Label runat="server" ID="lblPanierVide" Text="Vous n'avez aucun élément dans votre panier." />
            <br /><br />
            <asp:Button runat="server" ID="btnGoToSelection" CssClass ="btn btn-primary" OnClick="btnAccesCommande_Click" Text="Faire une reservation" />
        </asp:Panel>

        <asp:Panel runat="server" ID="pnlPanierNonVide" Visible="false">
            <asp:Label runat="server" ID="lblPanierNonVide" Text="Vous avez 1 élément dans votre panier" />
            <br /><br />
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Départ</th>
                        <th>Arrivée</th>
                        <th>Etat</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblVilleDepart"></asp:Label></td>
                        <td>
                            <asp:Label runat="server" ID="lblVilleArrivee"></asp:Label></td>
                        <td>
                            <asp:Label runat="server" ID="lblEtatCommande"></asp:Label></td>
                        <td>
                            <asp:Button runat="server" ID="btnVoirCommande" OnClick="btnAccesCommande_Click" Text="Voir" CssClass="btn btn-primary"/>
                            <asp:Button runat="server" ID="btnSupprimerCommande" OnClick="btnSupprimerCommande_Click" Text="Supprimer" CssClass="btn btn-info"/>
                        </td>
                    </tr>
                </tbody>
            </table> 
        </asp:Panel>
     </form>
</asp:Content>

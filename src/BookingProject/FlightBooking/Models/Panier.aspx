<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="Panier.aspx.cs" Inherits="FlightBooking.Models.Panier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form runat="server">
        <h1>Votre Panier :</h1>
        <hr />
        <asp:Panel runat="server" ID="pnlPanierVide">
            <asp:Label runat="server" ID="lblPanierVide" Text="Vous n'avez aucun element dans votre panier." />
            <br /><br />
            <asp:Button runat="server" ID="btnGoToSelection" CssClass ="btn btn-primary" OnClick="btnGoToSelection_Click" Text="Faire une reservation" />
        </asp:Panel>
        <asp:Panel runat="server" ID="pnlPanierNonVide" Visible="false">
            <asp:Label runat="server" ID="lblPanierNonVide" Text="Vous avez 1 élément dans votre panier" />
            <br /><br />
            <table class="table table-bordered">
            <thead>
                <tr>
                    <th>Nom</th>
                    <th>Description</th>
                    <th>Ville</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblNomHotel"></asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="lblDescriptionHotel"></asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="lblVilleHotel"></asp:Label></td>
                </tr>
            </tbody>
        </table>
        </asp:Panel>
     </form>
</asp:Content>

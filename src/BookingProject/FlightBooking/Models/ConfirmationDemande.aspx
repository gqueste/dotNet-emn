<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="ConfirmationDemande.aspx.cs" Inherits="FlightBooking.Models.Confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form runat="server">
        <h1>Confirmation de votre demande :</h1>
        <hr />
        <h4>Votre Vol :</h4>
        <table class="table table-bordered">
            <thead>
                <tr>
                    <th>N°</th>
                    <th>Nom</th>
                    <th>Compagnie</th>
                    <th>Date</th>
                    <th>Durée</th>
                    <th>Départ</th>
                    <th>Arrivée</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblIdVol"></asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="lblNomVol"></asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="lblCompagnie"></asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="lblDateVol"></asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="lblDuree"></asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="lblVilleDepart"></asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="lblVilleArrivee"></asp:Label></td>
                </tr>
            </tbody>
        </table>
        <asp:Button runat="server" ID="btnModifierVol" OnClick="btnModifierVol_Click" Text="Choisir un autre vol" CssClass="btn btn-primary" />
        <br />
        <h4>Votre Hôtel :</h4>
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
        <asp:Button runat="server" ID="btnModifierHotel" OnClick="btnModifierHotel_Click" Text="Choisir un autre hôtel" CssClass="btn btn-primary" />
        <hr />

        <asp:Button ID="btnAnnuler" CssClass="btn btn-default" runat="server" OnClick="btnAnnuler_Click" Text="Annuler la commande" />
        &nbsp; ou &nbsp;
        <asp:Button ID="btnConfirmer" CssClass="btn btn-success" runat="server" OnClick="btnConfirmer_Click" Text="Confirmer" />
    </form>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="ConfirmationReservation.aspx.cs" Inherits="FlightBooking.Models.ConfirmationReservation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form runat="server">
        <h1>Votre commande a bien été enregistrée</h1>
        <h3>Récapitulatif de votre demande :</h3>
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
        <h4>Passager :</h4>
        <table class="table table-bordered">
            <thead>
                <tr>
                    <th>Nom</th>
                    <th>Prénom</th>
                    <th>Email (envoi du billet)</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblNomClient"></asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="lblPrenomClient"></asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="lblEmailClient"></asp:Label></td>
                </tr>
            </tbody>
        </table>
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
        <asp:Button CssClass="btn btn-primary" ID="btnNouvelleReservation" runat="server" Text="Faire une nouvelle réservation" OnClick="btnNouvelleReservation_Click" />
    </form>
</asp:Content>

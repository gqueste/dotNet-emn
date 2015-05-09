<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="ConfirmationReservation.aspx.cs" Inherits="FlightBooking.Models.ConfirmationReservation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>OK! TODO: Afficher les details de la reservation</h1>
    <form runat="server">
        <asp:Button CssClass="btn btn-primary" ID="btnNouvelleReservation" runat="server" Text="Faire une nouvelle réservation" OnClick="btnNouvelleReservation_Click" />
    </form>
</asp:Content>

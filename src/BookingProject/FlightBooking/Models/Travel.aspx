<%@ Page Title="Voyage" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="Travel.aspx.cs" Inherits="FlightBooking.Travel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <div class="jumbotron" style="background: url('/Assets/openphotonet_IMG_6018.jpg') no-repeat bottom center; background-size: cover;">
        <h2 style="color:white;">Planifiez</h2>
        <br />
        <br />
        <p></p>
    </div>
   
    <h3>Décrivez votre voyage :</h3>
    <hr />

    <form id="form1" runat="server">

        <div>
            <!-- Permet l'utilisation d'AJAX -->
            <asp:ScriptManager ID="ScriptManagerTravel" runat="server" />
        </div>

        <!-- Example row of columns -->
        <div class="row">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="col-md-3">
                        <asp:Label runat="server" AssociatedControlID="calendarDateDepart" CssClass="h3" >Date de départ: </asp:Label>
                        <br />
                        <asp:Calendar ID="calendarDateDepart" runat="server" OnDataBinding="selectionChanged" OnSelectionChanged="selectionChanged" CssClass="pull-left"></asp:Calendar>
                    </div>
                    <div class="col-md-3">
                        <asp:Label runat="server" AssociatedControlID="lstBoxVilleDepart" CssClass="h3">Ville de départ: </asp:Label>
                        <br />
                        <asp:ListBox ID="lstBoxVilleDepart" runat="server" OnSelectedIndexChanged="selectionChanged" AutoPostBack="true"></asp:ListBox>
                    </div>
                    <div class="col-md-3">
                        <asp:Label runat="server" AssociatedControlID="lstBoxVilleArrivee" CssClass="h3">Ville d'arrivée: </asp:Label>
                        <br />
                        <asp:ListBox ID="lstBoxVilleArrivee" runat="server" OnSelectedIndexChanged="selectionChanged" AutoPostBack="true"></asp:ListBox>
                    </div>
                    <div class="col-md-3">
                        <h3>Votre choix: </h3>
                        <asp:Label ID="lblChoixDate" runat="server" />
                        <br />
                        <asp:Label ID="lblChoixDepart" runat="server" />
                        <br />
                        <asp:Label ID="lblChoixArrivee" runat="server" />
                        <br />
                        <br />
                        <asp:Button ID="btnConfirmer" runat="server" Text="Confirmer" CssClass="btn btn-lg btn-primary" OnClick="btnConfirmer_Click" Visible="false" />
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <asp:UpdateProgress ID="UpdateProgress1" runat="server" DynamicLayout="true" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="0">
                <ProgressTemplate>
                    Chargement...
                </ProgressTemplate>
            </asp:UpdateProgress>
        </div>
    </form>


</asp:Content>

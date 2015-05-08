<%@ Page Title="Voyage" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="Travel.aspx.cs" Inherits="FlightBooking.Travel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <div class="jumbotron" style="background: url('/Assets/openphotonet_IMG_6018.jpg') no-repeat bottom center; background-size: cover;">
        <h2 style="color:white;">1: Planifiez</h2>
        <br />
        <br />
        <p></p>
    </div>
   
    <h3>Décrivez votre voyage :</h3>
    <hr />
    
     <form id="form1" runat="server">
       
         <div>
            <!-- Permet l'utilisation d'AJAX -->
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
        </div>
        
        <!-- Example row of columns -->
        <div class="row">
            <div class="col-md-3">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Label runat="server" CssClass="h3" AssociatedControlID="Calendar">Date de départ: </asp:Label>
                        <asp:Calendar ID="Calendar" runat="server" OnSelectionChanged="Calendar_SelectionChanged" CssClass="pull-left"></asp:Calendar>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <br />
                <asp:UpdateProgress ID="UpdateProgress1" runat="server" DynamicLayout="true" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="0">
                    <ProgressTemplate>
                        Chargement...
                    </ProgressTemplate>
                </asp:UpdateProgress>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="ListBox1" CssClass="h3">Ville de départ: </asp:Label>
                <br />
                <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                <br />

            </div>
              <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="ListBox2" CssClass="h3">Ville d'arrivée: </asp:Label>
                <br />
                <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
            </div>
            <div class="col-md-3">
                <h3>Votre choix: </h3>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Vérifier" CssClass="btn btn-sm btn-default" />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
                <br />
                <asp:Button ID="btnConfirmer" runat="server" Text="Confirmer" CssClass="btn btn-lg btn-primary" OnClick="btnConfirmer_Click" Visible="false" />
            </div>
        </div>
        
    </form>


</asp:Content>

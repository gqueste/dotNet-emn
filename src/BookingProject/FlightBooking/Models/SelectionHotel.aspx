<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="SelectionHotel.aspx.cs" Inherits="FlightBooking.Models.SelectionHotel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h2> Votre recherche :</h2>
    <div class="container" style="border: solid 1px;">
        Date d'arrivée: <asp:Label ID ="lblDate" runat="server"/>
        <br />
        Ville d'arrivee: <asp:Label ID="lblVilleArrivee" runat="server"/>
    </div>
    <h2>Résultats :</h2>

    <form runat="server">
          <asp:GridView AutoGenerateColumns="false" runat="server" ID="GridView1" CssClass="table table-hover"> 
             <HeaderStyle CssClass="thead"/>
             <Columns>
                <asp:BoundField DataField="nomHotel" HeaderText="Nom" />
                <asp:BoundField DataField="descriptionHotel" HeaderText="Description" />
                <asp:BoundField DataField="ville" HeaderText="Ville" />
                <asp:TemplateField HeaderText="Choix">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lnkView2" OnClick="lnkView2_Click" CssClass="btn btn-primary">Sélectionner</asp:LinkButton>
                    </ItemTemplate>
               </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</asp:Content>

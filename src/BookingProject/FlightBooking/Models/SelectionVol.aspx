<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="SelectionVol.aspx.cs" Inherits="FlightBooking.Models.SelectionVol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">


    <h2> Votre recherche :</h2>
    <div class="container" style="border: solid 1px;">
        Date de départ: <asp:Label ID ="lblDemandeDate" runat="server" visible ="false"/>
        <br />
        Ville de départ: <asp:Label ID="lblVilleDepart" runat="server" Visible="false" />
        <br />
        Ville d'arrivee: <asp:Label ID="lblVilleArrivee" runat="server" Visible="false" />
    </div>
    <h2>Résultats :</h2>

    <form runat="server">
          <asp:GridView AutoGenerateColumns="false" runat="server" ID="GridView1" OnRowCommand="GridView1_RowCommand" CssClass="table table-hover"> 
             <HeaderStyle CssClass="thead"/>
             <Columns>
                <asp:BoundField DataField="idVol" HeaderText="N°" />
                <asp:BoundField DataField="nomVol" HeaderText="Nom" />
                <asp:BoundField DataField="companie" HeaderText="Companie" />
                <asp:BoundField DataField="dateVol" HeaderText="Date" />
                <asp:BoundField DataField="duree" HeaderText="Durée" />
                <asp:BoundField DataField="villeDepart" HeaderText="Départ" />
                <asp:BoundField DataField="villeArrivee" HeaderText="Arrivée" />

                <asp:TemplateField HeaderText="View">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lnkView" CommandArgument='<%#Eval("idVol") %>'
                            CommandName="VIEW" CssClass="btn btn-primary">Sélectionner</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="View2">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lnkView2" OnClick="lnkView2_Click" CssClass="btn btn-primary"> Clique ici (<%#Eval("idVol") + " " + Eval("companie")%>)</asp:LinkButton>
                    </ItemTemplate>
               </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
       
    <asp:Label ID="labelChoix" runat="server" />
  

</asp:Content>

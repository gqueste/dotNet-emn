<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="FlightBooking.Test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <div class="container" style="border: solid 1px;">
        Date de départ: <asp:Label ID ="lblDemandeDate" runat="server" visible ="false"/>
        <br />
        Ville de départ: <asp:Label ID="lblVilleDepart" runat="server" Visible="false" />
        <br />
        Ville d'arrivee: <asp:Label ID="lblVilleArrivee" runat="server" Visible="false" />
    </div>
   
    <form id="form2" runat="server">


         <div>
            <h2>MultiView and View Controls</h2>
            
            <asp:DropDownList ID="DropDownList1" runat="server" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            
            <hr />
            
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="2"  onactiveviewchanged="MultiView1_ActiveViewChanged" >
               <asp:View ID="View1" runat="server">
                  <h3>This is view 1</h3>
                  <br />
                  <asp:Button CommandName="NextView" ID="btnnext1" runat="server" Text = "Go To Next" />
                  <asp:Button CommandArgument="View3" CommandName="SwitchViewByID" ID="btnlast" runat="server" Text  ="Go To Last" />
               </asp:View> 
					
               <asp:View ID="View2" runat="server">
                  <h3>This is view 2</h3>
                  <asp:Button CommandName="NextView" ID="btnnext2" runat="server" Text = "Go To Next" />
                  <asp:Button CommandName="PrevView" ID="btnprevious2" runat="server" Text = "Go To Previous View" />
               </asp:View> 

               <asp:View ID="View3" runat="server">
                  <h3> This is view 3</h3>
                  <br />
                  <asp:Calendar ID="Calender1" runat="server"></asp:Calendar>
                  <br />
                  <asp:Button  CommandArgument="0" CommandName="SwitchViewByIndex" ID="btnfirst"   runat="server" Text = "Go To Next" />
                  <asp:Button CommandName="PrevView" ID="btnprevious" runat="server" Text = "Go To Previous View" />
               </asp:View> 
               
            </asp:MultiView>
         </div>

    <br />

    <br />

   <div>
      <asp:Panel ID="pnldynamic" runat="server" BorderColor="#990000" 
         Border="Solid 1px" Height="150px"  ScrollBars="Auto" style="width:100%" BackColor="#CCCCFF"  Font-Names="Courier" HorizontalAlign="Center">
     
         This panel shows dynamic control generation:
         <br />
         <br />
      </asp:Panel>
   </div>

   <table style="width: 51%;">
      <tr>
         <td class="style2">No of Labels:</td>
         <td class="style1">
            <asp:DropDownList ID="ddllabels" runat="server">
               <asp:ListItem>0</asp:ListItem>
               <asp:ListItem>1</asp:ListItem>
               <asp:ListItem>2</asp:ListItem>
               <asp:ListItem>3</asp:ListItem>
               <asp:ListItem>4</asp:ListItem>
            </asp:DropDownList>
         </td>
      </tr>

      <tr>
         <td class="style2"> </td>
         <td class="style1"> </td>
      </tr>

      <tr>
         <td class="style2">No of Text Boxes :</td>
         <td class="style1">
            <asp:DropDownList ID="ddltextbox" runat="server">
               <asp:ListItem>0</asp:ListItem>
               <asp:ListItem Value="1"></asp:ListItem>
               <asp:ListItem>2</asp:ListItem>
               <asp:ListItem>3</asp:ListItem>
               <asp:ListItem Value="4"></asp:ListItem>
            </asp:DropDownList>
         </td>
      </tr>

      <tr>
         <td class="style2"> </td>
         <td class="style1"> </td>
      </tr>

      <tr>
         <td class="style2">
            <asp:CheckBox ID="chkvisible" runat="server" 
               Text="Make the Panel Visible" />
         </td>

         <td class="style1">
            <asp:Button ID="btnrefresh" runat="server" Text="Refresh Panel" 
               style="width:129px" />
         </td>
      </tr>
   </table>

        <div>
            <!-- Permet l'utilisation d'AJAX -->
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
        </div>
   
   <!-- Permet l'utilisation du rafarichissement partiel de la page -->
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
           <ContentTemplate>
               <asp:Button ID="btnpartial" runat="server" OnClick="btnpartial_Click" Text="Partial PostBack" />
               <br />
               <br />
               <asp:Label ID="lblpartial" runat="server"></asp:Label>
           </ContentTemplate>
       </asp:UpdatePanel>
       <asp:UpdateProgress ID="UpdateProgress1" runat="server" DynamicLayout="true" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="0">
           <ProgressTemplate>
               Loading...
           </ProgressTemplate>
       </asp:UpdateProgress>

        <p></p>
        <p>Outside the Update Panel</p>
        <p>
            <asp:Button ID="btntotal" runat="server" OnClick="btntotal_Click" Text="Total PostBack" />
        </p>

        <asp:Label ID="lbltotal" runat="server"></asp:Label>

</form>



</asp:Content>

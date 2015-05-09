<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="Paiement.aspx.cs" Inherits="FlightBooking.Models.Paiement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <div class="container">
        <form class="form-horizontal" role="form" runat="server">
            <div>
                <!-- Permet l'utilisation d'AJAX -->
                <asp:ScriptManager ID="ScriptManagerPaiement" runat="server" />
            </div>
            <fieldset>
                <legend>Vos informations (Passager)</legend>
                <div class="form-group">
                    <label class="col-sm-3 control-label" for="tbNomClient">Nom</label>
                    <div class="col-sm-9">
                        <asp:TextBox CssClass="form-control" ID="tbNomClient" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label" for="tbPrenomClient">Prénom</label>
                    <div class="col-sm-9">
                        <asp:TextBox CssClass="form-control" ID="tbPrenomClient" runat="server"></asp:TextBox>
                    </div>
                </div>
            </fieldset>
            <fieldset>
                <legend>Réception du billet</legend>
                <div class="form-group">
                    <label class="col-sm-3 control-label" for="tbMail">Email</label>
                    <div class="col-sm-9">
                        <asp:TextBox CssClass="form-control" ID="tbMail" runat="server"></asp:TextBox>
                    </div>
                </div>
            </fieldset>
            <fieldset>
                <legend>Paiement</legend>
                <div class="form-group">
                    <label class="col-sm-3 control-label" for="card-holder-name">Porteur de carte</label>
                    <div class="col-sm-9">
                        <input type="text" class="form-control" name="card-holder-name" id="card-holder-name" placeholder="Nom du porteur de la carte" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label" for="card-number">Numéro de carte</label>
                    <div class="col-sm-9">
                        <input type="text" class="form-control" name="card-number" id="card-number" placeholder="Numéro de la carte" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label" for="expiry-month">Date d'expiration</label>
                    <div class="col-sm-9">
                        <div class="row">
                            <div class="col-xs-3">
                                <select class="form-control col-sm-2" name="expiry-month" id="expiry-month">
                                    <option value="01">Jan (01)</option>
                                    <option value="02">Fev (02)</option>
                                    <option value="03">Mar (03)</option>
                                    <option value="04">Avr (04)</option>
                                    <option value="05">Mai (05)</option>
                                    <option value="06">Juin (06)</option>
                                    <option value="07">Juil (07)</option>
                                    <option value="08">Aou (08)</option>
                                    <option value="09">Sep (09)</option>
                                    <option value="10">Oct (10)</option>
                                    <option value="11">Nov (11)</option>
                                    <option value="12">Dec (12)</option>
                                </select>
                            </div>
                            <div class="col-xs-3">
                                <select class="form-control" name="expiry-year">
                                    <option value="15">2015</option>
                                    <option value="16">2016</option>
                                    <option value="17">2017</option>
                                    <option value="18">2018</option>
                                    <option value="19">2019</option>
                                    <option value="20">2020</option>
                                    <option value="21">2021</option>
                                    <option value="22">2022</option>
                                    <option value="23">2023</option>
                                </select>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label" for="cvv">Cryptogramme visuel</label>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" name="cvv" id="cvv" placeholder="Cryptogramme visuel" />
                    </div>
                </div>
            </fieldset>
            <fieldset>
                <asp:UpdatePanel ID="updtPnlValidite" runat="server">
                    <ContentTemplate>
                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-9">
                                <asp:CheckBox CssClass="form-control" ID="cbInformationsValides" Text=" J'atteste de la validité de ces informations" runat="server" OnCheckedChanged="cbInformationsValides_CheckedChanged" AutoPostBack="true" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-9">
                                <asp:Button CssClass="btn btn-default" runat="server" ID="btnAnnuler" OnClick="btnAnnuler_Click" Text="Annuler la commande" />
                                &nbsp;  &nbsp;
                                <asp:Button CssClass="btn btn-success" runat="server" ID="btnPayer" OnClick="btnPayer_Click" Text="Valider" Enabled="false" />
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </fieldset>
        </form>
    </div>
</asp:Content>

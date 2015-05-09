<%@ Page Title="" Language="C#" MasterPageFile="~/FlightBooking.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FlightBooking.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">


    <!-- Carousel
    ================================================== -->
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <div class="carousel-rounded-content">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner" role="listbox">
                <div class="item active" style="background-image: url('/Assets/stockvault-icelandair-cargo104507.jpg')">
                    <div class="container">
                        <div class="carousel-caption">
                            <h1>Envolez-vous !</h1>
                            <!-- Prenez le large ! Voyagez !-->
                            <p>Planifiez, réservez votre vol, choissisez votre hôtel et envolez-vous !</p>
                            <p>
                                <a class="btn btn-lg btn-primary" href="/Models/Travel.aspx" role="button">Réservez &raquo;</a>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="item" style="background-image: url('/Assets/stockvault-farewell-147798.jpg')">
                    <div class="container">
                        <div class="carousel-caption">
                            <h1>Evadez-vous !</h1>
                            <p>Des destinations de rêve en quelques clics !</p>
                            <p>
                                <a class="btn btn-lg btn-primary" href="/Models/Travel.aspx" role="button">Réservez &raquo;</a>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="item" style="background-image: url('/Assets/stockvault-sky-and-clouds-from-airplane131129.jpg')">
                    <div class="container">
                        <div class="carousel-caption">
                            <h1>Prenez le large !</h1>
                            <p>Le soleil, le sable fin et le confort d'une chambre d'hôtel en trois étapes !</p>
                            <p>
                                <a class="btn btn-lg btn-primary" href="/Models/Travel.aspx"role="button">Réservez &raquo;</a>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div><!-- /.carousel-rounded-content -->
    </div><!-- /.carousel -->
</asp:Content>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplicacionWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel" style="margin-top:15px">
                      <ol class="carousel-indicators">
                        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                      </ol>
                      <div class="carousel-inner">
                        <div class="carousel-item active">
                          <img class="d-block w-100" src="https://markepymes.com/wp-content/uploads/2018/05/como-vender-mas-en-una-tienda-de-pequenos-electrodomesticos.jpg" alt="First slide"
                              style="width:300px; height:350px;">
                        </div>
                        <div class="carousel-item">
                          <img class="d-block w-100" src="https://www.cronista.com/files/image/292/292304/5ffe051166608.jpg" alt="Second slide"
                             style="width:300px; height:350px;">
                        </div>
                        <div class="carousel-item">
                          <img class="d-block w-100" src="https://www.themarkethink.com/wp-content/uploads/2017/01/el-aro-3.jpg" alt="Third slide"
                              style="width:300px; height:350px;">
                        </div>
                      </div>
                      <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                      </a>
                      <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                      </a>
                    </div>

    <div class="jumbotron">
  <h1 class="display-4">Ciccarelli Decoración&copy; 2021</h1>
  <p class="lead">Control de Stock de modelos de los cuadros</p>
  <hr class="my-4">
  <p>Para ingresar a todos los articulos disponibles para realizar la compra, presione el siguiente boton</p>
  <p class="lead">
    <a class="btn btn-primary btn-lg" href="NuestrosProductos.aspx" role="button">Ver Cuadros</a>
   
</div>

</asp:Content>

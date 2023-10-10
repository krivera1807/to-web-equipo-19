<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="tp_web_equipo_19.DetalleArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <h3>DETALLE DE ARTÍCULO</h3>
   
    <!-- Aquí comienza el carrusel -->
<div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater runat="server" ID="Repeater1">
            <ItemTemplate>
    <div id="carouselExample" class="carousel slide" data-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
              <img src="<%# Eval("Imagen")%>" class="card-img-top" alt="Imagen">
                 <h5 class="card-title"><%# Eval("Nombre")%></h5>
                 <p class="card-text"><%# Eval("Descripcion")%></p>
            </div>
            <div class="carousel-item">
             <img src="<%# Eval("Imagen")%>" class="card-img-top" alt="Imagen">
                 <h5 class="card-title"><%# Eval("Nombre")%></h5>
                 <p class="card-text"><%# Eval("Descripcion")%></p>
            </div>
            <div class="carousel-item">
             <img src="<%# Eval("Imagen")%>" class="card-img-top" alt="Imagen">
                 <h5 class="card-title"><%# Eval("Nombre")%></h5>
                 <p class="card-text"><%# Eval("Descripcion")%></p>
            </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExample" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExample" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
  </ItemTemplate>
        </asp:Repeater>
    </div>
    <!-- Fin del carrusel -->

<%--    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater runat="server" ID="Repeater1">
            <ItemTemplate>--%>
               <%-- <!-- Contenido del artículo -->
                <div class="card mb-3" style="max-width: 540px;">
                    <div class="row g-0">
                        <div class="col-md-4">
                            <img src="<%# Eval("Imagen")%>" class="card-img-top" alt="Imagen">
                        </div>
                        <div class="col-md-8">
                            <div class="card-body">
                                <h5 class="card-title"><%# Eval("Nombre")%></h5>
                                <p class="card-text"><%# Eval("Descripcion")%></p>
                                <p><%# string.Format("{0:C}", Eval("Precio")) %></p>
                            </div>
                        </div>
                    </div>
                </div>--%>
    <%--        </ItemTemplate>
        </asp:Repeater>
    </div--%>
</asp:Content>


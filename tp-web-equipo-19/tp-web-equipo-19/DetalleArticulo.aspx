<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="tp_web_equipo_19.DetalleArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>DETALLE DE ARTÍCULO </h3>
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater runat="server" ID="Repeater1">
            <ItemTemplate>
                <%--<div class="col">
                    <div class="card btn btn-outline-primary">
                        <img src="<%# Eval("Imagen")%>" class="card-img-top" alt="Imagen">
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("Nombre")%></h5>
                            <p class="card-text"><%# Eval("Descripcion")%></p>
                        </div>
                    </div>
                </div>--%>


                <div class="card mb-3" style="max-width: 540px;">
                    <div class="row g-0">
                        <div class="col-md-4">
                            <img src="<%# Eval("Imagen")%>" class="card-img-top" alt="Imagen">
                        </div>
                        <div class="col-md-8">
                            <div class="card-body">
                                <h5 class="card-title"><%# Eval("Nombre")%></h5>
                                <p class="card-text"><%# Eval("Descripcion")%></p>
                                <%--<p class="card-text"><%# Eval("Precio")%></p>--%>
                                <p><%# string.Format("{0:C}", Eval("Precio")) %></p>
                            </div>
                        </div>
                    </div>
                </div>



            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="tp_web_equipo_19.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>LISTADO DE ARTICULOS </h3>
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater runat="server" ID="Repetidor">
            <ItemTemplate>
                <div class="col">
                    <div class="card">
                       
                        <img src="<%# Eval("Imagen")%>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("Nombre")%></h5>
                            <p class="card-text"><%# Eval("Descripcion")%></p>
                            <a href="DetalleArticulo.aspx?id=<%#Eval("Id") %>">Ver Detalle</a>
                            <asp:button Text="Añadir al Carrito" CssClass="btn btn-primary" runat="server" Id="btnAniadirAlCarrito" CommandArgument='<%#Eval("id") %>' CommandName ="IdArticulo" OnClick ="btnAniadirAlCarrito_Click"   />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <%--  <p>GRID VIEW</p>
        <asp:GridView runat="server" ID="dgv_Articulos"></asp:GridView>--%>
</asp:Content>

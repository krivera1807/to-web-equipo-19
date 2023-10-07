<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="tp_web_equipo_19.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row row-cols-1 row-cols-md-3 g-4">
    <div class="container text-center">
        <h3>LISTADO DE COMPRAS</h3>
        <table class="table">
            <thead>
                <tr>
                    <th>PRODUCTO</th>
                    <th>DESCRIPCION</th>
                    <th>PRECIO</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="RepeaterCarrito" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Nombre") %></td>
                            <td><%# Eval("Descripcion") %></td>
                            <td><%# Eval("Precio") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</div>

<div>Total</div>


</asp:Content>

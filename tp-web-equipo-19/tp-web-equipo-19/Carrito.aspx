<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="tp_web_equipo_19.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <h3>LISTADO DE COMPRAS</h3>
        <table class="table">
            <thead>
                <tr>
                    <th>PRODUCTO</th>
                    <th>DESCRIPCION</th>
                    <th>PRECIO</th>
                    <th>CANTIDAD</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="RepeaterCarrito" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Articulo.Nombre") %></td>
                            <td><%# Eval("Articulo.Descripcion") %></td>
                            <td><%# Eval("Articulo.Precio") %></td>
                            <td>
                                <input type="number" class="col-lg-4" value='<%# Eval("cantidad") %>' min="1" runat="server" id="txtCantidad" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
   
        <td>Total: $ <asp:Label ID="lblTotalCarrito" runat="server" Text="0.00"></asp:Label></td>


</asp:Content>

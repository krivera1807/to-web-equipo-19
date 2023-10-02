using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace tp_web_equipo_19
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            dgv_Articulos.DataSource = articulo.Listar();
            dgv_Articulos.DataBind();   

        }
    }
}
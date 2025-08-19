using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webCinestar_webForm_1808.Pages
{
    public partial class Pelicula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            if (id == null)
            {
                pelicula.DataSource = new Controllers.CinestarController().getPeliculas(id);
            }
        }
    }
}
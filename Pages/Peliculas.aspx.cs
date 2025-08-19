using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webCinestar_webForm_1808.Controllers;

namespace webCinestar_webForm_1808.Pages
{
    public partial class Peliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string id = Request.QueryString["id"];
            if (id != null && (id == "cartelera" ||id == "estrenos"))
            {
                rptPeliculas.DataSource = new CinestarController().getPeliculas(id);
                rptPeliculas.DataBind();
                if(rptPeliculas.DataSource == null)
                    Response.Redirect("index.aspx");
            }
            else Response.Redirect("index.aspx");

            

        }
    }
}
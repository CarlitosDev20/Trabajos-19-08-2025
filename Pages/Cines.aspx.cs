using System;
using webCinestar_webForm_1808.Controllers;

namespace webCinestar_webForm_1808.Pages
{
    public partial class Cines : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptCines.DataSource = new CinestarController().getCines();
            rptCines.DataBind();
            if (rptCines.DataSource == null)
                Response.Redirect("index.aspx");
        }
    }
}//Data Source=Q08LB1102PC15;Initial Catalog=CineStar;Integrated Security=True;Trust Server Certificate=True
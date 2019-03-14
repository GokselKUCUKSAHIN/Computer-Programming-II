using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class islemler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool giris = Convert.ToBoolean(Session["giris"]);
        if(giris == false)
        {
            Response.Redirect("giris.aspx?mesaj=Lutfen Once Giris Yapın");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class notlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool giris = Convert.ToBoolean(Session["giris"]);
        if (giris == false)
        {
            Response.Redirect("giris.aspx?mesaj=Lutfen Once Giris Yapın");
        }
        else
        {
            int OgrNo = Convert.ToInt32(Session["OgrNo"]);
            System.Data.DataSet notlar = DBislem.NotlariCek(OgrNo);
            GridView1.DataSource = notlar.Tables[0];
            GridView1.DataBind();

        }
    }
}
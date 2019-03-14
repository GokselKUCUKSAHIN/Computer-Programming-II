using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class derssec : System.Web.UI.Page
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

            if(IsPostBack == false)
            {
                System.Data.DataSet Dersler = DBislem.DersCek();
                DropDownList1.DataTextField = "DersAdi";
                DropDownList1.DataValueField = "DersID";
                DropDownList1.DataSource = Dersler.Tables[0];
                DropDownList1.DataBind();
            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int ogrNo = Convert.ToInt32(Session["OgrNo"]);
        string Ders = DropDownList1.SelectedValue.ToString();
        Response.Write("Ders Adı :" + Ders);
        Response.Write("No: " + ogrNo);
        DBislem.Ekle(ogrNo, Ders);
        Response.Write("Eklendi");
    }
}
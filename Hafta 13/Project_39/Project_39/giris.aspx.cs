using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class giris : System.Web.UI.Page
{
    public int a = 5;

    public string[] Dizi = { "Ali", "Veli", "Ahmet", "Hasan", "Kadir" };
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["Mesaj"] != null)
        {
            Label3.Text = Request.QueryString["Mesaj"].ToString();
        }
    }
    protected void Giris(object sender, EventArgs e)
    {
        int OgrNo = Int32.Parse(TextBox1.Text);
        string Sifre= TextBox2.Text;
        bool sonuc = DBislem.Kontrol(OgrNo, Sifre);
        if (sonuc == false)
            Label3.Text = "Hatalı Giriş!";
        else
        {
            Session["giris"] = true;
            Session["OgrNo"] = OgrNo; 
            Response.Redirect("islemler.aspx?login=true");
        }
    }
}
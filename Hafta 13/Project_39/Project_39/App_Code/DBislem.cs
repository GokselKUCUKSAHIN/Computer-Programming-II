using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for DBislem
/// </summary>
public class DBislem
{

    static string by = ConfigurationManager.ConnectionStrings["DBYolu"].ToString();
    static SqlConnection conn = new SqlConnection(by);


    public static bool Kontrol(int OgrNo, string sifre)
    {
        string sql = "select * from Ogrenciler where OgrNo=@pNo and Sifre = @pS";
        SqlCommand komut = new SqlCommand(sql, conn);
        komut.Parameters.AddWithValue("@pNo", OgrNo);
        komut.Parameters.AddWithValue("@pS", sifre);

        /*
        //Data Reader kullanım
        conn.Open();
        SqlDataReader okuyucu = komut.ExecuteReader();
        bool varMi = false;
        if (okuyucu.HasRows)
            varMi = true;
        conn.Close();
        return varMi;
        */
        
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        DataSet sonuc = new DataSet();
        conn.Open();
        adaptor.Fill(sonuc);
        conn.Close();
        bool varMi = false;
        if (sonuc.Tables[0].Rows.Count > 0)
            varMi = true;
        return varMi;
    }

    public static DataSet DersCek()
    {
        string sql = "select * from Dersler";
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet Sonuclar = new DataSet();
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(Sonuclar);
        conn.Close();
        return Sonuclar;
    }
    public static void Ekle (int OgrNo,string dersKodu)
    {
        string sql = "insert into Notlar(OgrNo,DersID) values (@pNo,@pDid)";
        SqlCommand komut = new SqlCommand(sql, conn);
        komut.Parameters.AddWithValue("@pNo", OgrNo);
        komut.Parameters.AddWithValue("@pDid", dersKodu);
        conn.Open();
        komut.ExecuteNonQuery();
        conn.Close();
    }

    public static DataSet NotlariCek(int ogrNo)
    {
        string sql = "select DersAdi, Vize, Final, (Vize*0.4+Final*0.6) as Ort from Notlar inner join Dersler on Dersler.DersID=notlar.dersId where OgrNo="+ogrNo;
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet Notlar = new DataSet();
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(Notlar);
        conn.Close();
        return Notlar;
    }
}
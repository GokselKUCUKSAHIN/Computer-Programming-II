using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project_38
{
    class DBIslemleri
    {
        static string DBYolu = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ERU\Bilgisayar Programlama II\c#\Hafta 11\DB\TelRehDB.mdf;Integrated Security=True;Connect Timeout=30"; //@ escape Char
        
        public static DataSet UlkeleriCek()
        {
            //1. veritanina bağlanti nesnesi oluştur SqlConnection
            SqlConnection conn = new SqlConnection(DBYolu);
            //2. sql ifadesini tanımlayan nesneyi oluştur SqlCommand
            string sql = "select * from Ulkeler";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = conn;
            //SqlCommand komut = new SqlCommand(sql, conn); 

            //3. sonucları tutacak DataSet tanımı
            DataSet ulkeler = new DataSet();
            //4. SqlCommandi calistirip datasete yukleyecek aracı, SqlDataAdapter
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            conn.Open();
            adaptor.Fill(ulkeler);
            conn.Close();
            return ulkeler;
        }
        public static DataSet SehirleriCek(int ulkeID)
        {
            SqlConnection conn = new SqlConnection(DBYolu);
            string sql = "select * from Sehirler where UlkeID=" + ulkeID;
            SqlCommand komut = new SqlCommand(sql, conn);
            DataSet sehirler = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            conn.Open();
            adaptor.Fill(sehirler);
            conn.Close();
            return sehirler;
        }
        public static void Ekle(string a,string s,string t,int sehirID,string adr)
        {
            SqlConnection conn = new SqlConnection(DBYolu);
            string sql = "insert into Kisiler(Adi,Soyadi,Telefon,SehirID,Adres)";
            sql += " values (@pa,@ps,@pt,@psid,@padr)";
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@pa", a);
            komut.Parameters.AddWithValue("@ps", s);
            komut.Parameters.AddWithValue("@pt", t);
            komut.Parameters.AddWithValue("@psid", sehirID);
            komut.Parameters.AddWithValue("@padr", adr);
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
        }
        public static DataSet Arama(string isim)
        {
            isim += "%";
            SqlConnection conn = new SqlConnection(DBYolu);
            string sql = "select * from Kisiler where Adi like @pa";
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@pa", isim);
            DataSet sonuclar = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            conn.Open();
            adaptor.Fill(sonuclar);
       
            conn.Close();
            return sonuclar;
        }
        public static void Duzenle(int KisiID,string Yenia,string Yenis,string Yenit,string Yeniadr)
        {
            SqlConnection conn = new SqlConnection(DBYolu);
            string sql = "update Kisiler set Adi=@pa,Soyadi=@ps,Telefon=@pt,Adres=@padr where KisiID= @pid";
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@pa", Yenia);
            komut.Parameters.AddWithValue("@ps", Yenis);
            komut.Parameters.AddWithValue("@pt", Yenit);
            komut.Parameters.AddWithValue("@padr", Yeniadr);
            komut.Parameters.AddWithValue("@pid", KisiID);
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
        }
        public static void Sil(int KisiID)
        {
            SqlConnection conn = new SqlConnection(DBYolu);
            string sql = "delete from Kisiler where KisiID=" + KisiID;
            SqlCommand komut = new SqlCommand(sql, conn);
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
        }
    }
}

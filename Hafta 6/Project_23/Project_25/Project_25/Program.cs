using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //List <Tur> ListeIsmi = new List<Tur>();
            List <string> liste = new List<string>();
            liste.Add("ali");
            liste.Add("ayşe");
            liste.Add("mehmet");
            liste.Add("deniz");
            liste.Add("fatma");
            liste.Add("gamze");
            liste.Add("nusret");

            List<string> sonuclar = new List<string>();
            for (int i = 0; i < liste.Count; i++)
            {
                if(liste[i].Contains("et") == true)
                {
                    sonuclar.Add(liste[i]);
                }
            }
            Console.WriteLine("Sonuclar");
            foreach (string a in sonuclar)
            {
                Console.WriteLine(a);
            }
        }
        /*
        public string Pozitif(int a) => a.ToString();
        */
    }
}

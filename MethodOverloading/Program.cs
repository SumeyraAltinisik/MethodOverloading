using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad,cevap;
            Console.WriteLine("Lütfen adınızı giriniz.");
            ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı giriniz.(isteğe bağlı)");
            soyad = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(soyad))
            {
             cevap=   Mesaj(ad);
            }
            else
             cevap=   Mesaj(ad, soyad);
            Console.WriteLine(cevap);
            Console.ReadKey();
        }

        static string Mesaj(string ad)
        {
            string ilkHarf = ad.Substring(0, 1);
            string kelimeninDevami = ad.Substring(1);
            ilkHarf = ilkHarf.ToUpper();
            kelimeninDevami = kelimeninDevami.ToLower();
            string metin = "Sevgili " + ilkHarf + kelimeninDevami + ", sistemimize hoşgeldiniz.";
            return metin;

        }

        static string Mesaj(string ad, string soyad)
        {
            string x = ad.Substring(0, 1);
            x = x.ToUpper();
            string y = ad.Substring(1);
            y = y.ToLower();

            string z = soyad.Substring(0, 1).ToUpper();
            string t = soyad.Substring(1).ToLower();
            string metin = "Sevgili " + x + y + " " + z + t + ", sistemimize holgeldiniz.";
            return metin;
        }

    }
}

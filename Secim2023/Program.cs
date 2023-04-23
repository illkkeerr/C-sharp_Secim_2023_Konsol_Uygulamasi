using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secim2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cumhurbaskani ahmet = new Cumhurbaskani("ahmet", "aslan", 55);
            Cumhurbaskani mehmet = new Cumhurbaskani("mehmet", "kısa", 25);
            Milletvekili fatih = new Milletvekili("fatih", "polat", 26);
            Milletvekili beyza = new Milletvekili("beyza", "daldal", 22);
            Vatandas furkan = new Vatandas("furkan", "ertantu", 26);
            Vatandas akif = new Vatandas("akif", "sezer", 53);
            Vatandas sezgin = new Vatandas("sezgin", "bezgin", 17);
            Vatandas ilker = new Vatandas("ilker", "şenel", 26);



            ahmet.OyKullan(beyza, ahmet);
            mehmet.OyKullan(beyza, mehmet);
            beyza.OyKullan(beyza, ahmet);
            fatih.OyKullan(fatih, mehmet);
            ilker.OyKullan(fatih, mehmet);
            furkan.OyKullan(fatih, mehmet);
            akif.OyKullan(fatih, ahmet);
            sezgin.OyKullan(fatih, mehmet);


            Secim2023.CbEkle(mehmet);
            Secim2023.CbEkle(ahmet);
            Secim2023.MvEkle(beyza);
            Secim2023.MvEkle(fatih);

            Secim2023.SonucGoster();

            Console.ReadLine();
        }       
    }
    interface IAd
    {
        string Ad { get; set; }
    }
    interface ISoyad
    {
        string Soyad { get; set; }
    }
    interface IYas
    {
        int Yas { get; set; }
    }
    interface IOyKullanabilme
    {
        void OyKullan(Milletvekili mv, Cumhurbaskani cb);
    }
    interface IOySayisi
    {
        int OySayisi { get; set; }
    }
}

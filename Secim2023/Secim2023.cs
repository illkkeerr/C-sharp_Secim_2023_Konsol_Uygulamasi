using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secim2023
{
    internal static class Secim2023
    {
        public static List<Cumhurbaskani> CbAdaylar = new List<Cumhurbaskani>();

        public static List<Milletvekili> MvAdaylar = new List<Milletvekili>();

        public static void CbEkle(Cumhurbaskani cb)
        {
            CbAdaylar.Add(cb);
        }
        public static void MvEkle(Milletvekili mv)
        {
            MvAdaylar.Add(mv);
        }
        public static void SonucGoster()
        {
            int mvOysayisi = 0;
            string mvAdi = "";
            string mvSoyadi = "";
            int cbOysayisi = 0;
            string cbAdi = "";
            string cbSoyadi = "";
            foreach (var item in MvAdaylar)
            {

                if (item.OySayisi > mvOysayisi)
                {
                    mvOysayisi = item.OySayisi;
                    mvAdi = item.Ad;
                    mvSoyadi = item.Soyad;
                }

            }
            foreach (var item in CbAdaylar)
            {

                if (item.OySayisi > cbOysayisi)
                {
                    cbOysayisi = item.OySayisi;
                    cbAdi = item.Ad;
                    cbSoyadi = item.Soyad;
                }

            }
            if(mvOysayisi != 0)
            Console.WriteLine($"{mvAdi} {mvSoyadi} {mvOysayisi} oy ile milletvekili olmuştur tebrikler");
            if(cbOysayisi != 0)
            Console.WriteLine($"{cbAdi} {cbSoyadi} {cbOysayisi} oy ile cumhurbaşkanı olmuştur tebrikler");
        }
    }
}

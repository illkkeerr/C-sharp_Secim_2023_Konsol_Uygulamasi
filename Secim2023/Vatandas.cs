using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secim2023
{
    internal class Vatandas : Vatandas_
    {
        public override string Ad { get; set; }
        public override string Soyad { get; set; }
        public override int Yas { get; set; }

        public Vatandas()
        {

        }
        public Vatandas(string ad, string soyad, int yas)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Yas = yas;
        }

        public override void OyKullan(Milletvekili mv, Cumhurbaskani cb)
        {
            if (this.Yas >= 18)
            {
                if (mv.Yas >= 18)
                {
                    mv.OySayisi++;

                }
                if (cb.Yas >= 18)
                {
                    cb.OySayisi++;
                }
            }

            else
            {
                Console.WriteLine($"{this.Ad} {this.Soyad} yaşı 18'den küçük olduğu için oy kullanamaz");
            }
        }
    }
}

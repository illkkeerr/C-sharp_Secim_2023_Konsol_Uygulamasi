using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Secim2023
{
    internal class Cumhurbaskani : Vatandas_, IOySayisi
    {
        public override string Ad { get; set; }
        public override string Soyad { get; set; }

        public override int Yas { get; set; }
        public int OySayisi { get; set; }

        public Cumhurbaskani()
        {

        }
        public Cumhurbaskani(string ad, string soyad, int yas)
        {
            try
            {
                if (yas >= 18)
                {
                    this.Ad = ad;
                    this.Soyad = soyad;
                    this.Yas = yas;
                }
                else
                {
                    throw new Exception("18 yaşından küçük cumhurbaşkanı adayı olamaz");
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);               
            }
           
        }
        public override void OyKullan(Milletvekili mv, Cumhurbaskani cb)
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
    }
}

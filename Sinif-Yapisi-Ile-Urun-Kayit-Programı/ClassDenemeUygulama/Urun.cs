using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDenemeUygulama
{
    class Urun
    {

        
        private int Fiyat__;
        public int Fiyat
        {
            get 
            {
                return Fiyat__;
            }
            set 
            {
                if (value < 0 || value > 9)
                    Fiyat__ = -1;
                else
                    Fiyat__ = value;
            }
        }

        private DateTime TETT__;
        public DateTime TETT
        {
            get
            {
                return TETT__;
            }
            set 
            {
                if (value < DateTime.Now)
                    TETT__ = DateTime.Now;
                else
                    TETT__ = value;
                   
            }
        }

        private int Adet__;
        public int Adet
        {
            get
            {
                return Adet__;
            }
            set
            {
                if(value < 0 || value > 9)
                    Adet__ = -1;
                else
                   Adet__ = value;
            }
        }

        private string Marka__;
        public string Marka
        {
            get 
            {
                return Marka__;
            }
            set
            {
                if (value == null)
                    Marka__ = "Girilmedi";
                else
                    Marka__ = value;
            }
        }

      
        public DateTime EklemeSaati
        {
            get 
            {
                return DateTime.Now;
            }
        }
        

    }
}

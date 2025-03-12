using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022330096
{
    internal class KodeProduk
    {
        
        public enum Produk {Laptop, Smartphone, Tablet, Headset, Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera} //enum untuk produk

        

        public static string getKodeProduk(Produk produk)
        {
            string[] kodeProduk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" }; //arary untuk value kode produk dari produk 
            return kodeProduk[(int)produk]; //return dari array kodeProduk berdasarkan index enum produk
        }


    }
}

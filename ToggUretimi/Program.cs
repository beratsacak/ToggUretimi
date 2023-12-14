using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOGGURETIMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program başladı.");
            Otomobil oto = new Otomobil();
            Console.WriteLine("Program bitti.");
        }
    }
    class Otomobil
    {
        string marka = "";
        string renk = "";
        public Otomobil()
        {
            marka = "TOGG";
            renk = "PEMBE";
            Console.WriteLine("yapıcı metot çalıştı");
        }
        ~Otomobil()
        {
            Console.WriteLine("nesne hafızadan atıldı");

        }
    }

}
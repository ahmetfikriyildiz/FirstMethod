using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NameSurname("Ahmet Fikri", "YILDIZ");
            Add(3,4);
            RandomGenerator();
            Returnless();
        }
        static void NameSurname(string isim,string soyisim)
        {
            Console.WriteLine($"Hoşgeldiniz {isim} {soyisim} ");
        }
        static int Add (int x, int y)
        {
            int sonuc = x * y;
            Console.WriteLine("\nÇarpımın sonucu = "+sonuc); 
            return sonuc;
        }
        static int RandomGenerator ()
        {
            Random random = new Random();
            int sonuç = random.Next(0, 100) / 2;
            Console.WriteLine("\nRandom değer = " + sonuç);
            return sonuç;
        }
        static void Returnless() 
        {
            Console.WriteLine("\nKendime Yalan söyledim ...");
            Console.ReadLine();
        }
    }
}

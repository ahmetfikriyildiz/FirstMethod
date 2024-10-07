using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMethod
{
    internal class Program
    {
        // Bu Uygulama İçerisinde 4 adet metot yöntemi gösterdim.
        // 1->Geriye Değer Döndürmeyen Bir void metot.
        // 2->Geriye Tamsayı Döndüren Bir metot
        // 3->Parametre Alan ve Geriye Değer Döndüren Bir Metot
        // 4->Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsol_hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, sonuc;
            char isaret;
            Console.Write("Birinci Sayıyı Giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İşleminizi Seçiniz ( * / - + % ) ");
            isaret = Convert.ToChar(Console.ReadLine());

            if (isaret == '*')
            {
                sonuc = s1 * s2;
                Console.WriteLine(sonuc);
            }
            else if (isaret == '/')
            {
                sonuc = s1 / s2;
                Console.WriteLine(sonuc);
            }
            else if (isaret == '-')
            {
                sonuc = s1 - s2;
                Console.WriteLine(sonuc);
            }
            else if (isaret == '+')
            {
                sonuc = s1 + s2;
                Console.WriteLine(sonuc);
            }
            else if (isaret == '%')
            {
                sonuc = s1 % s2;
                Console.WriteLine(sonuc);
            }
            else
            {
                Console.WriteLine("Yanlış Bir İşlem Seçtiniz!");
            }
            Console.ReadKey();
        }
    }
}

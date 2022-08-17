using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            //Console.Write("KISA KENARI GİR: ");
            //int kisa = int.Parse(Console.ReadLine());

            //Console.Write("UZUN KENARI GİR: ");
            //int uzun = int.Parse(Console.ReadLine());

            //Console.WriteLine("Alan :" + kisa * uzun);


            //OPERATORS
            //int x = 2, y = 5, z = 10;
            //Console.Write("iki sayı giriniz: ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //int sayi2 = int.Parse(Console.ReadLine());

            //int fark1 = (sayi1 * sayi2) - (x + y + z);
            //Console.WriteLine("Fark: "+fark1);

            //bool tek = true;
            //if(fark1 %2 == 0)
            //{
            //    tek = false;
            //}
            //else
            //{
            //    tek = true;
            //}
            //Console.WriteLine("sayı tek mi?: " + tek);

            //float mod = (x + y + z) % 3;
            //Console.WriteLine("mod: "+mod);

            //Console.WriteLine("y'nin x'inci kuvveti: "+Math.Pow(y, x));




            //FOR LOOP
            //Console.Write("start: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("end: ");
            //int end = int.Parse(Console.ReadLine());
            //Console.Write("increase: ");
            //int increase = int.Parse(Console.ReadLine());

            //for(int i = start; i <= end; i = i + increase)
            //{
            //    Console.WriteLine(i);
            //}


            // ASAL SAYILAR

            //int k = 1;
            //while (k <= 3) 
            //{
            //    Console.Write("sayı gir: ");
            //    int sayi = int.Parse(Console.ReadLine());
            //    bool control = true;
            //    if (sayi == 1 || sayi==0)
            //    {
            //        Console.WriteLine("0 VEYA 1 GİRDİNİZ SAYI ASAL DEĞİL");
            //        break;
            //    }
            //    for (int i = 1; i <= sayi; i++)
            //    {
            //        if (!(i == 1 || i == sayi))
            //        {
            //            if (sayi % i == 0)
            //            {
            //                control = false;
            //                break;
            //            }

            //        }
            //    }
            //    if (control == false)
            //    {
            //        Console.WriteLine("SAYI ASAL DEGİL");
            //    }
            //    else
            //        Console.WriteLine("SAYI ASAL");
            //    k++;
            //}


            //LOOP VE IF BLOKLARIYLA RANDOM SAYI TAHMİNİ

            //Random random = new Random();
            //int rnd = random.Next(1, 100);
            //bool flag = false;
            //while (flag == false)
            //{
            //    Console.Write("Tahmin: ");
            //    int tahmin = int.Parse(Console.ReadLine());

            //    if (tahmin == rnd)
            //    {
            //        Console.WriteLine("doğru tahmin..");
            //        flag = true;
            //    }
            //    else if (tahmin > rnd)
            //        Console.WriteLine("azalt");
            //    else
            //        Console.WriteLine("yükselt");
            //}



        }
    }
}

using System;
using System.Collections;
using System.ComponentModel;

namespace Koleksiyonlar_Soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ve sayıdan bi küçük olana kadar döngü oluşturulur ve bir sayaç tanımlanır eğer toplamda bölünen sayı 2 den büyük ise asal değildir.
                        
            ArrayList asalSayı = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();
            float asalToplam = 0;
            float asalOlmayanToplam = 0;
            
            
            int[] sayilar = new int[20];
            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayac = 0;

                Console.WriteLine("Dizinin {0}. elemanını giriniz.", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
                while (sayilar[i] < 0)
                {
                    Console.WriteLine("Negatif bir sayı girdiniz lütfen pozitif bir sayı giriniz:");
                    sayilar[i] = int.Parse(Console.ReadLine());
                }

                for (int j = 1; j <= sayilar[i]; j++)
                {
                    if (sayilar[i] % j == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac >= 3 || sayilar[i] == 1)
                {
                    asalOlmayan.Add(sayilar[i]);
                    asalOlmayanToplam += sayilar[i];
                }
                if (sayac<=2 && sayilar[i] != 1)
                {
                    asalSayı.Add(sayilar[i]);
                    asalToplam += sayilar[i];

                }
            }
            asalSayı.Sort();
            asalOlmayan.Sort();

            foreach (var asal in asalSayı)
            {
                Console.Write("Asal sayı listesi:");
                Console.WriteLine(asal);
            }
            foreach (var a in asalOlmayan)
            {
                Console.Write("Asal olmayan sayılar listesi:");
                Console.WriteLine(a);
            }

            Console.Write("Asal sayı dizisinin eleman sayısı : {0}",asalSayı.Count);
            Console.Write(" Ortalama : {0} ",asalToplam / asalSayı.Count);

            Console.WriteLine();

            Console.Write(" Asal sayı dizisinin eleman sayısı : {0}", asalOlmayan.Count);
            Console.Write(" Ortalama : {0} ", asalOlmayanToplam / asalOlmayan.Count);




        }
    }
}

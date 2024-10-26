using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // kahve isimlerini saklamak icin liste olusturma
        List<string> kahveListesi = new List<string>();

        // kullanicidan 5 kahve ismi alma
        Console.WriteLine("Lütfen 5 kahve ismi giriniz:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Kahve {i + 1}: ");
            string kahveIsmi = Console.ReadLine();
            kahveListesi.Add(kahveIsmi);
        }

        // girilen kahve isimlerini ekrana yazdirma
        Console.WriteLine("\nGirdiğiniz kahve isimleri:");
        foreach (string kahve in kahveListesi)
        {
            Console.WriteLine(kahve);
        }

        Console.ReadKey();
    }
}

using System;
using System.Collections;

namespace soru1{
class Program {

    public static void Main (String [] args){

        ArrayList  asallar = new ArrayList();
        ArrayList  asalOlmayanlar = new ArrayList();


        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine((i+1)+". sayıyı giriniz");
            int k = int.Parse(Console.ReadLine());
             if(asalmi(k))
                asallar.Add(k);
             else
                asalOlmayanlar.Add(k);   

        }
        asalOlmayanlar.Sort();
        asallar.Sort();
        Console.WriteLine("Asal SAyılar");
        foreach (var item in asallar)
        {
            Console.Write(item+"-");
        }
        Console.WriteLine("Asal olmayan Sayılar");
        foreach (var item in asalOlmayanlar)
        {
            Console.Write(item+"-");
        }

        Console.WriteLine("********");
        int asaleleman = asallar.Count;
        int asalolmayan = asalOlmayanlar.Count;
        int asaltoplam =0, asalolmayantoplam=0;
        Console.WriteLine("Asal Sayılar toplamı"+asaleleman);
        Console.WriteLine("Asal Olmayan Sayılar toplamı"+asalolmayan);
        Console.WriteLine("********");
        foreach (var item in asallar)
        {
           asaltoplam += (int)item;
        }
        foreach (var item in asalOlmayanlar)
        {
           asalolmayantoplam += (int)item;
        }
        Console.WriteLine("Asal ortalam"+(asaltoplam/asaleleman));
        Console.WriteLine("Asal olmayan ortalama"+(asalolmayantoplam/asalolmayan));

    }
    static bool asalmi(int sayi)
    {
      for (int i = 2; i <= sayi / 2; i++)
        if (sayi % i == 0)
          return false;

      return true;
    }

}

}
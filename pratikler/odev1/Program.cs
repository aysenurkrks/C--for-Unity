using System;

namespace odev1{
class Program {


    public static void Main (String [] args){

        Console.WriteLine("************ soru 1 **********");
        Console.WriteLine("Lütfen  sayı giriniz");
        int deger = int.Parse(Console.ReadLine());
        int [] sayilar = new int[deger];
        int eleman;
        for (int i = 0; i < deger; i++)
        {
            Console.WriteLine("Lütfen "+(i+1)+". değeri giriniz");
            eleman = int.Parse(Console.ReadLine());
            sayilar[i]=eleman;
        }

        foreach (var item in sayilar)
        {
            if(item%2==0) Console.WriteLine(item);
        }

        Console.WriteLine("************ soru 2 **********");
        Console.WriteLine("Lütfen iki sayı giriniz");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int [] sayilar2 = new int[n];
        int eleman2;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Lütfen "+(i+1)+". değeri giriniz");
            eleman2 = int.Parse(Console.ReadLine());
            sayilar2[i]=eleman2;
        }
        foreach (var item in sayilar2)
        {
            if(m%item==0 || item==0) Console.WriteLine(item);
            
        }

        Console.WriteLine("************ soru 3 **********");
        Console.WriteLine("Lütfen kelime sayısını giriniz");
        int kelimeSayisi = int.Parse(Console.ReadLine());
        string [] kelimeler =new string[kelimeSayisi];
                string kelime;
        for (int i = 0; i < kelimeSayisi; i++)
        {
            Console.WriteLine("Lütfen "+(i+1)+". kelimeyi giriniz");
            kelime = Console.ReadLine();
            kelimeler[i]=kelime;
        }
        for(int i=kelimeSayisi-1; i>=0;i--){
            Console.WriteLine(kelimeler[i]);
        }
        
        Console.WriteLine("************ soru 4 **********");
        Console.WriteLine("Lütfen cümlenizi giriniz");
        string cumle=Console.ReadLine();
        string[] parcalanmisCumle = cumle.Split(' ');
         int toplam = 0;

        foreach (string cumleler in parcalanmisCumle)
        {
            toplam += cumleler.Length;
        }
        Console.WriteLine("Toplam harf sayısı: " + toplam);
        Console.WriteLine("Toplam kelime sayısı: " + cumle.Split().Length);





    }
}

}
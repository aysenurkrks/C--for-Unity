using System;

namespace diziler{
class Program {

    public static void Main (String [] args){

        string [] renkler = new string[5];
        string [] hayvanlar = {"aslan", "kedi", "karga", "kuş"};
        int [] dizi;
        dizi = new int[5];
        renkler[0]="mavi";
        dizi[3]=10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);
       

        //Döngüler ile dizi

        Console.WriteLine("Dizinin boyutu ne olsun?");
        int [] sayilar = new int[int.Parse(Console.ReadLine())];

        for(int i =0; i<sayilar.Length;i++){
            Console.WriteLine((i+1)+". sayıyı giriniz");
            sayilar[i]=int.Parse(Console.ReadLine());

        }
        int toplam=0;
        foreach (var sayi in sayilar)
        {
            toplam+=sayi;
        }
        Console.WriteLine(toplam/sayilar.Length);





    }
}

}
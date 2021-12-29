using System;
using System.Collections.Generic;

namespace genericList{
class Program {
    public static void Main (String [] args){

        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(5);
        sayiListesi.Add(12);
        sayiListesi.Add(25);
        sayiListesi.Add(24);
        sayiListesi.Add(13);
        sayiListesi.Add(9);
        sayiListesi.Add(8);

        List<string> renkler = new List<string>();
        renkler.Add("sari");
        renkler.Add("MAvi");
        renkler.Add("Kırmızı");
        renkler.Add("Turuncu");
        renkler.Add("Yeşil");

        //Count
        Console.WriteLine(renkler.Count);
        Console.WriteLine(sayiListesi.Count);

        foreach (var renk in renkler)
        {
            Console.WriteLine(renk);
        }
         foreach (var sayi in sayiListesi)
        {
            Console.WriteLine(sayi);
        }

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        
        renkler.ForEach(renk => Console.WriteLine(renk));

        sayiListesi.Remove(5);
        renkler.Remove("sari");
        
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));        
        renkler.ForEach(renk => Console.WriteLine(renk));

        sayiListesi.RemoveAt(0);
        renkler.RemoveAt(1);
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));        
        renkler.ForEach(renk => Console.WriteLine(renk));

        //arama
        if(sayiListesi.Contains(24)){
            Console.WriteLine("bulundu");
        }

        Console.WriteLine(renkler.BinarySearch("Turuncu"));

        //Diziyi liste çevirme
        string[] hayvanlar= {"kedi","kopek","kus"};
        List<string> hayvanlarListesi = new List<string>(hayvanlar);

        //List temizleme

        hayvanlarListesi.Clear();

        //List çevirisinde nesne tutmak
        List<kullanici> kullaniciListesi = new List<kullanici>();
        kullanici kullanici1 = new kullanici();
        kullanici1.Isim = "Ayşenur";
        kullanici1.Soyisim="Krks";
        kullanici1.Yas=27;

        kullanici kullanici2 = new kullanici();
        kullanici2.Isim = "mustafa";
        kullanici2.Soyisim="grbz";
        kullanici2.Yas=29;

        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);

        List<kullanici> yeniListe = new List<kullanici>();
        yeniListe.Add(new kullanici(){
            Isim="Deniz",
            Soyisim="arda",
            Yas=24

        });

        foreach (var kullanicilar in kullaniciListesi)
        {
            Console.WriteLine("Kullanıcı adı :"+ kullanicilar.Isim);
            Console.WriteLine("Kullanıcı soyadı :"+ kullanicilar.Soyisim);
            Console.WriteLine("Kullanıcı yaş :"+ kullanicilar.Yas);
        }





    }
}


public class kullanici{
    private string isim;
    private string soyisim;
    private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }

}
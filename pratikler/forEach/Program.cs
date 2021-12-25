using System;

namespace forEach{
class Program {

    public static void Main (String [] args){

//sayı dahil ort. hesaplama

        Console.WriteLine("sayı Giriniz");
        int sayi = int.Parse(Console.ReadLine());
        int sayac =1;
        int toplam=0;
        while(sayac<=sayi){
            toplam+=sayac;
            sayac++;

        }
        Console.WriteLine("ortalama = "+(toplam/sayi));
         // tüm harfleri yazdırma
        char karakter = 'a';

        while(karakter < 'z'){
            Console.Write(karakter);
            karakter++;
        }

        Console.WriteLine("**************** for each  ************");

        string [] arabalar = {"BMW", "VOLVO", "FORD", "MERCEDES"};

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
            
        }



    }
}

}
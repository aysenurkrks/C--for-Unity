using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList{
class Program {

    public static void Main (String [] args){

       ArrayList liste= new ArrayList();
    //    liste.Add("Ayşenur");
    //    liste.Add(2);
    //    liste.Add(true);
    //    liste.Add('b');

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }
        //addrange
        Console.WriteLine("******* AddRange********");
     //   string [] renkler = {"kırmızı", "mavi", "pembe","turuncu"};
        List<int> sayilar = new List<int>(){1,56,98,416,2,3,6,5,45};
       // liste.AddRange(renkler);
        liste.AddRange(sayilar);


        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //sort

        Console.WriteLine("******* Sort********");
        liste.Sort();
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //Binary serach
        Console.WriteLine("******* Binary Serach********");
        Console.WriteLine(liste.BinarySearch(56));

        //Reverse
        Console.WriteLine("******* Reverse********");
        liste.Reverse();
         foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        liste.Clear();
         foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

    }
}

}
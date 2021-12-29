using System;
using System.Collections.Generic;

namespace dictionary{
class Program {

    public static void Main (String [] args){

        Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
        kullanicilar.Add(10,"aysenur krks");
        kullanicilar.Add(11,"mstf grbz");
        kullanicilar.Add(15,"özcan coşar");

        //Erişim

        Console.WriteLine("********** erişim *******");
        foreach (var item in kullanicilar)
        {
            Console.WriteLine(item);
            
        }

        //Count

        Console.WriteLine("********** count *******");
        Console.WriteLine(kullanicilar.Count);
       //Contains
      Console.WriteLine("*** Contains ***");
      Console.WriteLine(kullanicilar.ContainsKey(16));
      Console.WriteLine(kullanicilar.ContainsValue("Ayşenur"));

      //Eleman çıkarma
      Console.WriteLine("*** Remove ***");
      kullanicilar.Remove(20);
      foreach (var item in kullanicilar)
        Console.WriteLine(item);

      //Keys
      Console.WriteLine("*** Keys ***");
      foreach(var item in kullanicilar.Keys)
        Console.WriteLine(item);
      //Values
      Console.WriteLine("*** Values ***");
      foreach (var item in kullanicilar.Values)
        Console.WriteLine(item);

    }
}

}
using System;

namespace arraySinifi{
class Program {

    public static void Main (String [] args){

        //sort
        int [] sayilar = {22,54,98,63,45,71,2,36,54,15};

        Console.WriteLine("sırasız liste");
        foreach (var sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }
        
        
        Console.WriteLine("sıralı liste");
        Array.Sort(sayilar);

        foreach (var sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }


        //Clear
        Console.WriteLine("Array clear");
        Array.Clear(sayilar,2,2);
        foreach (var sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }


        //Reverse 
        
        Console.WriteLine("Array Reverse");

        Array.Reverse(sayilar);

        foreach (var sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        
        //indexof 
        
        Console.WriteLine("Array indexOf");        
        
        Console.WriteLine(Array.IndexOf(sayilar, 45));

        
        //Resize 
        
        Console.WriteLine("Array resize"); 
        Array.Resize<int>(ref sayilar,5);
        foreach (var sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }


        
       

    }
}

}
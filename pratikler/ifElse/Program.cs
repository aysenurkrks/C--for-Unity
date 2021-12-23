using System;

namespace ifElse {
class Program {

    public static void Main (String [] args){


        int time =DateTime.Now.Hour;

        if(time>=6 && time <11)
            Console.WriteLine("Günaydın");

        else if(time <= 18)
            Console.WriteLine("iyi günler");
        
        else
            Console.WriteLine("İyi Geceler");
       
       string sonuc = time<=18 ? "İyi günler" : "İyi geceler";

       sonuc= time>=6 && time <=14 ? "<günaydın" : time<=18 ? "iyigünler" : "İyi geceler";
       Console.WriteLine(sonuc);


    }
}

}
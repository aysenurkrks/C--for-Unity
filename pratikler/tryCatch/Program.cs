using System;

namespace tryCatch {
class Program {

    public static void Main (String [] args){


        try
       {
             Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen sayı : "+ sayi);
        }
        catch (Exception ex) {
            Console.WriteLine("Hata : "+ ex.Message.ToString());
        }
       // finally
   // {
                
      //     Console.WriteLine("İşlem tamamlandı");

      //  }

        try
        {
            // int a = int.Parse(null);
            //int a = int.Parse("test");
            int a = int.Parse("-95647823654");
        }
        catch (ArgumentNullException ex)
        {
            
           Console.WriteLine("Boş değer girdiniz");
           Console.WriteLine(ex); 

        }
        catch (FormatException ex)
        {
            
           Console.WriteLine("veri tipi uygun değil");
           Console.WriteLine(ex); 

        }
        catch (OverflowException ex)
        {
            
           Console.WriteLine("Çok küçük ve ya çok büyük bir değer");
           Console.WriteLine(ex); 

        }
        finally{
            Console.WriteLine("işlem başarılı");
        }
       

    }
}

}
using System;

namespace soru3{
class Program {


    public static void Main (String [] args){
      List<char> vowels = new List<char>();
      Console.WriteLine("Lütfen bir cümle giriniz: ");
      string sentence = Console.ReadLine().ToLower();
      char[] splitted = sentence.ToCharArray();
      for (int i = 0; i < splitted.Length; i++)
      {
        if (splitted[i] == 'a' || splitted[i] == 'e' || splitted[i] == 'ı' || splitted[i] == 'i' || splitted[i] == 'o' || splitted[i] == 'ö' || splitted[i] == 'u' || splitted[i] == 'ü')
        {
          vowels.Add(splitted[i]);
        }
      }

      vowels.Sort();

      foreach (var item in vowels)
      {
        Console.WriteLine(item);
      }
        

}

}
}
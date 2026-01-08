using System;
class Program
{
      public static void Main(string[] args)
    {
        Console.WriteLine("Enter The name ");
        string name = Console.ReadLine();
       
       int VowelCount = name.ToLower().Count(c=> "aeiou".Contains(c));
       Console.WriteLine(VowelCount);
    //    foreach(char c in name.ToLower())
    //     {
    //         if(c=='a' || c=='e' || c=='i' ||c == 'o' || c == 'u')
    //         {
    //             VowelCount++;

    //         }
    //     }
    // foreach(char c in name.ToLower())
    //     {
    //         if ("aeiou".Contains(c))
    //         {
    //             VowelCount++;
    //             Console.WriteLine($"Found Vowel : {c} | Total So far{VowelCount}");
    //         } 
    //     }
    //    Console.WriteLine($"Vowel in this name : {VowelCount} ");
        
    // }
    }

}
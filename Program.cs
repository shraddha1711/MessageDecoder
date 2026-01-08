using System;
class Program
{
      public static void Main(string[] args)
    {
    //     Console.WriteLine("Enter The name ");
    //     string name = Console.ReadLine();
       
    //    int VowelCount = name.ToLower().Count(c=> "aeiou".Contains(c));
    //    Console.WriteLine(VowelCount);
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

       Console.WriteLine("Enter THe Size");
       int n = Convert.ToInt32(Console.ReadLine());
       int[] trasures = new int[n];
       for(int i = 0; i < n; i++)
        {
            trasures[i] = Convert.ToInt32(Console.ReadLine());
        }
    //    int max = trasures[0]; 

    //     for(int i = 0; i < n; i++)
    //     {
    //         if(trasures[i] > max)
    //         {
    //             max = trasures[i];
    //         }
    //     }
    int max = trasures.Max();
        Console.WriteLine(max);

    }

}
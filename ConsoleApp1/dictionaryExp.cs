using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class dictionaryExp
    { 


        static void Main()
    {
      
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

      
        dictionary.Add("Apple", 1);
        dictionary.Add("Banana", 2);
        dictionary.Add("Cherry", 3);
        dictionary.Add("Date", 4);
        dictionary.Add("Elderberry", 5);
        dictionary.Add("Fig", 6);
        dictionary.Add("Grape", 7);
        dictionary.Add("Honeydew", 8);
        dictionary.Add("Iced Berry", 9);
        dictionary.Add("Jackfruit", 10);

        Console.WriteLine("Dictionary elements:");
        foreach (var item in dictionary)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        dictionary["Apple"] = 11;
        Console.WriteLine("\nModified 'Apple' value:");
        Console.WriteLine($"Apple: {dictionary["Apple"]}");

        dictionary.Remove("Banana");
        Console.WriteLine("\nDictionary after removing 'Banana':");
        foreach (var item in dictionary)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        if (dictionary.ContainsKey("Cherry"))
        {
            Console.WriteLine("\nCherry exists in the dictionary.");
        }

       
        dictionary.Clear();
        Console.WriteLine("\nDictionary after clearing:");
        Console.WriteLine(dictionary.Count == 0 ? "Dictionary is empty." : "Dictionary still has elements.");
    }
}
}

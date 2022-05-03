using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary = File.ReadLines("dictionary.csv").Select(line => line.Split(',')).ToDictionary(line => line[0], line => line[1]);

            while (true)
            {
                Console.Write("Insert word to translate or type exit : ");
                var word = Console.ReadLine();

                if (word.Equals("exit"))
                {
                    break;
                }

                string value;
                bool isTranslatable = dictionary.TryGetValue(word, out value);

                Console.WriteLine( word + " -> " + (isTranslatable ? value : "can't translate") );
            }

        }
    }
}

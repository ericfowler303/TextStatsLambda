using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStats("When literature student Anastasia Steele goes to interview young entrepreneur Christian Grey, she encounters a man who is beautiful, brilliant, and intimidating. The unworldly, innocent Ana is startled to realize she wants this man and, despite his enigmatic reserve, finds she is desperate to get close to him. Unable to resist Ana’s quiet beauty, wit, and independent spirit, Grey admits he wants her, too—but on his own terms. Shocked yet thrilled by Grey’s singular erotic tastes, Ana hesitates. For all the trappings of success—his multinational businesses, his vast wealth, his loving family—Grey is a man tormented by demons and consumed by the need to control. When the couple embarks on a daring, passionately physical affair, Ana discovers Christian Grey’s secrets and explores her own dark desires.");

            // Keep the console open
            Console.ReadLine();
        }
        static void TextStats(string input)
        {
            Console.WriteLine("Number of characters: " + input.Count());
            Console.WriteLine("Number of words: " + input.Split(' ').Count());
            Console.WriteLine("Number of vowels: " + input.Where(x => "aeiou".Contains(x)).Count());
            Console.WriteLine("Number of consonants: " + input.Where(x => "bcdfghjklmnpqrstvwxyz".Contains(x)).Count());
            Console.WriteLine("Number of special characters: " + input.Where(x => !char.IsLetter(x)).Count());
            Console.WriteLine("Longest Word: " + input.Split(' ').OrderByDescending(x => x.Length).ToArray()[0]);
            Console.WriteLine("Shortest Word: " + input.Split(' ').OrderBy(x => x.Length).ToArray()[0]);
        }
    }
}

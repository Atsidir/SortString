using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortString
{
    static class Program
    {
        public static void PrintWords(string[] words)
        {
            foreach (string word in words)
            {
                Console.Write(word);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string str = "Microsoft .NET Framework 2.0 Application Development Foundation";
            string[] words = str.Split(' ');
            Program.PrintWords(words);
            Array.Sort(words);
            Program.PrintWords(words);

            Console.WriteLine(str);
            str = string.Join(" ", words);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}

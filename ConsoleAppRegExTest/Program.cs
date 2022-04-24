using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleAppRegExTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("input.txt");

            Console.WriteLine(text);

            Regex regex = new Regex(@"[0-9]");
            MatchCollection matches = regex.Matches(text);

            for(int i = 0; i < matches.Count; i++)
            {
                Console.WriteLine(matches[i].ToString());
            }

            Console.ReadKey();
        }
    }
}

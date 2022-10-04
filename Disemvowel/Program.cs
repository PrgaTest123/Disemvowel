using System;
using System.Collections.Generic;
using System.Linq;
namespace Disemvowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a sentence: ") ;
            string str = Console.ReadLine();
            Console.WriteLine(Disemvowel(str));
        }

        public static string Disemvowel(string str)
        {
            //Best practice
            //return string.Concat(str.Where(ch=> !"aeiouAEIOU".Contains(ch)));
            
            List<char> charsToRemove = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            foreach(char c in charsToRemove)
            {
                str = str.Replace(c.ToString(), String.Empty);
            }
            return str;
        }
    }
}

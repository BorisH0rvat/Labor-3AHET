using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eingabe:");
            string eingabe = Console.ReadLine();

            char[] text = eingabe.ToArray();

            for (int i = text.Length-1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }
    }
}

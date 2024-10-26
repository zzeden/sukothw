using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_PRJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert capital letter");
            string letter = Console.ReadLine();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(letter);
            asciiBytes[0] += 32;
            string capital = Encoding.ASCII.GetString(asciiBytes);
            Console.WriteLine(capital);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPrj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int abs = Math.Abs(-9);
            int min = Math.Min(4, 2);
            int max = Math.Max(4, 2);
            //double ceiling = Math.Ceiling(34.1);
            double round = Math.Round(34.9);
            double floor = Math.Floor(34.9);

            Console.WriteLine("enter the price of the cookies");
            double price = double.Parse(Console.ReadLine());
            double ceiling = Math.Ceiling(price);
            Console.WriteLine("you have to give the cashier " + ceiling + " shekels. ");
            Console.WriteLine("and the change will be " + (ceiling - price));

        }
    }
}

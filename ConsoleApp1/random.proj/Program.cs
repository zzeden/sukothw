using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random.proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //int next = random.Next();

            Driver driverEden = new Driver();




            Console.WriteLine("how many kids are in the class?");
            int kids = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int next = rnd.Next(kids + 1);
            Console.WriteLine("kid number " + next + " will be cleaning with me today");





        }
    }

    public class Human
    {
        public string GetName() { return "blabla"; }
    }

    public class Driver: Human
    {
        public string GetCar() { return "volvo"; }
    }

}

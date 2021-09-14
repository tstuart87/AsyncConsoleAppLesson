using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Do you want to do this the easy way...or the much slower way?\n" +
                "1. Easy.\n" +
                "2. Much slower.\n");

            string reply = Console.ReadLine();

            Console.Clear();

            ScrambledEggsSwitchCase(reply);

            Console.ReadKey();

            Console.Clear();
            Main();
        }

        static void ScrambledEggsSwitchCase(string reply)
        {
            ScrambledEggs _eggs = new ScrambledEggs();
            
            switch (reply)
            {
                case "1":
                    _eggs.MakeScrambledEggsAsync();
                    break;
                case "2":
                    _eggs.MakeScrambledEggs();
                    break;
                default:
                    break;
            }
        }
    }
}

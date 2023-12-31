using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating new random
            Random random = new Random();
            // Specifying that we want a random number from 1 to 6
            int dice = random.Next(1, 7);
            // Array with our translated "eyes" for the dice hit.
            string[] eye = { "one eye", "two eyes", "three eyes", "four eyes", "five eyes", "six eyes" };
            // Switch system to write what dice we hit with custom color.
            switch (dice)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You hit " + eye[0]);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You hit " + eye[1]);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You hit " + eye[2]);
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("You hit " + eye[3]);
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You hit " + eye[4]);
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("You hit " + eye[5]);
                    break;
            }
            // Readline so we can observe the hit.
            Console.ReadLine();
        }
    }
}

using System;
using System.Threading;
using System.Collections.Generic;

namespace project_first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TITLE SCREEN TEST

            Console.ForegroundColor = ConsoleColor.Green; // Color change

            Console.WriteLine();
            Console.WriteLine(" *******************************");
            Console.WriteLine(" *                             *");
            Console.WriteLine(" *   Flying PAD Presents       *");
            Console.WriteLine(" *                             *");
            Console.WriteLine(" *    - THE MYSTERY NUMBER     *");
            Console.WriteLine(" *                             *");
            Console.WriteLine(" *******************************");
            Console.WriteLine();
            Console.WriteLine("      - 1. START GAME");
            Console.WriteLine("      - 2. EXIT");
            Console.WriteLine();
            Console.WriteLine(" ***************************");
            Console.ResetColor(); // Reset Color
            Console.WriteLine();
            Console.WriteLine();

            // VARIABLE INITIALISATION

            int user_entry, myst_nb, total_tries, level, max;

            user_entry = 0;
            myst_nb = 0;
            total_tries = 0;
            level = 0;
            max = 0;

            bool again = true;

            do
            {
                Console.WriteLine("Choose your level (1, 2 or 3 )");
                int.TryParse(Console.ReadLine(), out level);
                if (level != 1 && level != 2 && level != 3)
                {
                    Console.WriteLine("Unknown Level !! Select 1, 2 or 3");

                }

                Console.WriteLine("Would you like to play again ?");
                bool.TryParse(Console.ReadLine(), out again);
            }
            while (again == true);

            // END MESSAGE

            Console.Clear();
            Console.WriteLine("See ya next time !!");


        }
    }
}

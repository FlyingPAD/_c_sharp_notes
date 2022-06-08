using System;
using System.Threading;
using System.Collections.Generic;

namespace exo_method
{
    internal class Program
    {
        /// <summary>
        /// Méthode qui Joue la note Spécifiée
        /// </summary>
        /// <param name="freq">Fréquence de la note</param>
        /// <param name="duration">Durée de la note</param>
        /// <returns></returns>
        public static void jouer_note(double freq, double duration = 200)
        {
            Console.Beep((int)freq, (int)duration);
        }

        public static Dictionary<ConsoleKey, double> RemplirDictionnaire()
        {
            Dictionary<ConsoleKey, double> dico_notes = new Dictionary<ConsoleKey, double>();

            dico_notes.Add(ConsoleKey.Q, 261.63);
            dico_notes.Add(ConsoleKey.Z, 277.18);
            dico_notes.Add(ConsoleKey.S, 293.66);
            dico_notes.Add(ConsoleKey.E, 311.13);
            dico_notes.Add(ConsoleKey.D, 329.63);
            dico_notes.Add(ConsoleKey.F, 349.23);
            dico_notes.Add(ConsoleKey.T, 369.99);
            dico_notes.Add(ConsoleKey.G, 392);
            dico_notes.Add(ConsoleKey.Y, 415.3);
            dico_notes.Add(ConsoleKey.H, 440);
            dico_notes.Add(ConsoleKey.U, 466.16);
            dico_notes.Add(ConsoleKey.J, 493.88);
            dico_notes.Add(ConsoleKey.K, 523.25);
            dico_notes.Add(ConsoleKey.O, 554.37);
            dico_notes.Add(ConsoleKey.L, 587.33);
            dico_notes.Add(ConsoleKey.P, 622.25);
            dico_notes.Add(ConsoleKey.M, 659.26);

            //RETOURNE LE DICTIONNAIRE SOUS FORME DE TABLEAU
            return dico_notes;
        }

        static void Main(string[] args)
        {
            // TITLE SCREEN

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("   Flying PAD Presents : Ze Console Keyboard | v.0.1.a");

            Console.ForegroundColor = ConsoleColor.Green; // Color change

            Console.WriteLine();
            Console.WriteLine(" *********************************************");

            Console.ResetColor(); // Reset Color

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("   |   |   | |   |       |   | |   | |   |         |");
            Console.WriteLine("   |   |   | |   |       |   | |   | |   |         |");
            Console.WriteLine("   |   | * | | * |       | * | | * | | * |         |");
            Console.WriteLine("   |     |     |     |     |     |     |     |     |");
            Console.WriteLine("   |     |     |     |     |     |     |     |     |");
            Console.WriteLine("   |  *  |  *  |  *  |  *  |  *  |  *  |  *  |  *  |");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" *****************************************************");

            bool exit = false;

            Dictionary<ConsoleKey, double> dico_notes = RemplirDictionnaire();

            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.X)
                {
                    exit = true;
                }
                else jouer_note(dico_notes[keyInfo.Key], 200);


            } while (exit == false);

            // CLOSE // static void Main
        }
        // CLOSE // internal class Program
    }
    // CLOSE // namespace
}
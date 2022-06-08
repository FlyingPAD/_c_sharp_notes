// ----------------------------------------------------------------------------------------------------------------------
// FLYING PAD | C# | CUSTOM CONSOLE MENU
// ----------------------------------------------------------------------------------------------------------------------
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true; // Un p'tit booléen pour la condition de la méthode menu

            Menu(); // Déclenchement de la méthode Menu

            do
            {
                Console.Write("   ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.NumPad1)
                {
                    Menu();
                    Console.WriteLine("   Y'a plus qu'à coder un truc xD !");
                }
                else if (keyInfo.Key == ConsoleKey.X)
                {
                    menu = false;
                }
                else
                {
                    Menu();
                    Console.WriteLine("   On a dit ' 1 ' ou ' X ' !!!");
                    Console.WriteLine();
                    Console.WriteLine("   C'est quand même pas compliqué... Abruti !");
                }
            } while (menu);

            // ----------------------------------------------------------------------------------------------------------------------
            // AVANT DE PARTIR
            // ----------------------------------------------------------------------------------------------------------------------
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("   Ciao Ciao !!");
                Console.WriteLine();
            // ----------------------------------------------------------------------------------------------------------------------
            // MÉTHODE POUR LE MENU
            // ----------------------------------------------------------------------------------------------------------------------
            static void Menu()
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("   Faites votre choix : ");
                    Console.WriteLine("   ---------------------");
                    Console.Write("   - Appuyez sur ' ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("1");
                    Console.ResetColor();
                    Console.Write(" ' pour continuer ");
                    Console.WriteLine();
                    Console.Write("   - Appuyez sur ' ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("X");
                    Console.ResetColor();
                    Console.Write(" ' pour quitter ");
                    Console.WriteLine();
                    Console.WriteLine();
                }
        }
    }
}
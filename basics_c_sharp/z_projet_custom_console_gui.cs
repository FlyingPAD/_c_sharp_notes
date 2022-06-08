// FLYING PAD | C# | CONSOLE CUSTOM GUI
// ----------------------------------------------------------------------------------------------------------------------
#region 1. Affichage du titre de l'application

// Pour nommer la fenêtre de la console :

Console.Title = "Flying PAD | C# | Console Custom GUI";    

// Pour afficher le titre DANS la console :

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("     Flying PAD | C# | Console Custom GUI");
Console.WriteLine("    --------------------------------------");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.ReadLine();

#endregion
// ----------------------------------------------------------------------------------------------------------------------
#region 2. Afficher un menu avec un ' SWITCH '

int user_entry_menu;

Console.WriteLine(" - Menu Selection : ");
Console.WriteLine(" -------------------");
Console.WriteLine();
Console.WriteLine("1. Say Hello");
Console.WriteLine("2. Roll the dice");
Console.WriteLine("3. Say Goodbye");

if (int.TryParse(Console.ReadLine(), out user_entry_menu)
{
    switch (user_entry_menu)
    {
        case 1:
            Console.WriteLine($" - Menu 1");
            break;
        case 2:
            Console.WriteLine($" - Menu 2");
            break;
        case 3:
            Console.WriteLine($" - Menu 3");
            break;
    }
}

// Affichage du menu

int choice;

MenuSelect(courant, personne, banque);

static double UserEntry()
{
    double user_entry;
    double.TryParse(Console.ReadLine(), out user_entry);
    return user_entry;
}

static Menu MenuSelect(Courant courant, Personne personne, Banque banque)
{
    do
    {
        Console.Clear();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("   Fortiche Banque");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(" Menu : 1. Depot, 2. Retrait, 3. Afficher total : ");
        int.TryParse(Console.ReadLine(), out int choice);

        switch (choice)
        {
            case 1:
                Console.WriteLine();
                Console.Write("Entrez le montant désiré à déposer : ");
                double gold_01 = UserEntry();
                courant.Depot(gold_01);
                Console.WriteLine($"Solde : {courant.Solde}");
                Console.ReadLine();
                break;
            case 2:
                Console.WriteLine();
                Console.Write("Entrez le montant désiré à retirer : ");
                double gold_02 = UserEntry();
                courant.Retrait(gold_02);
                Console.WriteLine($"Solde : {courant.Solde}");
                Console.ReadLine();
                break;
            case 3:
                Console.WriteLine();
                Console.WriteLine($"Le total de tous les comptes est de : {banque.AvoirDesComptes(personne)}");
                Console.WriteLine();
                Console.ReadLine();
                break;
        }
    } while (true);

}
        }

        enum Menu
{
    Depot = 1,
    Retrait,
    Total
}
#endregion
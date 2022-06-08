// FLYING PAD | C# | ...
// ----------------------------------------------------------------------------------------------------------------------
#region 1. Les instructions conditionnelles ( Théorie )

// Les instructions conditionnelles permettent d'insérer des embranchements dans le code
// selon que certaines conditions soient satisfaites ou non !
// Ou bien en fonction de la valeur d'une expression.
// ----------------------------------------------------------------------------------------------------------------------
// En C#; il existe 2 constructions pour y arriver :

// 1. L'instruction ' if ... else ' :
// Qui permet de tester si une condition est satisfaite ou non.

// Le bloc else est facultatif !

// La condition doit renvoyer un type de valeur ' BOOL ' et peut être le résultat d'un test sur :
// des valeurs, une variable, le retour d'une méthode ou la combinaison de ces points.

bool condition = true;

Console.WriteLine();

if (condition) Console.WriteLine(" - la condition est vraie !");

else Console.WriteLine(" - la condition est fausse !");

Console.ReadLine();

// ----------------------------------------------------------------------------------------------------------------------

// Liste des opérateurs sur les valeurs ( ==, !=, <, <=, >, >= ) et des opérateurs logiques ( !, &&, ||, ^ )

// Il est également possible de définir plusieurs conditions et d'avoir un traitement spécifique pour chacune.
// Pour cela, il faudra utiliser l'instruction ' if ... else if ... else ' même combat !

// ----------------------------------------------------------------------------------------------------------------------
int user_entry_int;

Console.WriteLine();

do
{
    Console.Write("   Entrez un nombre entier : ");
}
while (!(int.TryParse(Console.ReadLine(), out user_entry_int)));

Console.WriteLine();

if (user_entry_int == 0)
{
    Console.WriteLine(" - La valeur entrée est égale à zéro");
}
if (user_entry_int < 0)
{
    Console.WriteLine(" - La valeur entrée est inférieure à zéro");
}
if (user_entry_int > 0)
{
    Console.WriteLine(" - La valeur entrée est supérieure à zéro");
}

Console.ReadLine();


//2. L'instruction ' switch ' :
// Qui permet de comparer une expression avec des valeurs différentes.

int i;

if(int.TryParse(Console.ReadLine(), out i))
{
    switch(i)
        { 
            case 1: 
                Console.WriteLine(" - Choix numéro 1");
                break;
            case 2:
                Console.WriteLine(" - Choix numéro 2");
                break;
            case 3:
                Console.WriteLine(" - Choix numéro 3");
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine(" - Choix numéro 4, 5 ou 6"); // Il est possible de grouper plusieurs possibilités
                break;
            default:
                Console.WriteLine(" - Ni 1, ni 2, ni 3 !");
                break;
    }
}

Console.ReadLine();

#endregion
// ----------------------------------------------------------------------------------------------------------------------
#region 2. Exercice : Déterminer si un nombre est pair ou impair

// On déclare une variable pour le ' TryParse '

int nb_01;

// On pose la question à l'utilisateur :

Console.WriteLine();
Console.Write(" - Entrez un nombre entier : ");

// On peut taper directement le ' ReadLine ' dans le ' TryParse '

int.TryParse(Console.ReadLine(), out nb_01);

// Un petit ' if else ' pour poser notre condition et utiliser la formule x/2 + x/2 = 0

if ((nb_01 / 2) + (nb_01 / 2) == nb_01)
{
    Console.WriteLine(" - Le nombre est pair !");
}
else
{
    Console.WriteLine(" - Le nombre est impair !");
}

// On pourrait aussi utiliser une ternaire pour tout taper sur une ligne :

Console.WriteLine(nb_01 % 2 == 0 ? " - Le nombre est pair !" : " - Le nombre est impair !");

Console.ReadLine();

#endregion
// ----------------------------------------------------------------------------------------------------------------------
#region 3. Exercice : Déterminer si un nombre est pair ou impair ( Variante modulo )

int nb_02;

Console.WriteLine();
Console.Write(" - Entrez un nombre entier : ");

int.TryParse(Console.ReadLine(), out nb_02);

if ((nb_02 % 2) == 0)
{
    Console.WriteLine(" - Le nombre est pair !");
}
else
{
    Console.WriteLine(" - Le nombre est impair !");
}

// OU ternaire :

Console.WriteLine(nb_02 % 2 == 0 ? " - Le nombre est pair !" : " - Le nombre est impair !");

Console.ReadLine();

#endregion
// ----------------------------------------------------------------------------------------------------------------------
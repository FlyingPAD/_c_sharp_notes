// FLYING PAD | C# | VÉRIFICATIONS
// ----------------------------------------------------------------------------------------------------------------------
#region 1. Vérifier une entrée utilisateur

// Remember, on est pas dans le monde des bisounours xD !!
// Du coup, c'est toujours bien de s'assurer qu'on reçoit bien ce qu'on demande !!

// Bon, pour le string, on s'en tape : 

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" - Entrez ce que vous voulez : ");
Console.WriteLine();
Console.Write("   ");

string user_entry_01 = Console.ReadLine();

Console.WriteLine(user_entry_01);

Console.ReadLine();

Console.Clear();

#endregion
// ----------------------------------------------------------------------------------------------------------------------
#region 2. Vérifier un ' INT ' avec condition(s)

// Mais du coup, si on demande un entier, ou autre chose de plus précis, il va falloir installer des garde-fous !

int user_entry_int;

// Il est donc nécessaire d'utiliser une boucle afin de reposer la question jusqu'à ce qu'on recoive ce qu'on demande

// Remember, le ' TryParse ' renvoie un ' BOOL ( True ou False ) ' du coup, on peut s'en servir comme condition :

do
{
    Console.Write("   Entrez un nombre entier : ");
}
while (!(int.TryParse(Console.ReadLine(), out user_entry_int))); // Si ' not true ' on repose la question en boucle

// Et quand c'est ' true ' on sort de la boucle et on peut traiter la variable avec des condition

if (user_entry_int < 0)
{
    Console.WriteLine($"{user_entry_int} est inférieur à zéro");
}
else if (user_entry_int > 0)
{
    Console.WriteLine($"{user_entry_int} est supérieur à zéro");
}
else if (user_entry_int == 0)
{
    Console.WriteLine($"{user_entry_int} est égal à zéro");
}

#endregion
// ----------------------------------------------------------------------------------------------------------------------
#region 3. Récupérer 2 entiers et faire l'addition via la méthode ' Parse '

// L'entrée récupérée sera toujours de type string,
// il faudra convertir vers le type de donnée désiré pour traiter l'info

// On pose la question avec un ' WriteLine '

Console.WriteLine("Entrez un 1er nombre entier : ");

// Et on récupère avec un ' ReadLine '

string user_entry_string_01 = Console.ReadLine();

// idem pour le 2ème :

Console.WriteLine("Entrez un 2ème nombre entier : ");

string user_entry_string_02 = Console.ReadLine();

// on additionne les deux en utilisant le int.Parse (float.Parse, double.Parse, ... )

int result = int.Parse(user_entry_string_01) + int.Parse(user_entry_string_02);

// On affiche joliment le résultat :

Console.WriteLine($"{user_entry_string_01} + {user_entry_string_02} = {result}");

Console.ReadLine();

Console.Clear();

#endregion
// ----------------------------------------------------------------------------------------------------------------------
#region 4. Récupérer 2 entiers et faire l'addition via la méthode ' TryParse '

// PAreil que dans le premier :

Console.WriteLine("Entrez un 1er nombre entier : ");

string user_entry_string_03 = Console.ReadLine();

Console.WriteLine("Entrez un 2ème nombre entier : ");

string user_entry_string_04 = Console.ReadLine();

// Pour utiliser le ' TryParse ' il nous faut déclarer deux variables de type ' INT '

int nb_01, nb_02;

// Le ' TryParse ' renvoie en fait un ' BOOL ' si la conversion ne fonctionne pas il affichera ' False'
// Si la conversion fonctionne, l'entrée utilisateur passera dans notre variable prévue pour la recevoir.

bool isConverted_01 = int.TryParse(user_entry_string_03, out nb_01);

Console.WriteLine(isConverted_01);

bool isConverted_02 = int.TryParse(user_entry_string_04, out nb_02);

Console.WriteLine(isConverted_02);

// Si les deux conversions sont réalisées, alors nous disposons des variables nb_01 et nb_02 pour faire l'addition
// et stocker le résultat dans une nouvelle variable :

int result_02 = nb_01 + nb_02;

// Et afficher le résultat :

Console.WriteLine($"{user_entry_string_03} + {user_entry_string_04} = {result_02}");

Console.ReadLine();

#endregion
// ----------------------------------------------------------------------------------------------------------------------
// FLYING PAD | C# | BASICS
// ----------------------------------------------------------------------------------------------------------------------
#region 1. Afficher du texte en console :

Console.WriteLine("Hello World !");

// La commande ' Console.Readline ' permet d'attendre un signe de l'utilisateur avant de continuer à exécuter le code :

Console.ReadLine();

// Les textes contenus entre "" ( double quotes ) sont de type STRING
// on peut donc déclarer, par exemple, une variable

string message_01 = "Hello Ze World !!!";

// Et ensuite refaire la commande mais en affichant cette fois, le nom de la variable sans les guillemets :

Console.WriteLine(message_01); // ce qui affichera le message contenu dans la variable
Console.ReadLine();

// On peut donc déclarer comme ça plusieurs variables de type string et les concaténer dans la même commande à l'aide du signe + ( plus ):

string last_name = "Van Langenhove";
string first_name = "Tony";
string age = "39";

// Pour ajouter des espaces entre les variables, il faut ajouter des espaces entre guillemets :

Console.WriteLine(first_name + " " + last_name + " " + age);
Console.ReadLine();

// Et on peut bien entendu ajouter du texte à la volée sans passer par une variable, comme ceci :

Console.WriteLine("Hello, my full name is " + first_name + " " + last_name + " and I'm " + age + " years old.");
Console.ReadLine();

// MAIS la meilleure technique, c'est de taper le signe $ (dollar) devant les guillemets,
// et de mettre les variables entre accolades, pour faciliter l'écriture et la concaténation :

Console.WriteLine($"Hello, my full name is {first_name} {last_name} and I'm {age} years old.");
Console.ReadLine();

#endregion
// ----------------------------------------------------------------------------------------------------------------------
#region 2. Un brin de mise en page

// On dispose de la commande ' Console.Clear ' pour nettoyer la console des messages précédents :

Console.Clear();

// Afficher des ' Console.WriteLine vides ' pour passer une ligne :

Console.WriteLine();

// Et jouer avec les espaces, pour éviter de coller les bords :

Console.WriteLine($"   Hello, my full name is {first_name} {last_name} and I'm {age} years old.");
Console.ReadLine();

// On notera que la position du curseur après la ligne passe en dessous et se recolle au bord ...
// Là, on peut utiliser la commande ' Console.Write ' ( qui ne repasse pas à la ligne du coup ) pour le laisser à côté
// en prévoyant également les espaces nécessaires dans le texte :

Console.Write($"   Hello, my full name is {first_name} {last_name} and I'm {age} years old.   ");
Console.ReadLine();

// Si on veut jouer un peu, on peut garder le ' Console.WriteLine ' pour le texte
// mais ajouter une ligne vide ainsi qu'un ' Write ' avec les espaces correspondant
// pour placer le curseur pile en dessous de la première lettre du texte

Console.Clear();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"   Hello, my full name is {first_name} {last_name} and I'm {age} years old.");
Console.WriteLine();
Console.Write("   "); // Il est nécessaire de placer les guillemets pour que la commande soit fonctionelle
Console.ReadLine();

#endregion
// ----------------------------------------------------------------------------------------------------------------------
#region 3. Mise en page 2.0

// On dispose de pas mal de commande pour tabuler le texte :

// \n : pour une nouvelle ligne
// \r : pour un retour chariot
// \t : pour un tab horizontal
// \v : pour un tab vertical

// Et d'autres évidemment qu'on retrouvera dans la DOC :
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/

// En jouant un peu avec, on peut se retrouver avec ça :

Console.Clear();
Console.WriteLine();
Console.WriteLine($"\t Hello, my full name is {first_name} {last_name} and I'm {age} years old.");
Console.WriteLine();
Console.Write("\t "); // Il est nécessaire de placer les guillemets pour que la commande soit fonctionelle
Console.ReadLine();

#endregion
// ----------------------------------------------------------------------------------------------------------------------
#region 4. Un peu plus de fun !

// Il est possible d'afficher des couleurs dans la console !
// via les commandes ForegroundColor et/ou BackgroundColor

Console.Clear();
Console.WriteLine();
Console.Write($"   {message_01}  My name is ");
Console.ForegroundColor = ConsoleColor.Green; // Color change
Console.Write($"{first_name}");
Console.ResetColor(); // Reset Color
Console.Write(" !!");
Console.WriteLine();
Console.ReadLine();

// Il est également possible d'utiliser des bips console pour emmerder les utilisateurs xD
// pour cela, utilisez la fonction Console.Beep, les paramètres attendu étant : la fréquence et la durée

int frequency = 440;
int duration = 200;

Console.Beep(frequency, duration);
Console.ReadLine();

#endregion
// FLYING PAD | C# | LES TABLEAUX
// ----------------------------------------------------------------------------------------------------------------------
#region 1. Tableaux à une dimension

// Un tableau représente un nombre fixe de variables ( appelés élements ) d'un type défini.
// Les éléments du tableau sont stockés de manière contigüe en mémoire, ce qui fourni un accès hautement efficient.

// Pour déclarer un tableau, il faut utiliser les [] à côté du type de la variable.

// Le premier élément du tableau a pour index ' 0 ' ( zéro )

// Derrière int[] se cache une instanciation de la classe ' Array ' ce qui fait de notre int[] un type référence.

// ----------------------------------------------------------------------------------------------------------------------

// On peut déclarer un tableau comme ceci :

int[] entiers_01 = new int[10]; // tableau vide d'entiers de 10 éléments

// On peut ensuite attribuer des valeurs à l'index de notre choix :

entiers_01[2] = 7; entiers_01[3] = 6; // etc ...

// Pour afficher les valeurs une par une : 

Console.WriteLine();
Console.WriteLine($" - Élément n°3 ( index 2 ) : {entiers_01[2]}");
Console.WriteLine($" - Élément n°4 ( index 3 ) : {entiers_01[3]}");
Console.WriteLine();

Console.ReadLine();

// Utiliser une boucle ' foreach ' pour parcourir chaque élément :

Console.WriteLine();

int i = 0;

foreach (var element in entiers_01)
{
    Console.WriteLine($" - Élément n°{(i + 1):D2} : {element}"); // Les élements vides afficheront les valeurs par défaut du type ( ici : 0 pour le type ' int '
    i++;
}

Console.ReadLine();
Console.WriteLine();

// ou en variante avec une boucle for :

for(int j = 0; j < 10; j++)
{
    Console.WriteLine($" - Élément n°{(j + 1):D2} : {entiers_01[j]}");
}

Console.ReadLine();

// ----------------------------------------------------------------------------------------------------------------------

// On peut aussi déclarer le tableau directement avec ses élements ( entre accolades ) :

int[] entiers_02 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Et l'afficher :

Console.WriteLine();

// ou en variante avec une boucle for :

for (int j = 0; j < 10; j++)
{
    Console.WriteLine($" - Élément n°{(j + 1):D2} : {entiers_02[j]}");
}

Console.ReadLine();

// ----------------------------------------------------------------------------------------------------------------------

// Bien que les tableaux aient une taille fixe, si on ne connaît pas cette taille à l'avance,
// Il peut être intéressant de déclarer la taille en constante :

int TAILLE = 10;

int[] entiers_03 = new int[TAILLE];

entiers_03[5] = 25;


// Du coup dans la boucle for :

for (int k = 0; k < TAILLE; k++)
{
    Console.WriteLine($" - Élément n°{(k + 1):D2} : {entiers_03[k]}");
}

#endregion
// ----------------------------------------------------------------------------------------------------------------------
#region 2. Tableau à X Dimensions ( x > 1 )
{
    // 1. Les tableaux matriciels, contiennent le même nombre d'éléments pour chaque dimension

    int[,] entiers_04 = { { 0, 1, 2, 3, 4, 5, }, { 0, 1, 2, 3, 4, 5 } };


    // 2. Les tableaux avec plueisurs dimensions de taille différentes :

    int[,] entiers_05 = new int[2, 5];

    entiers_05[0, 0] = 7;

    Console.WriteLine(entiers_05[0,0]);
    Console.WriteLine(entiers_05[1,2]);

    Console.ReadLine();
}
#endregion
// ----------------------------------------------------------------------------------------------------------------------
#region 3. Tableaux, la suite !



#endregion
// FLYING PAD | C# | ENUMERATIONS
// ----------------------------------------------------------------------------------------------------------------------
#region 2. Utilisation

// Déclarer une énumération revient à créer un nouveau TYPE de donnée,
// ce qui permet de déclarer une variable de ce même TYPE

Instrument instru = Instrument.Guitare;

// Pour ensuite récupérer et afficher la valeur numérique et le contenu de la variable :

Console.WriteLine();
Console.WriteLine($" - {instru.ToString()} : {(int)instru}");
Console.ReadLine();

// FLAGS ? // Demander à quoi servent ces putains de flags #PasSuivi :'/

Right right = Right.Execute | Right.Write | Right.Read;

if (right.HasFlag(Right.Execute))
{
    Console.WriteLine(" - J'ai le droit d'exécuter.");
}
if (right.HasFlag(Right.Write))
{
    Console.WriteLine(" - J'ai le droit d'écrire.");
}
if (right.HasFlag(Right.Read))
{
    Console.WriteLine(" - J'ai le droit de lire.");
}

Console.ReadLine();

// Pour récupérer la liste complète :

Console.WriteLine();
Console.WriteLine(" Liste des instruments :");
Console.WriteLine();

foreach( string s in Enum.GetNames( typeof(Instrument) ) )
{
    Console.WriteLine($" - {s}");
}

Console.ReadLine();

// Enum.Parse / Pas trop compris l'énoncé, on dirait pour afficher une des valeurs ?

string s2 = "Gaz";

TypeCarburant tc = (TypeCarburant)Enum.Parse(typeof(TypeCarburant), s2);

Console.WriteLine($" - {tc.ToString()} : {(int)tc}");

Console.ReadLine();

// Enum.TryParse / Idem

string s3 = "Diesel";

TypeCarburant tc2;

if (Enum.TryParse(s3, out tc2))
{
    Console.WriteLine($" - {tc2.ToString()} : {(int)tc2} ");
}

Console.ReadLine();

#endregion
// ----------------------------------------------------------------------------------------------------------------------
#region 1. Déclaration

// Les énumérations permettent de stocker plusieurs CONSTANTES liées logiquement entre elles
// Chaque CONSTANTE reçoit une valeur numérique par défaut

public enum TypeCarburant
{
    Essence, // 0
    Diesel,  // 1
    Gaz      // 2
}

// MAIS on peut également définir ces valeurs numériques à notre guise :

public enum Instrument
{
    Batterie = 0,
    Basse = 2,
    Guitare = 4,
    Piano = 8
}

// 

[Flags]
public enum Right
{
    Execute,
    Write,
    Read
}
public enum Droit
{
    Executer = 1,
    Ecrire = 2,
    Lire = 4
}

#endregion
// ----------------------------------------------------------------------------------------------------------------------
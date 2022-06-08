// FLYING PAD | C# | LES STRUCTURES
// ----------------------------------------------------------------------------------------------------------------------
namespace Structures
{
    #region 1. Déclaration & Utilisation

    // Une structure permet de créer & déclarer un nouveau type complexe de type ' valeur ' ( stocké sur la pile )
    public struct MesureAngulaire
    {
        public int Degre, Minutes, Secondes;            // 3 variables de type ' int '
        public string Direction;                        // 1 variable de type ' string '
    }
    public struct Localisation
    {
        public MesureAngulaire Longitude, Latitude;     // 2 variables de type ' MesureAngulaire ' 
        public int Altitude;                            // 1 variable de type ' int '
    }

    // Les 2 variables : Longitude & Latitude de la structure ' Localisation ' contiennent donc chacune
    // les 4 variables de la structure ' MesureAngulaire ' 

    // ----------------------------------------------------------------------------------------------------------------------
    // Création des structures des exercice ( voir à la fin du main ) :
    public struct Point
    {
        int x;
        int y;
    }
    public struct Celsius
    {
        double Temperature;
    }
    public struct Fahrenheit
    {
        double Temperature;
    }

    #endregion
    // ----------------------------------------------------------------------------------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            // Une fois les structures créées dans le namespace,
            // On peut créer des variables et leur attribuer des valeurs dans le main de la classe Program :

            // Ici, création d'une variable de type ' Localisation ' nommée : Bruxelles :

            Localisation Bruxelles;

            // variable complexe qui comprend donc la variable altitude de type ' int ',
            // Et les deux variables de type ' MesureAngulaire ' elles-mêmes, contenant les 4 variables de la structure ' MesureAngulaire '

            // Ensuite, il n'y a plus qu'à initialiser les valeurs :

            Bruxelles.Latitude.Degre = 50;
            Bruxelles.Latitude.Minutes = 51;
            Bruxelles.Latitude.Secondes = 1;
            Bruxelles.Latitude.Direction = "Nord";

            Bruxelles.Longitude.Degre = 4;
            Bruxelles.Longitude.Minutes = 20;
            Bruxelles.Longitude.Secondes = 55;
            Bruxelles.Longitude.Direction = "Est";

            Bruxelles.Altitude = 20;

            // Et enfin les afficher avec un petit formatage sympathique :

            Console.WriteLine();
            Console.WriteLine("   Ville : Bruxelles");
            Console.WriteLine("  -------------------");
            Console.WriteLine();
            Console.WriteLine($" - Altitude :\t {Bruxelles.Altitude} mètres au dessus de la mer.");
            Console.WriteLine();
            Console.WriteLine($" - Latitude :\t {Bruxelles.Latitude.Degre:D2}° {Bruxelles.Latitude.Minutes:D2}' {Bruxelles.Latitude.Secondes:D2}\" {Bruxelles.Latitude.Direction} ");
            Console.WriteLine($" - Longitude :\t {Bruxelles.Longitude.Degre:D2}° {Bruxelles.Longitude.Minutes:D2}' {Bruxelles.Longitude.Secondes:D2}\" {Bruxelles.Longitude.Direction} ");
            Console.WriteLine();
            Console.Write("   ");

            // à noter dans le formatage qu'il faut ' échapper ' les double quotes ( " ) pour l'affichage des secondes,
            // pour ne pas annuler ceux de la chaîne de caractères.

            // Le ' :D2 ' permet de formater la valeur des variables sur 2 chiffres.

            Console.ReadLine();


            #region 2. Exercice 1 : 

            // Création d'un tableau de type ' Point ' à 2 dimensions de taille 5 chacune :

            // revenir dessus après le chapitre sur les tableaux !

            Point[,]? Tableau = new Point[5,5];

            Tableau[0, 0] = new Point();
            Tableau[1, 1] = new Point();
            Tableau[2, 2] = new Point();
            Tableau[3, 3] = new Point();
            Tableau[4, 4] = new Point();

            #endregion
            // ----------------------------------------------------------------------------------------------------------------------
            #region 3. Exercice 2 : 

            

            #endregion
        }
    }
}
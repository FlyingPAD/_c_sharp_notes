// FLYING PAD | C# | HOUSE OF CARDS
// ----------------------------------------------------------------------------------------------------------------------
using System.Collections;

namespace house_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Afficher le titre sur la fenêtre de la console

            Console.Title = "House of Cards | BATTLE !";

            // Cacher le curseur xD

            Console.CursorVisible = false;

            // Afficher le titre dans la console

            Console.WriteLine();
            Console.WriteLine(" - House of Cards | Battle !");
            Console.WriteLine();

            // Appel de la méthode CreateGame ( voir plus bas )

            Card[] card_table = CreateGame();

            // Afficher le nombre de cartes :

            //Console.WriteLine($" - Total Cards : {card_table.Length}");
            //Console.WriteLine();

            // Appel de la méthode CardsShuffle ( voir plus bas )

            CardsShuffle(card_table);

            // Affichage des cartes mélangées

            //foreach (Card c in card_table)
            //{
            //    Console.WriteLine($"{c.card_rank} of {c.card_suit}");
            //}

            // Déclaration des 2 tableaux

            Queue<Card> player1 = new Queue<Card>();
            Queue<Card> player2 = new Queue<Card>();

            // Appel de la méthode CardTableSplit

            CardTableSplit(card_table, player1, player2);

            // Déclaration d'un booléen pour démarrer ou arrêter le jeu

            bool GameOn = true;

            while(GameOn && player1.Count > 0 && player2.Count > 0)
            {
                // sortir deux cartes P1 et P2

                Card play1 = player1.Dequeue();
                Card play2 = player2.Dequeue();

                // Conditions de combat

                // Joueur 1 emporte les cartes
                if(play1.card_rank > play2.card_rank)
                {
                    Console.Write($"     P1 ( {(int)player1.Count} ) : {play1.card_rank} of {play1.card_suit} | ");
                    Console.ForegroundColor = ConsoleColor.Green; // Color change
                    Console.Write("VERSUS ");
                    Console.ResetColor(); // Reset Color
                    Console.Write($"| P2 ( {(int)player2.Count} ) : {play2.card_rank} of {play2.card_suit} \t => PLAYER 1 WINS !!");
                    player1.Enqueue(play1);
                    player1.Enqueue(play2);
                    if (player2.Count > 0)
                    {
                        player2.Dequeue();
                    }
                    else
                    {
                        GameOn = false;
                    }
                }

                // joueur 2 emporte les cartes
                if (play2.card_rank > play1.card_rank)
                {
                    Console.Write($"     P1 ( {(int)player1.Count} ) : {play1.card_rank} of {play1.card_suit} | ");
                    Console.ForegroundColor = ConsoleColor.Green; // Color change
                    Console.Write("VERSUS ");
                    Console.ResetColor(); // Reset Color
                    Console.Write($"| P2 ( {(int)player2.Count} ) : {play2.card_rank} of {play2.card_suit} \t => PLAYER 2 WINS !!");
                    player2.Enqueue(play1);
                    player2.Enqueue(play2);
                    if (player1.Count > 0)
                    {
                        player1.Dequeue();
                    }
                    else
                    {
                        GameOn = false;
                    }
                }

                // Bataille !
                if (play1.card_rank == play2.card_rank)
                {
                    Console.WriteLine();
                    Console.WriteLine($"     {play1.card_rank} of {play1.card_suit} VERSUS {play2.card_rank} of {play2.card_suit}");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red; // Color change
                    Console.WriteLine("          BATTLE !!!");
                    Console.ResetColor(); // Reset Color
                    Console.WriteLine();

                    Stack<Card> cardsBattle1 = new Stack<Card>();
                    Stack<Card> cardsBattle2 = new Stack<Card>();

                    cardsBattle1.Push(play1);
                    cardsBattle2.Push(play2);
                }
                Console.ReadLine();               
            }

            if (player2.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("          PLAYER 1 WINS THE GAME !!");
            }
            if (player1.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("          PLAYER 2 WINS THE GAME !!");
            }
            Console.WriteLine();
            Console.WriteLine("           - GAME OVER !!");
            Console.ReadLine();
        }

        static Card[] CreateGame()
        {
            Card[] card_table = new Card[52];
            int suit = 1;
            int rank = 2;

            for (int i = 0; i < 52; i++, rank++)
            {
                if (rank > 14)
                {
                    rank = 2;
                    suit++;                    
                }
                card_table[i].card_rank = (CardRank)rank;
                card_table[i].card_suit = (CardSuit)suit;
            }
            return card_table;
        }

        static void CardsShuffle(Card[] card_table)
        {
            Random rnd = new Random();

            for (int i = 0; i < 5000; i++)
            {
                int card_num_01 = rnd.Next(card_table.Length);
                int card_num_02;
                do
                    {
                        card_num_02 = rnd.Next(card_table.Length);
                    } 
                while (card_num_01 == card_num_02);
                
                Card card_temp = card_table[card_num_01];
                card_table[card_num_01] = card_table[card_num_02];
                card_table[card_num_02] = card_temp;               
            }
        }

        static void CardTableSplit(Card[] card_table, Queue<Card> player1, Queue<Card> player2)
        {
            bool isPlayer1 = true;

            foreach(Card card in card_table)
            {
                (isPlayer1 ? player1 : player2).Enqueue(card);
                isPlayer1 = !isPlayer1;
            }

            //for (int i = 0; i < 52; i++)
            //{
            //    if (i <= 25)
            //    {
            //        player1.Enqueue(card_table[i]);
            //        Console.WriteLine($"P1 : {i} - {card_table[i].card_rank} of {card_table[i].card_suit}");
            //    }
            //    if (i > 25)
            //    {
            //        player2.Enqueue(card_table[i]);
            //        Console.WriteLine($"P2 : {i} - {card_table[i].card_rank} of {card_table[i].card_suit}");
            //    }
            //}
        }
    }

    public struct Card
    {
        public CardSuit card_suit; // famille / couleur de la carte
        public CardRank card_rank; // valeur de la carte
    }

    public enum CardSuit
    {
        Hearts = 1,
        Diamonds,
        Spades,
        Clubs
    }

    public enum CardRank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
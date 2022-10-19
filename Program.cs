using System;

namespace ProjectMOM
{
    public class Program
    {


        public static List<Task> tasks = new List<Task>(); // Liste des tâches
        public static List<Commis> commisList = new List<Commis>();
        public static List<Client> clientList = new List<Client>();
        public static List<Livreur> livreurList = new List<Livreur>();
        public static List<Commande> commandes = new List<Commande>();
        public int nbCommandes = commandes.Count(); // Stats

        static async Task Main(string[] args)
        {
            coloredString("Benvenuti a Marco\n", ConsoleColor.Yellow);

            // Initialisation du commis
            Commis commis = new Commis();

            // Initisialisation des livreurs
            Livreur livreur0 = new Livreur();
            Livreur livreur1 = new Livreur();

            // Initialisation des anciens clients
            Client ancienClient1 = new Client("0123456789", "GENDRON", "Thomas", "69 rue du Trosy CLAMART 92140", new DateOnly(2018, 10, 19));
            Client ancienClient2 = new Client("0112223562", "Paysant", "Mathilde", "34 du four Bry sur Marne 94360", new DateOnly(2020, 08, 21));

            await lancerTaches(1, commis);

            Task.WaitAll(tasks.ToArray());
        }

        public static async Task lancerTaches(int nbTaches, Commis commis)
        {
            for (int i = 0; i < nbTaches; i++)
            {
                Task task = Commis.prendreCommande(commis); // Lance la prise de commande d'un client
                tasks.Add(task);
            }
        }

        public static void coloredString(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        /*
        Ordre des Tasks :

        commander (classe main)
        preparation (classe cuisine)
        livrer (classe Livreur)
        encaisser (classe Commis)
        terminerCommande (classe Commis)
        */
    }
}
using System;

namespace ProjectMOM
{
    public class Program
    {
        public static Cuisine cuisine = new Cuisine();
        public static Catalogue catalogue = new Catalogue();
        public static List<Commis> commisList = new List<Commis>();
        public static List<Client> clientList = new List<Client>();
        public static List<Livreur> livreurList = new List<Livreur>();
        public static List<Commande> commandes = new List<Commande>();
        public static int nbCommandes = commandes.Count(); // Stats

        static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Benvenuti a Marco\n");
            Console.ResetColor();

            // Initialisation de la cuisine
            Cuisine cuisine = new Cuisine();

            // Initisialisation des livreurs
            Livreur livreur0 = new Livreur();
            Livreur livreur1 = new Livreur();

            // Initialisation du commis
            Commis commis = new Commis();

            // Initialisation des anciens clients
            Client ancienClient1 = new Client("0123456789", "GENDRON", "Thomas", "69 rue du Trosy CLAMART 92140", new DateOnly(2018, 10, 19));
            Client ancienClient2 = new Client("0112223562", "Paysant", "Mathilde", "34 du four Bry sur Marne 94360", new DateOnly(2020, 08, 21));

            await commis.prendreCommande(); // Lance la prise de commande d'un client
        }

        /*
        Ordre des Tasks :

        commander (classe main)
        preparation (classe cuisine)
        ...

        livrer (classe Livreur)
        encaisser (classe Commis)
        terminerCommande (classe Commis)
        */
    }
}
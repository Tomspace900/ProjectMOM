using System;

namespace ProjectMOM
{
    public class Program
    {
        public static Cuisine cuisine = new Cuisine();
        public static Catalogue catalogue = new Catalogue();
        public static CommisList commisList = new CommisList();
        public static ClientsList clientList = new ClientsList();
        public static List<Livreur> livreurList = new List<Livreur>();
        public static List<Commande> commandes = new List<Commande>();

        static async Task Main(string[] args)
        {
            Console.WriteLine("Benvenuti a Marco");

            //Initisialisation livreurs
            Livreur livreur0 = new Livreur(0);
            Livreur livreur1 = new Livreur(1);
            livreurList.Add(livreur0);
            livreurList.Add(livreur1);

            Commis commis = Pizzeria.commisList.createCommis();
            clientList.createClient("0123456789", "GENDRON", "Thomas", "rue du Trosy", "CLAMART", 92140);
            clientList.createClient("0112223562", "Paysant", "Mathilde", "34 du four", "Bry sur Marne", 94360);
            await commis.prendreCommande();
        }

        /*
        Ordre des Tasks :

        commander (classe main)

        ...

        livrer (classe Livreur)
        encaisser (classe Commis)
        terminerCommande (classe Commis)
        */
    }
}
using System;
namespace ProjectMOM
{
    public class Pizzeria
    {
        public static Cuisine cuisine = new Cuisine();
        public static Catalogue catalogue = new Catalogue();
        public static CommisList commisList = new CommisList();
        public static ClientsList clientList = new ClientsList();
        public static List<Livreur> livreurList = new List<Livreur>();
        public static List<Commande> commandes = new List<Commande>();
        public static List<Commande> commandesEnCours = new List<Commande>();

        public Pizzeria()
        {
            // Créé et ajoute 2 livreurs à la pizzeria
            Livreur livreur0 = new Livreur(0);
            Livreur livreur1 = new Livreur(1);
            livreurList.Add(livreur0);
            livreurList.Add(livreur1);

            /*
             Dans l'ordre de fin va y avoir :

            commander (classe pizzeria)

            livrer (classe Livreur)
            encaisser (classe Commis)
            terminerCommande (classe Commis)
             */
        }
    }
}


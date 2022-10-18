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

        }
    }
}


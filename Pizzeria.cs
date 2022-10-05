using System;
namespace ProjectMOM
{
    public class Pizzeria
    {
        public Cuisine cuisine = new Cuisine();
        public Catalogue catalogue = new Catalogue();
        public List<Commis> commisList = new List<Commis>();
        public List<Client> clientList = new List<Client>();
        public List<Livreur> livreurList = new List<Livreur>();
        public List<Commande> commandes = new List<Commande>();
        public List<Commande> commandesEnCours = new List<Commande>();

        public Pizzeria()
        {

        }
    }
}


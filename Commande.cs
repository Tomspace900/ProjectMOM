using System;
namespace ProjectMOM
{
    public class Commande
    {
        public int num;
        public float prix;
        public Statut statut;
        public List<Pizza> pizzas;
        public List<Boissons> boissons;
        public DateOnly date;
        public Client client;
        public Livreur livreur;

        public Commande(int num, float prix, Statut statut, List<Pizza> pizzas, List<Boissons> boissons, DateOnly date, Client client, Livreur livreur)
        {
            this.num = num;
            this.prix = prix;
            this.statut = statut;
            this.pizzas = pizzas;
            this.boissons = boissons;
            this.date = date;
            this.client = client;
            this.livreur = livreur;
        }
    }
}


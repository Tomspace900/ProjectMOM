using System;
namespace ProjectMOM
{
    public class Commande
    {
        public int num;
        public float prix;
        public Statut statut = Statut.EnPreparation;
        public Encaissement encaissement = Encaissement.APayer;
        public List<Pizza> pizzas;
        public List<Boisson> boissons;
        public DateOnly date;
        public Client client;
        public Commis commis;

        public Commande(int num, DateOnly date, Client client, Commis commis)
        {
            this.num = num;
            this.date = date;
            this.client = client;
            this.commis = commis;
        }

        public void addPizza(TaillePizza taille, TypePizza type)
        {
            Pizza pizza = new Pizza(taille, type);
            pizzas.Add(pizza);
        }

        public void addBoisson(TypeBoisson type)
        {
            Boisson boisson = new Boisson(type);
            boissons.Add(boisson);
        }

        public void deletePizza(Pizza pizza)
        {
            if (pizzas.Contains(pizza))
            {
                pizzas.Remove(pizza);
            }
            else
            {
                Console.WriteLine("La pizza n'est pas dans la commande");
            }
        }

        public void deleteBoisson(Boisson boisson)
        {
            if (boissons.Contains(boisson))
            {
                boissons.Remove(boisson);
            }
            else
            {
                Console.WriteLine("La boisson n'est pas dans la commande");
            }
        }

        public void calculerPrix()
        {

        }
    }
}


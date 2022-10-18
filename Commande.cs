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

        public int V { get; }
        public DateOnly DateOnly { get; }

        public Commande(int num, DateOnly date, Client client, Commis commis)
        {
            this.num = num;
            this.date = date;
            this.client = client;
            this.commis = commis;
        }


        public Pizza randomPizza()
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(Pizza));
            int i = random.Next(values.Length);
            return (Pizza)values.GetValue(i);
        }

        public Boisson randomBoisson()
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(Boisson));
            int i = random.Next(values.Length);
            return (Boisson)values.GetValue(i);
        }


        //public static void createCommande1(Commis commis, Client client)
        //{
        //    Commande commande = new Commande(0, DateOnly.FromDateTime(DateTime.Today), client, commis);
        //}

        //public static void createCommande2(Commis commis, Client client)
        //{
        //    Commande commande = new Commande(0, DateOnly.FromDateTime(DateTime.Today), new Client(01223562, "Paysant", "Mathilde", "34 du four", "Bry sur Marne", 94360, DateOnly.FromDateTime(DateTime.Today)), commis);
        //}

        // Ajoute une pizza à la commande
        public void addPizza(TaillePizza taille, TypePizza type)
        {
            Pizza pizza = new Pizza(taille, type);
            pizzas.Add(pizza);
        }

        // Ajoute une boisson à la commande
        public void addBoisson(TailleBoisson taille, TypeBoisson type)
        {
            Boisson boisson = new Boisson(taille, type);
            boissons.Add(boisson);
        }

        // Supprime une pizza de la commande
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

        // Supprime une boisson de la commande
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

        // Supprime une boisson de la commande
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
    }
}
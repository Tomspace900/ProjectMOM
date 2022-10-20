using System;
using System.Text;
namespace ProjectMOM
{
    public class Commande
    {
        public int num;
        public double prix = 0;
        public Client client;
        public Commis commis;
        public Livreur livreur;
        public List<Pizza> pizzas = new List<Pizza>();
        public List<Boisson> boissons = new List<Boisson>();
        public Statut statut = Statut.EnPreparation;
        public Encaissement encaissement = Encaissement.APayer;
        public DateOnly date = DateOnly.FromDateTime(DateTime.Today);

        public Commande(int num, Client client, Commis commis)
        {
            this.num = num;
            this.client = client;
            this.commis = commis;

            Random random = new Random();
            int nbPizza = random.Next(1, 6); // Nombre de pizzas de la commande aléatoire entre 1 et 5
            int nbBoisson = random.Next(1, 6); // Pareil pour les boissons
            for (int i = 0; i < nbPizza; i++)
            {
                pizzas.Add(randomPizza(random)); // Ajoute une pizza aléatoire à la commande
            }
            for (int i = 0; i < nbBoisson; i++)
            {
                boissons.Add(randomBoisson(random)); // Pareil pour les boissons
            }
        }

        public string displayCommande()
        {
            StringBuilder commande = new StringBuilder("");
            commande.Append("---------------------------\n");
            commande.Append(" TICKET COMMANDE N°" + num);
            commande.Append("\n N° CLIENT " + client.tel + "\n");
            commande.Append("\n        -Pizzas-        \n");
            foreach (var pizza in pizzas)
            {
                commande.Append("\n" + pizza.getNom() + "         " + pizza.getPrix() + "€");
            }
            commande.Append("\n\n       -Boissons-       \n");
            foreach (var boisson in boissons)
            {
                commande.Append("\n" + boisson.getNom() + "         " + boisson.getPrix() + "€");
            }
            commande.Append("\n\nTOTAL   " + prix + "€");
            commande.Append("\n---------------------------");
            return commande.ToString();
        }

        // Actualise le prix de la commande en fonction de ce qui est ajouté ou enlevé
        public void updatePrice(double price, bool add)
        {
            if (add)
            {
                this.prix += price;
            }
            else
            {
                this.prix -= price;
            }
        }

        // Créé une pizza aléatoire
        public Pizza randomPizza(Random random)
        {
            Array tailles = Enum.GetValues(typeof(TaillePizza));
            int i = random.Next(tailles.Length);
            TaillePizza taille = (TaillePizza)tailles.GetValue(i);

            Array types = Enum.GetValues(typeof(TypePizza));
            int j = random.Next(types.Length);
            TypePizza type = (TypePizza)types.GetValue(j);

            Pizza pizza = new Pizza(taille, type);
            updatePrice(pizza.getPrix(), true); // Calcule le prix le chaque pizza
            return pizza;
        }

        // Créé une boisson aléatoire
        public Boisson randomBoisson(Random random)
        {
            Array tailles = Enum.GetValues(typeof(TailleBoisson));
            int i = random.Next(tailles.Length);
            TailleBoisson taille = (TailleBoisson)tailles.GetValue(i);

            Array types = Enum.GetValues(typeof(TypeBoisson));
            int j = random.Next(types.Length);
            TypeBoisson type = (TypeBoisson)types.GetValue(j);

            Boisson boisson = new Boisson(taille, type);
            updatePrice(boisson.getPrix(), true); // Calcule le prix le chaque boisson
            return boisson;
        }

        // Supprime une pizza de la commande
        public void deletePizza(Pizza pizza)
        {
            if (pizzas.Contains(pizza))
            {
                pizzas.Remove(pizza);
                updatePrice(pizza.getPrix(), false);
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
                updatePrice(boisson.getPrix(), false);
            }
            else
            {
                Console.WriteLine("La boisson n'est pas dans la commande");
            }
        }
    }
}
using System;

namespace ProjectMOM
{
    public class Program
    {
        public List<Commis> commis;
        public List<Livreur> livreurs;
        public List<Client> clients;
        public Cuisine cuisine;
        public List<Commande> commandes;
        public List<Commande> commandesEnCours;

        private static void Main(string[] args)
        {
            Console.WriteLine("Benvenuti a Marco");
        }
    }
}
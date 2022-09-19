using System;

namespace ProjectMOM
{
    public class Program
    {
        public Cuisine cuisine;
        public List<Commande> commandes = new List<Commande>();
        public List<Commande> commandesEnCours = new List<Commande>();

        private static void Main(string[] args)
        {
            Console.WriteLine("Benvenuti a Marco");

            CommisList commis = new CommisList();
            commis.createCommis();
            commis.createCommis();
            ClientsList clients = new ClientsList();
            clients.createClient(0123456789, "GENDRON", "Thomas", "rue du Trosy", "CLAMART", 92140);
            Console.WriteLine(clients.isFirstCommand(0123456789));
        }
    }
}
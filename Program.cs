using System;

namespace ProjectMOM
{
    public class Program
    {
        public Cuisine cuisine;
        public List<Commande> commandes = new List<Commande>();
        public List<Commande> commandesEnCours = new List<Commande>();

        static async Task Main(string[] args)
        {
            Console.WriteLine("Benvenuti a Marco");

            Commis commis = Pizzeria.commisList.createCommis();
            Pizzeria.clientList.createClient("0123456789", "GENDRON", "Thomas", "rue du Trosy", "CLAMART", 92140);
            Pizzeria.clientList.createClient("0112223562", "Paysant", "Mathilde", "34 du four", "Bry sur Marne", 94360);
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
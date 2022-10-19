using System;
using System.Net;

namespace ProjectMOM
{
    public class Livreur
    {
        public int id;
        public List<Commande> commandes;
        public int nbCommandes = 0; // Stats

        public Livreur()
        {
            this.id = Program.livreurList.Count();
            this.commandes = new List<Commande>();
            Program.livreurList.Add(this);
        }

        static async Task livrer(Commande commande)
        {
            commande.statut = Statut.EnLivraison;
            Random random = new Random();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Commande " + commande.num + " en livraison...");
            Console.ResetColor();
            await Task.Delay(random.Next(2000, 5000)); // Temps aléatoire mis pour livrer
            return;
        }

        // Ajoute une commande à la liste du livreur
        public void addCommande(Commande commande)
        {
            commandes.Add(commande);
            nbCommandes += 1;
        }
    }
}

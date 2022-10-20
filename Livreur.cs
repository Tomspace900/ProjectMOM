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

        public static async Task attribuerLivreur(Commande commande)
        {
            int nbCommandes = 0;
            bool condition = true;
            while (condition)
            {
                foreach (var livreur in Program.livreurList)
                {
                    if (nbCommandes == livreur.commandes.Count())
                    {
                        livreur.addCommande(commande);
                        Console.WriteLine("Commande " + commande.num + " confiée au livreur " + livreur.id);
                        commande.livreur = livreur;
                        condition = false;
                        break;
                    }
                }
                nbCommandes++;
            }
            await livrer(commande);
        }

        public static async Task livrer(Commande commande)
        {
            commande.statut = Statut.EnLivraison;
            Random random = new Random();
            Program.coloredString("Commande " + commande.num + " en livraison...", ConsoleColor.Yellow);
            await Task.Delay(random.Next(2000, 5000)); // Temps aléatoire mis pour livrer (2s - 5s)
            commande.livreur.commandes.Remove(commande); // Supprime des commandes du livreur une fois livrée
            Program.coloredString("Commande " + commande.num + " livrée !", ConsoleColor.Green);
            //if (commande.livreur.commandesEnAttente != null)
            //{
            //    commande.livreur.commandeEnCours = commande.livreur.commandesEnAttente[0];
            //    commande.livreur.commandesEnAttente.Remove(commande.livreur.commandesEnAttente[0]);
            //}
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

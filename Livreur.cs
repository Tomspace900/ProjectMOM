using System;
using System.Net;

namespace ProjectMOM
{
    public class Livreur
    {
        public int id;
        public Commande commandeEnCours;
        public List<Commande> commandesEnAttente;
        public int nbCommandes = 0; // Stats

        public Livreur()
        {
            this.id = Program.livreurList.Count();
            this.commandesEnAttente = new List<Commande>();
            Program.livreurList.Add(this);
        }

        public static void attribuerLivreur(Commande commande)
        {
            int nbCommandesEnAttente = 0;

            bool condition = true;
            while (condition)
            {
                foreach (var livreur in Program.livreurList)
                {
                    if (nbCommandesEnAttente == livreur.commandesEnAttente.Count())
                    {
                        livreur.addCommande(commande);
                        Console.WriteLine("Commande " + commande.num + " Livreur " + livreur.id);
                        condition = false;
                        break;
                    }
                }
                nbCommandesEnAttente++;
            }
        }

        public static async Task livrer(Commande commande)
        {
            commande.statut = Statut.EnLivraison;
            Random random = new Random();
            Program.coloredString("Commande " + commande.num + " en livraison...", ConsoleColor.Yellow);
            await Task.Delay(random.Next(2000, 5000)); // Temps aléatoire mis pour livrer
            if (commande.livreur.commandesEnAttente != null)
            {
                commande.livreur.commandeEnCours = commande.livreur.commandesEnAttente[0];
                commande.livreur.commandesEnAttente.Remove(commande.livreur.commandesEnAttente[0]);
                Livreur.livrer(commande);
            }
            return;
        }

        // Ajoute une commande à la liste du livreur
        public void addCommande(Commande commande)
        {
            commandesEnAttente.Add(commande);
            nbCommandes += 1;
        }
    }
}

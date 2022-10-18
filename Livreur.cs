using System;
using System.Net;

namespace ProjectMOM
{
    public class Livreur
    {
        public int id;
        public List<Commande> commandes;
        public int nbCommandes = 0; // Pour les stats

        public Livreur(int id)
        {
            this.id = id;
            this.commandes = new List<Commande>();
        }

        static async Task Livrer(Commande commande)
        {
            commande.statut = Statut.EnLivraison;
            Random random = new Random();
            await Task.Delay(random.Next(2000, 5000)); // Temps aléatoire mis pour livrer
            commande.commis.terminerCommande(commande);
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


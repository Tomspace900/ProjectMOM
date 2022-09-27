using System;
namespace ProjectMOM
{
    public class Livreur
    {
        public int id;
        public List<Commande> commandesALivrer;
        public List<Commande> commandesLivrees;
        public int nbCommandes = 0; // Pour les stats

        public Livreur(int id)
        {
            this.id = id;
            this.commandesALivrer = new List<Commande>();
            this.commandesLivrees = new List<Commande>();
        }

        // Ajoute une commande à la liste commandesALivrer et change son statut
        public void addCommande(Commande commande)
        {
            commandesALivrer.Add(commande);
            commande.statut = Statut.EnLivraison;
            nbCommandes += 1;
        }

        // Passe la commande dans les commandes livrees
        public void livrerCommande(Commande commande)
        {
            if (commandesALivrer.Contains(commande))
            {
                commandesALivrer.Remove(commande);
                commandesLivrees.Add(commande);
                commande.commis.terminerCommande(commande);
            }
            else
            {
                Console.WriteLine("La commande n'était pas confiée à ce livreur");
            }
        }
    }
}


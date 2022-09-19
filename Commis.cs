using System;
namespace ProjectMOM
{
    public class Commis
    {
        public int id;
        public List<Commande> commandesEnAttenteLivraison;
        public List<Commande> commandesLivrees;
        public int nbCommandes = 0; // Pour les stats

        public Commis(int id)
        {
            this.id = id;
            this.commandesEnAttenteLivraison = new List<Commande>();
            this.commandesLivrees = new List<Commande>();
        }

        public void prendreCommande()
        {
            // Ca va etre la grosse fonction avec new Commande
            nbCommandes += 1;
        }

        // Attribue une commande à un livreur
        public void attribuerCommandeLivreur(Commande commande, Livreur livreur)
        {
            livreur.addCommande(commande);
        }

        // Passe le statut d'une commande sur Fermee
        public void terminerCommande(Commande commande)
        {
            if (commande.statut == Statut.EnLivraison)
            {
                if (commande.encaissement == Encaissement.Payee)
                {
                    commande.statut = Statut.Fermee;
                    return;
                }
                else
                {
                    Console.WriteLine("La commande n'a pas été payée");
                }
            }
            else
            {
                Console.WriteLine("La commande n'est pas encore en livraison");
            }
        }
    }
}


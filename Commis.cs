using System;
namespace ProjectMOM
{
    public class Commis
    {
        public int id;
        public List<Commande> commandesEnAttenteLivraison;
        public List<Commande> commandesLivrees;
        public static int nbCommandes = 0; // Pour les stats

        public Commis(int id)
        {
            this.id = id;
            this.commandesEnAttenteLivraison = new List<Commande>();
            this.commandesLivrees = new List<Commande>();
        }

        //Création d'un client
        public void creerClient()
        {
            Pizzeria.clientList.createClient(01223562, "Paysant", "Mathilde", "34 du four", "Bry sur Marne", 94360);
        }

        public static void createCommande1(Commis commis,Client client)
        {
            nbCommandes += 1;
            Commande commande = new Commande(0, DateOnly.FromDateTime(DateTime.Today), client, commis);
            Thread.SetData(Thread.GetNamedDataSlot("Commande"), commande);
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


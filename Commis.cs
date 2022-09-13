using System;
namespace ProjectMOM
{
    public class Commis
    {
        public int id;
        public List<Commande> commandesEnAttenteLivraison;
        public List<Commande> commandesLivrees;
        public int nbCommandes;

        public Commis(int id, List<Commande> commandesEnAttenteLivraison, List<Commande> commandesLivrees, int nbCommandes)
        {
            this.id = id;
            this.commandesEnAttenteLivraison = commandesEnAttenteLivraison;
            this.commandesLivrees = commandesLivrees;
            this.nbCommandes = nbCommandes;
        }
    }
}


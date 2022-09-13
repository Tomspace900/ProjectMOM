using System;
namespace ProjectMOM
{
    public class Livreur
    {
        public int id;
        public List<Commande> commandesALivrer;
        public List<Commande> commandesLivrees;
        public int nbCommandes;

        public Livreur(int id, List<Commande> commandesALivrer, List<Commande> commandesLivrees, int nbCommandes)
        {
            this.id = id;
            this.commandesALivrer = commandesALivrer;
            this.commandesLivrees = commandesLivrees;
            this.nbCommandes = nbCommandes;
        }
    }
}


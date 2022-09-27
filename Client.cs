using System;
namespace ProjectMOM
{
    public class Client
    {
        public string nom;
        public string prenom;
        public long tel;
        public string rue;
        public string ville;
        public int zip;
        public DateOnly dateCommande;
        public int nbCommande; // Pour les stats

        public Client(long tel, string nom, string prenom, string rue, string ville, int zip, DateOnly dateCommande)
        {
            this.tel = tel;
            this.nom = nom;
            this.prenom = prenom;
            this.rue = rue;
            this.ville = ville;
            this.zip = zip;
            this.dateCommande = dateCommande;
        }

        public void addCommande()
        {
            nbCommande += 1;
        }
    }
}


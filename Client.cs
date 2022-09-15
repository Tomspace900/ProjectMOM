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
        public string zip;
        public DateOnly dateCommande;
        public int nbCommande;

        public Client(string nom, string prenom, long tel, string rue, string ville, string zip, DateOnly dateCommande)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
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


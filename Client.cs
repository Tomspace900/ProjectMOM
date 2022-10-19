using System;
namespace ProjectMOM
{
    public class Client
    {
        public string tel; // L'identifiant unique
        public string nom;
        public string prenom;
        public string adresse;
        public DateOnly datePremiereCommande;
        public int nbCommande; // Stats

        public Client(string tel) // Créer un nouveau client
        {
            this.tel = tel;
            this.nom = "nom " + tel;
            this.prenom = "prénom " + tel;
            this.adresse = "adresse " + tel;
            this.datePremiereCommande = DateOnly.FromDateTime(DateTime.Today);
        }

        public Client(string tel, string nom, string prenom, string adresse, DateOnly date) // Simuler un ancien client
        {
            this.tel = tel;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.datePremiereCommande = date;
            Program.clientList.Add(this); // Ajout du client à la liste globale
            nbCommande += 1;
        }

        public void addCommande()
        {
            nbCommande += 1;
        }
    }
}


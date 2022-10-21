using System;
namespace ProjectMOM
{
    public class Client
    {
        public string tel; // L'identifiant unique
        public string nom;
        public string prenom;
        public string adresse;
        public string ville;
        public DateOnly datePremiereCommande;
        public int nbCommande = 0; // Stats
        public double depenses = 0;

        public Client(string tel) // Créer un nouveau client
        {
            this.tel = tel;
            this.nom = tel;
            this.prenom = "Prénom";
            this.adresse = "adresse " + tel;
            this.ville = "ville " + tel;
            this.datePremiereCommande = DateOnly.FromDateTime(DateTime.Today);
        }

        public Client(string tel, string nom, string prenom, string adresse, string ville, DateOnly date) // Simuler un ancien client
        {
            this.tel = tel;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.ville = ville;
            this.datePremiereCommande = date;
            Program.clientList.Add(this); // Ajout du client à la liste globale
        }

        public static async Task isNewClient(string tel)
        {
            Client client = findClientByTel(tel);
            if (client != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Program.coloredString("Le client existe déjà.\nBienvenue " + client.prenom + " " + client.nom + " !", ConsoleColor.Green);
            }
            else if (client == null)
            {
                Program.coloredString("Client introuvable.", ConsoleColor.Red);
                await creerClient(tel); // Creer un nouveau client
            }
        }

        // Trouver un client avec son tel
        public static Client findClientByTel(string tel)
        {
            foreach (Client client in Program.clientList)
            {
                if (tel == client.tel)
                {
                    return client;
                }
            }
            return null;
        }

        // Creer un nouveau client (prend 2s)
        static async Task creerClient(string tel)
        {
            Console.WriteLine("Création du nouveau client...");
            await Task.Delay(1500);
            Client client = new Client(tel);
            Program.clientList.Add(client); // Ajout d'un client à la liste globale
            Program.coloredString("Nouveau client " + tel + " créé.", ConsoleColor.Green);
        }

        public async Task recupererCommande(Commande commande)
        {
            nbCommande += 1; // Stats
            commande.encaissement = Encaissement.Payee; // Le client paye
            Program.coloredString("Commande " + commande.num + " livrée à " + commande.client.prenom + " !", ConsoleColor.Green);
        }

        public override String ToString()
        {
            return nom + " " + prenom + " (" + tel + ") : " + nbCommande + " commande(s) (" + depenses + "€)";
        }
    }
}


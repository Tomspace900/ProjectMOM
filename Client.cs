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
        static async Task creerClient(String tel)
        {
            Console.WriteLine("Création du nouveau client...");
            await Task.Delay(2000);
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

    }
}


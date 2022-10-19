using System;
namespace ProjectMOM
{
    public class Commis
    {
        public int id;
        public int nbCommandes = 0; // Stats

        public Commis()
        {
            this.id = Program.commisList.Count();
            Program.commisList.Add(this);
        }

        public async Task prendreCommande()
        {
            // Choix d'un numéro au hasard (renseigné par le client)
            List<string> tels = new List<string>();
            tels.Add("0124586598");
            tels.Add("0698965236");
            tels.Add("0765426982");
            tels.Add("0165687532");
            tels.Add("0123456789");
            tels.Add("0112223562");
            Random r = new Random();
            String tel = tels[r.Next(tels.Count())];
            Console.WriteLine("Recherche du numéro " + tel + " dans la liste des clients...");
            if (findClientByTel(tel) != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Client déjà existant.");
                Console.WriteLine("Bienvenue " + findClientByTel(tel).prenom + " " + findClientByTel(tel).nom + " !");
                Console.ResetColor();
            }
            else if (findClientByTel(tel) == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Client introuvable.");
                Console.ResetColor();
                await creerClient(tel); // Creer un nouveau client
            }
            await creerCommande(Program.commandes.Count(), findClientByTel(tel)); // Creer une nouvelle commande
        }

        // Creer un nouveau client (prend 2s)
        public async Task creerClient(String tel)
        {
            Console.WriteLine("Création d'un nouveau client...");
            await Task.Delay(2000);
            Client client = new Client(tel);
            Program.clientList.Add(client); // Ajout d'un client à la liste globale
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nouveau client " + tel + " créé.");
            Console.ResetColor();
        }

        // Creer une nouvelle commande (prend 1s)
        public async Task creerCommande(int index, Client client)
        {
            Console.WriteLine("Prise de commande en cours...");
            await Task.Delay(1000);
            Commande commande = new Commande(index, client, this); // Création de la commande
            Program.commandes.Add(commande); // Ajout de la commande à la liste globale
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(commande.displayCommande());
            Console.ResetColor();
            commande.client.addCommande(); // Stats
            nbCommandes++; // Stats
        }

        // Trouver un client avec son tel
        public Client findClientByTel(string tel)
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


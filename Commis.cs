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

        public static async Task prendreCommande(int index, Commis commis)
        {
            // Choix d'un numéro au hasard (renseigné par le client)
            List<string> tels = new List<string>();
            tels.Add("0124586598");
            tels.Add("0698965236");
            tels.Add("0765426982");
            tels.Add("0165687532");
            tels.Add("0123456789"); // Client existant Thomas GENDRON
            tels.Add("0112223562"); // Client existant Mathilde PAYSANT
            Random r = new Random();
            string tel = tels[r.Next(tels.Count())];
            Console.WriteLine("Le commis recherche le numéro " + tel + " dans la liste des clients...");
            await Client.isNewClient(tel); // Cherche s'il s'agit d'un nouveau ou ancien client
            Client client = Client.findClientByTel(tel);
            await creerCommande(index, client, commis); // Creer une nouvelle commande
        }

        // Creer une nouvelle commande (prend 1s)
        static async Task creerCommande(int index, Client client, Commis commis)
        {
            Console.WriteLine(client.prenom + " est en train de commander...");
            Random random = new Random();
            await Task.Delay(random.Next(1000, 3000)); // Temps aléatoire mis pour commander (1s - 3s)
            Commande commande = new Commande(index, client, commis); // Création de la commande
            Program.commandes.Add(commande); // Ajout de la commande à la liste globale
            Program.coloredString(commande.displayCommande(), ConsoleColor.Magenta); // Affiche la commande
            commis.nbCommandes++; // Stats
            Program.coloredString("Envoi de la commande " + commande.num + " en cuisine, préparation en cours...", ConsoleColor.Yellow);
            await Cuisine.preparer(commande); // Envoi la commande en cuisine
        }

        // Récupère la commande des cuisines pour donner à un livreur
        public static async Task preparationTerminee(Commande commande)
        {
            Program.coloredString("Commande " + commande.num + " prête !", ConsoleColor.White);

            await Livreur.attribuerLivreur(commande); // Attribue la commande au livreur qui a le moins de commandes
        }

        // Passe le statut d'une commande sur Fermee
        public async Task terminerCommande(Commande commande)
        {
            if (commande.statut == Statut.EnLivraison)
            {
                if (commande.encaissement == Encaissement.Payee)
                {
                    commande.statut = Statut.Fermee;
                    Program.coloredString("La commande " + commande.num + " est encaissée (" + commande.prix + "€) et fermée.", ConsoleColor.White);
                    commande.client.depenses += commande.prix;
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

        public override string ToString()
        {
            return "Commis "+id+" : "+nbCommandes+" commande(s)";
        }
    }


}


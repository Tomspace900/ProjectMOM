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

        public static async Task prendreCommande(Commis commis)
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
            String tel = tels[r.Next(tels.Count())];
            Console.WriteLine("Le commis recherche le numéro " + tel + " dans la liste des clients...");
            await Client.isNewClient(tel); // Cherche s'il s'agit d'un nouveau ou ancien client
            Client client = Client.findClientByTel(tel);
            await creerCommande(Program.commandes.Count(), client, commis); // Creer une nouvelle commande
        }

        // Creer une nouvelle commande (prend 1s)
        static async Task creerCommande(int index, Client client, Commis commis)
        {
            Console.WriteLine(client.prenom + " est en train de commander...");
            await Task.Delay(1000);
            Commande commande = new Commande(index, client, commis); // Création de la commande
            Program.commandes.Add(commande); // Ajout de la commande à la liste globale
            Program.coloredString(commande.displayCommande(), ConsoleColor.Magenta); // Affiche la commande
            commande.client.addCommande(); // Stats
            commis.nbCommandes++; // Stats
            Program.coloredString("Envoie de la commande " + commande.num + " en cuisine, préparation en cours...", ConsoleColor.Yellow);
            await Cuisine.preparer(commande); // Envoie la commande en cuisine
        }

        // Attribue une commande à un livreur
        public static async Task preparationTerminee(Commande commande)
        {
            Program.coloredString("Commande " + commande.num + " prête !", ConsoleColor.Yellow);

            // TODO C'EST ICI MATHILDE

            await Livreur.livrer(commande); // Envoie la commande au livreur
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


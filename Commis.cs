using System;
namespace ProjectMOM
{
    public class Commis
    {
        public int id;
        public int nbCommandes = 0; // Pour les stats

        public Commis(int id)
        {
            this.id = id;
        }

        public async Task prendreCommande()
        {
            //choix d'un numéro au hasard
            String[] tels = new String[20];
            tels[0] = "0124586598";
            tels[1] = "0698965236";
            tels[2] = "0765426982";   
            tels[3] = "0165687532";
            Random r = new Random();
            String tel = tels[r.Next(4)];
            Console.WriteLine("Recherche du numéro" + tel +" dans la liste des clients...");
            if (Pizzeria.clientList.getByTel(tel) == null)
            {
                Console.WriteLine("Client introuvable.");
                await creationClient(tel);
            }
            Console.WriteLine("Prise de commande");
        }

        public async Task creationClient(String tel)
        {
            Console.WriteLine("Création d'un nouveau client...");
            //ajouter temps
            Pizzeria.clientList.createClient(tel,"nom "+tel,"prénom "+tel,"adresse "+tel,"ville "+tel,0);
            Console.WriteLine("Nouveau client "+tel+" créé.");
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


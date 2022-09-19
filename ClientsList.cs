using System;
namespace ProjectMOM
{
    public class ClientsList
    {
        public List<Client> clientsList;
        public int idClient; // id unique des clients

        public ClientsList()
        {
            this.clientsList = new List<Client>();
        }

        public bool isFirstCommand(int tel)
        {
            foreach (var client in clientsList)
            {
                if (client.tel == tel)
                {
                    return false; // Le client a deja un compte
                }
            }
            return true; // C'est la premiere commande du client
        }

        public void createClient(long tel, string nom, string prenom, string rue, string ville, int zip)
        {
            idClient += 1; // incrementation de l'id
            var today = DateOnly.FromDateTime(DateTime.Now); // Date de la 1ere commande = today
            clientsList.Add(new Client(tel, nom, prenom, rue, ville, zip, today));
        }
    }
}


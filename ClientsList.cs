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

        public void createClient(String tel, string nom, string prenom, string rue, string ville, int zip)
        {
            idClient += 1; // incrementation de l'id
            var today = DateOnly.FromDateTime(DateTime.Now); // Date de la 1ere commande = today
            clientsList.Add(new Client(tel, nom, prenom, rue, ville, zip, today));
        }

        public Client getByTel(String tel)
        {
            foreach (Client client in clientsList)
            {
                if (tel == client.tel)
                {
                    return client;
                }
            }
            return null;
        }
    }
}


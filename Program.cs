using System;

namespace ProjectMOM
{
    public class Program
    {
        public Cuisine cuisine;
        public List<Commande> commandes = new List<Commande>();
        public List<Commande> commandesEnCours = new List<Commande>();

        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuti a Marco");

            CommisList commis = new CommisList();
            commis.createCommis();
            commis.createCommis();
            ClientsList clients = new ClientsList();
            clients.createClient(0123456789, "GENDRON", "Thomas", "rue du Trosy", "CLAMART", 92140);
            new Client(01223562, "Paysant", "Mathilde", "34 du four", "Bry sur Marne", 94360, DateOnly.FromDateTime(DateTime.Today));
            Console.WriteLine(clients.isFirstCommand(0123456789));
        }

        //création d'une commande exemple
       public void takeCommande()
        {
            Thread commande1 = new(new ThreadStart(createCommande1));
            commande1.Start();

        }


        public static void createCommande1(){
            Commis.nbCommandes += 1;
            Commande commande = new Commande(0, DateOnly.FromDateTime(DateTime.Today), Pizzeria.clientList.getByTel(01223562), Pizzeria.commisList.getById(1));
            Thread.SetData(Thread.GetNamedDataSlot("Commande"), commande);
        }


    }
}
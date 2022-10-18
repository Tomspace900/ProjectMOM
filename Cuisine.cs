using System;
namespace ProjectMOM
{
    public class Cuisine
    {
        public List<Commande> comandesAFaire;

        public Cuisine()
        {
            this.comandesAFaire = new List<Commande>();
        }
    }
}


using System;
namespace ProjectMOM
{
    public class Cuisine
    {
        public List<Commande> comandesAFaire;

        public Cuisine(List<Commande> comandesAFaire)
        {
            this.comandesAFaire = comandesAFaire;
        }
    }
}


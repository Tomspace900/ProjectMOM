using System;
namespace ProjectMOM
{
    public class Boisson : IConsommable
    {
        public TypeBoisson type;
        public TailleBoisson taille;
        public double prix;

        public Boisson(TypeBoisson type)
        {
            this.type = type;
        }

        public double getPrix()
        {
            return prix;
        }

        public string getNom()
        {
            return (type.ToString() + " " + taille.ToString());
        }
    }
}


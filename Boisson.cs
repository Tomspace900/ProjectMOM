using System;
namespace ProjectMOM
{
    public class Boisson : IConsommable
    {
        public TypeBoisson type;
        public TailleBoisson taille;
        public double prix;

        public Boisson(TailleBoisson taille, TypeBoisson type)
        {
            this.taille = taille;
            this.type = type;
            CalculerPrix(taille, type);
        }

        public double getPrix()
        {
            return prix;
        }

        public string getNom()
        {
            return (type.ToString() + " " + taille.ToString());
        }

        // Calcule le prix en fonction de la taille et du type
        public void CalculerPrix(TailleBoisson taille, TypeBoisson type)
        {
            this.prix = Catalogue.getPrixBoisson(taille, type);
        }
    }
}


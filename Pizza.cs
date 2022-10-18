using System;
namespace ProjectMOM
{
    public class Pizza : IConsommable
    {
        public TaillePizza taille;
        public TypePizza type;
        public double prix;

        public Pizza(TaillePizza taille, TypePizza type)
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
        public void CalculerPrix(TaillePizza taille, TypePizza type)
        {
            this.prix = Catalogue.getPrixPizza(taille, type);
        }
    }
}
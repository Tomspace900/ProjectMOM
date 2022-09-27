using System;
namespace ProjectMOM
{
    public class Pizza
    {
        public TaillePizza taille;
        public TypePizza type;
        public double totalPrice;

        public Pizza(TaillePizza taille, TypePizza type)
        {
            this.taille = taille;
            this.type = type;
            CalculerPrix(taille, type);
        }

        public void CalculerPrix(TaillePizza taille, TypePizza type)
        {

            this.totalPrice = PrixType(type, PrixTaille(taille));
        }

        public double PrixTaille(TaillePizza taille)
        {
            double price = 0;

            if (taille == TaillePizza.S)
            {
                price += 10;
                return price;
            }
            else if (taille == TaillePizza.M)
            {
                price += 14;
                return price;
            }
            else if (taille == TaillePizza.L)
            {
                price += 18;
                return price;
            }
            else throw new Exception("La taille de pizza n'existe pas");
        }

        public double PrixType(TypePizza type, double price)
        {
            if (type == TypePizza.Calzone)
            {
                price += 2;
                return price;
            }
            else if (type == TypePizza.ChevreMiel)
            {
                price += 3;
                return price;
            }
            else if (type == TypePizza.Hawaienne)
            {
                price += 3;
                return price;
            }
            else if (type == TypePizza.Kebab)
            {
                price += 3.5;
                return price;
            }
            else if (type == TypePizza.Margherita)
            {
                price += 0;
                return price;
            }
            else if (type == TypePizza.QuatreFromages)
            {
                price += 3;
                return price;
            }
            else if (type == TypePizza.QuatreSaisons)
            {
                price += 3;
                return price;
            }
            else if (type == TypePizza.Raclette)
            {
                price += 4;
                return price;
            }
            else if (type == TypePizza.Reine)
            {
                price += 2.5;
                return price;
            }
            else if (type == TypePizza.Salami)
            {
                price += 2.5;
                return price;
            }
            else if (type == TypePizza.Saumon)
            {
                price += 5;
                return price;
            }
            else throw new Exception("Le type de pizza n'existe pas");
        }
    }
}
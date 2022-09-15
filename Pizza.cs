using System;
namespace ProjectMOM
{
    public class Pizza
    {
        public TaillePizza taille;
        public TypePizza type;

        public Pizza(TaillePizza taille, TypePizza type)
        {
            this.taille = taille;
            this.type = type;
        }
    }
}


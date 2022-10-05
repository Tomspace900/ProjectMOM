using System;
namespace ProjectMOM
{
    public class Catalogue
    {
        public Dictionary<TaillePizza, double> tabTaillePizza;
        public Dictionary<TypePizza, double> tabTypePizza = new Dictionary<TypePizza, double>();
        public Dictionary<TailleBoisson, double> tabTailleBoisson = new Dictionary<TailleBoisson, double>();
        public Dictionary<TypeBoisson, double> tabTypeBoisson = new Dictionary<TypeBoisson, double>();

        public Catalogue()
        {
            tabTaillePizza = new Dictionary<TaillePizza, double>()
            {
                { TaillePizza.S, 10},
                { TaillePizza.M, 14},
                { TaillePizza.L, 18},
            };
            tabTypePizza = new Dictionary<TypePizza, double>()
            {
                { TypePizza.Margherita, 0 },
                { TypePizza.Reine, 2.5 },
                { TypePizza.QuatreFromages, 3 },
                { TypePizza.QuatreSaisons, 3 },
                { TypePizza.Calzone, 2 },
                { TypePizza.ChevreMiel, 3 },
                { TypePizza.Saumon, 5 },
                { TypePizza.Hawaienne, 3 },
                { TypePizza.Salami, 2.5 },
                { TypePizza.Raclette, 4 },
                { TypePizza.Kebab, 3.5 },
            };
            tabTailleBoisson = new Dictionary<TailleBoisson, double>()
            {
                { TailleBoisson.S, 2 },
                { TailleBoisson.M, 3 },
                { TailleBoisson.L, 4 },
                { TailleBoisson.XL, 5 },
                { TailleBoisson.XXL, 6 },
            };
            tabTypeBoisson = new Dictionary<TypeBoisson, double>()
            {
                { TypeBoisson.CocaCola, 0 },
                { TypeBoisson.IceTea, 0 },
                { TypeBoisson.Sprite, 0 },
                { TypeBoisson.JusDOrange, 1 },
                { TypeBoisson.JusDAbricot, 1 },
                { TypeBoisson.Heineken, 2 },
            };
        }
    }
}
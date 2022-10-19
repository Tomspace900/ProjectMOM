using System;
namespace ProjectMOM
{
    public class Catalogue
    {
        public static Dictionary<TaillePizza, double> tabTaillePizza = new Dictionary<TaillePizza, double>()
            {
                { TaillePizza.S, 8},
                { TaillePizza.M, 12},
                { TaillePizza.L, 16},
            };
        public static Dictionary<TypePizza, double> tabTypePizza = new Dictionary<TypePizza, double>()
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
        public static Dictionary<TailleBoisson, double> tabTailleBoisson = new Dictionary<TailleBoisson, double>()
            {
                { TailleBoisson.S, 2 },
                { TailleBoisson.M, 3 },
                { TailleBoisson.L, 4 },
                { TailleBoisson.XL, 5 },
                { TailleBoisson.XXL, 6 },
            };
        public static Dictionary<TypeBoisson, double> tabTypeBoisson = new Dictionary<TypeBoisson, double>()
            {
                { TypeBoisson.CocaCola, 0 },
                { TypeBoisson.IceTea, 0 },
                { TypeBoisson.Sprite, 0 },
                { TypeBoisson.JusDOrange, 1 },
                { TypeBoisson.JusDAbricot, 1 },
                { TypeBoisson.Heineken, 2 },
            };

        public static double getPrixPizza(TaillePizza taille, TypePizza type)
        {
            return tabTaillePizza[taille] + tabTypePizza[type];
        }

        public static double getPrixBoisson(TailleBoisson taille, TypeBoisson type)
        {
            return tabTailleBoisson[taille] + tabTypeBoisson[type];
        }
    }
}
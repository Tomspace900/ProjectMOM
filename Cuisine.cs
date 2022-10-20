using System;
namespace ProjectMOM
{
    public class Cuisine
    {
        public Cuisine()
        {

        }

        public static async Task preparer(Commande commande)
        {
            int i = commande.pizzas.Count;
            await Task.Delay(i * 8000); // Temps de preparation proportionnel à la longueur de la commande -> 1 pizza = 10s
            await Commis.preparationTerminee(commande);
        }
    }
}

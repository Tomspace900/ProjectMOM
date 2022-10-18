using System;
namespace ProjectMOM
{
    public class Cuisine
    {
        public Cuisine()
        {
            static async Task Preparer(Commande commande)
            {
                int i = commande.pizzas.Count;
                await Task.Delay(i * 1000); // Temps de preparation proportionnel à la longueur de la commande
            }
        }
    }
}

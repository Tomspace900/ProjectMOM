using System;
namespace ProjectMOM
{
    public class LivreursList
    {
        public List<Livreur> livreursList;
        public int idLivreur;

        public LivreursList()
        {
            this.livreursList = new List<Livreur>();
        }

        public void createLivreur()
        {
            idLivreur += 1;
            livreursList.Add(new Livreur(idLivreur));
        }
    }
}


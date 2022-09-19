using System;
namespace ProjectMOM
{
    public class CommisList
    {
        public List<Commis> commisList;
        public int idCommis;

        public CommisList()
        {
            this.commisList = new List<Commis>();
        }

        public void createCommis()
        {
            idCommis += 1;
            commisList.Add(new Commis(idCommis));
        }
    }
}


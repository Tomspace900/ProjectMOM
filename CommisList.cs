using System;
using System.Security.AccessControl;

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

        public Commis getById(int id)
        {
            foreach (Commis commis in commisList)
            {
                if (id == commis.id)
                {
                    return commis;
                }
            }
            return null;
        }
    }
}


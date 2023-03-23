using DocProject.Models;

namespace DocProject.Repo
{
    public class RestoRepo : Irepo
    {
        public List<Resto> restos { get; set; }

        public RestoRepo()
        {
            restos = new List<Resto> {
                new Resto
                {
                    uuid=1,
                    name="Resto1",
                    description="lorem epkfd fklfsfmqm dlds",
                    rating=5,
                    

                },
                    new Resto
                {
                    uuid=2,
                    name="Resto2",
                    description="lorem epkfd fklfsfmqm dlds",
                    rating=4,


                },
                     new Resto
                {
                    uuid=3,
                    name="Resto3",
                    description="lorem epkfd fklfsfmqm dlds",
                    rating=2,


                }
            };
        }
        public bool AddResto(Resto resto)
        {
            if (resto != null) { restos.Add(resto); return true; }
            return false;

            
        }

        public bool DeleteResto(int id)
        {
            
            Resto restoDeleted = GetResto(id);
           if (restoDeleted != null)
            {
                restos.Remove(restoDeleted);
                return true;
            }
           return false;
        }

        public List<Resto> GetAllResto()
        {
           return restos;
        }

        public Resto? GetResto(int id)
        {           
            return restos.SingleOrDefault(r => r.uuid.Equals(id)); ;
        }

        public bool UpdateResto(Resto resto,int id)
        {
            var updatedResto = GetResto(id);   
            if(updatedResto != null)
            {
                updatedResto.description= resto.description;
                updatedResto.name= resto.name;
                updatedResto.rating= resto.rating;
               return true;
            }
            return false;

        }

        public int getTheLastId()
        {
            return restos.LastOrDefault().uuid;
        }
    }
}

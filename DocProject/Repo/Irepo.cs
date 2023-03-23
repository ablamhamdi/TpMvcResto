using DocProject.Models;

namespace DocProject.Repo
{
    public interface Irepo
    {
        public List<Resto> restos { get; set; }
        public bool DeleteResto(int id);
        public bool AddResto(Resto resto);
        public bool UpdateResto(Resto resto,int id);
        public List<Resto> GetAllResto();
        public Resto? GetResto(int id);
        public int getTheLastId();
    }
}

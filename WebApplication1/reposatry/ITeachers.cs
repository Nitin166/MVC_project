using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public interface ITeachers
    {
       public List<Teachers> GetAllTeachers();
        public Teachers GetById(int Id);
        public void Insert(Teachers teachers);
        public void DeleteById(int Id);
        public void UpdateTeachers(int Id,Teachers teachers);
    }
}

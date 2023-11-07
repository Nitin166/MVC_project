using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public interface IParasEmployee
    {
        public List<ParasEmployee> GetAllEmployee();
        public ParasEmployee GetById(int id);
        public void InsertEmployee(ParasEmployee employee);
        public void DeleteEmployee(int Id);
        public void UpdateParasEmployee(int Id,ParasEmployee employee);

    }
}

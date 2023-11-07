using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public interface IOfficeEmployee
    {
        public List<OfficeEmployee> GetAllOfficeEmployee();
        public int GetById(int Id);
        public void InsertOfficeEmploye(OfficeEmployee officeEmployee);
        public void UpdateOfficeEmploye(int Id, OfficeEmployee OfficeEmployee);



    }
}

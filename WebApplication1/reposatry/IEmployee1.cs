using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public interface IEmployee1
    {
        public List<Employee1> GetAllEmployee();
        public Employee1 GetById(int Id);
        public void InsertEmployee(Employee1 Employee);
        public void UpdateEmployee(int Id,Employee1 Employee);
        public void DeleteEmployee(int Id);


    }
}

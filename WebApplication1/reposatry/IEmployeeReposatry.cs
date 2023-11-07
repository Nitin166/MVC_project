using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public interface IEmployeeReposatry
    {
        public List<Employee> GetAllEmployees();
        public Employee GetById(int id);
        public void InsertEmployee(Employee employee);
        public void UpdateEmployee(int id,Employee employee);
        public void DeleteEmployee(int id); 

    }
}

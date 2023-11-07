using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public class EmployeeReposatory : IEmployeeReposatry
    {
        public List<Employee> lstEmployee;
        public EmployeeReposatory()
        {
            lstEmployee = new List<Employee>();
            Employee objemp = new Employee();
            objemp.Id =1;
            objemp.Name="shivani";
            objemp.Salary=300000;
            objemp.City = "delhi";
            lstEmployee.Add(new Employee() { Id =2, Name ="nikki", Salary=10000, City ="gulaothi" });
            lstEmployee.Add(new Employee() { Id=3, Name="vishal", Salary= 20000, City ="bulandshahr" });



        }
        public void DeleteEmployee(int id)
        {
            var emp = lstEmployee.First(item=>item.Id ==id);
            lstEmployee.Remove(emp);
        }

        public List<Employee> GetAllEmployees()
        {
            return lstEmployee;
        }

        public Employee GetById(int id)
        {
            return lstEmployee.First(item => item.Id==id);
        }

        public void InsertEmployee(Employee employee)
        {
            lstEmployee.Add( employee);
        }

        public void UpdateEmployee(int id, Employee employee)
        {
        var emp=    lstEmployee.First(item => item.Id ==id);
            emp.Id= employee.Id;
            emp.Name=employee.Name;
            emp.Salary=employee.Salary;
            emp.City= employee.City;



        }
    }
}

using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public class Employee1Reposatory : IEmployee1
    {
        List<Employee1> lstemployee;
        public Employee1Reposatory()
            {
            lstemployee = new List<Employee1>();
            lstemployee.Add(new Employee1() { Id=1, Name="nikki", Salary=10000, City = "delhi" });
            lstemployee.Add(new Employee1() { Id=2, Name="Alisha", Salary=10000, City = "delhi" });
            lstemployee.Add(new Employee1() { Id=3, Name="Ram", Salary=10000, City = "delhi" });
            lstemployee.Add(new Employee1() { Id=4, Name="mohan", Salary=10000, City = "delhi" });


        }
        public void DeleteEmployee(int Id)
        {
            var emp = lstemployee.First(item => item.Id ==Id);
            lstemployee.Remove(emp);

        }

        public List<Employee1> GetAllEmployee()
        {
           return lstemployee; 
        }

        public Employee1 GetById(int Id)
        {
            return lstemployee.First(item => item.Id == Id);
        }

        public void InsertEmployee(Employee1 Employee)
        {
            lstemployee.Add(Employee);
        }

        public void UpdateEmployee(int Id, Employee1 Employee)
        {
            var emp = lstemployee.First(item => item.Id == Id);
            emp.Id = Employee.Id;
            emp.Name = Employee.Name;
            emp.Salary= Employee.Salary;
            emp.City= Employee.City;

        }
    }
}

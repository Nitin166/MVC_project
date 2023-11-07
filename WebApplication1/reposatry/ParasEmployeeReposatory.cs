using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public class ParasEmployeeReposatory : IParasEmployee
    {
        public static List<ParasEmployee> listparasemployee;
        static ParasEmployeeReposatory()
        {
listparasemployee= new List<ParasEmployee>();
            listparasemployee.Add(new ParasEmployee() { Id = 1, Name="Nitin", City = "Delhi", Salary=200050 });
            listparasemployee.Add(new ParasEmployee() { Id = 2, Name="Vishal", City = "Hapur", Salary=205000 });
            listparasemployee.Add(new ParasEmployee() { Id = 3, Name="Rohan", City = "Noida", Salary=20000 });
            listparasemployee.Add(new ParasEmployee() { Id = 4, Name="Mohan", City = "Punjab", Salary=250000 });
            listparasemployee.Add(new ParasEmployee() { Id = 5, Name="Shayam", City = "Chandighar", Salary=50000 });


        }
        public void DeleteEmployee(int Id)
        {
            var emp = listparasemployee.First(item => item.Id==Id);
            listparasemployee.Remove(emp);
        }

        public List<ParasEmployee> GetAllEmployee()
        {
            return listparasemployee;
        }

        public ParasEmployee GetById(int id)
        {
          return  listparasemployee.First(item => item.Id == id);
        }

        public void InsertEmployee(ParasEmployee employee)
        {
            listparasemployee.Add(employee);
        }

        public void UpdateParasEmployee(int Id, ParasEmployee employee)
        {
            var employe = listparasemployee.First(item => item.Id==Id);
            employe.Id =employee.Id;
            employe.Name= employee.Name;
            employe.Salary= employee.Salary;
            employe.City= employee.City;


        }
    }
}

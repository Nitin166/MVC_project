using MessagePack.Formatters;
using NuGet.Protocol.Core.Types;
using System.Collections.Immutable;
using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public class OfficeEmployeeReposatory : IOfficeEmployee
    {

        public List<OfficeEmployee> listemployee;
        public OfficeEmployeeReposatory()
        {
            listemployee = new List<OfficeEmployee>();
            listemployee.Add( new OfficeEmployee() { Id = 1,Name ="nikki",City="gulaothi",Salary= 10000});
            listemployee.Add(new OfficeEmployee() { Id = 2, Name ="nitin", City="gulaothi", Salary= 50000 });
            listemployee.Add(new OfficeEmployee() { Id = 3, Name ="alisha", City="gulaothi", Salary= 40000 });
            listemployee.Add(new OfficeEmployee() { Id = 4, Name ="rahul", City="gulaothi", Salary= 30000 });
            listemployee.Add(new OfficeEmployee() { Id = 5, Name ="anuj", City="gulaothi", Salary= 20000 });

        }
        public List<OfficeEmployee> GetAllOfficeEmployee()
        {
          return listemployee;
        }

        public OfficeEmployee GetById(int Id)
        {
            return listemployee.First(item => item.Id ==Id);
          
        }

        public void InsertOfficeEmploye(OfficeEmployee officeEmployee)
        {
            listemployee.Add(officeEmployee);
        }

        public void UpdateOfficeEmploye(int Id,OfficeEmployee officeEmployee)
        {
            var emp = listemployee.First(item => item.Id==Id);
            emp.Id =officeEmployee.Id;
            emp.Name  = officeEmployee.City;
            emp.Salary= officeEmployee.Salary; 

        }

        int IOfficeEmployee.GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

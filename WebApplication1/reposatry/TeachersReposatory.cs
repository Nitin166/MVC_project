using WebApplication1.Models;

namespace WebApplication1.reposatry
{

    public class TeachersReposatory : ITeachers
    {
        public static List<Teachers> lstteachers;

        static TeachersReposatory()
        {
            lstteachers = new List<Teachers>();
            lstteachers.Add(new Teachers() { ID= 01, Name="Nitin Daksh", Subject="Maths", City = "Gulaothi" });

            lstteachers.Add(new Teachers() { ID= 02, Name="Ankur Daksh", Subject="Science", City = "Gulaothi" });
            lstteachers.Add(new Teachers() { ID= 03, Name="Sharad", Subject="IT", City = "Gulaothi" });
            lstteachers.Add(new Teachers() { ID= 04, Name="Mohan ", Subject="English", City = "Delhi" });
            lstteachers.Add(new Teachers() { ID= 05, Name="Riya", Subject="Hindi", City = "Bulandshahr" });
            lstteachers.Add(new Teachers() { ID= 06, Name="Tanuj", Subject="SST", City = "Noida" });
        }
        public void DeleteById(int Id)
        {
          var emp=  lstteachers.First(item => item.ID==Id);
            lstteachers.Remove(emp);
        }

        public List<Teachers> GetAllTeachers()
        {
            return lstteachers;
        }

        public Teachers GetById(int Id)
        {
            return lstteachers.First(item => item.ID == Id);
        }

        public void Insert(Teachers teachers)
        {
             lstteachers.Add(teachers);
        }

        public void UpdateTeachers(int Id, Teachers teachers)
        {
            var emp = lstteachers.First(item => item.ID ==Id);
            emp.Name= teachers.Name;
            emp.ID = teachers.ID;
            emp.Subject = teachers.Subject;
            emp.City= teachers.City;



        }
    }
}

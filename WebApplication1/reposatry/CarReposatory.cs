using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public class CarReposatory : ICar
    {
        List<Car> lstcar;
        public CarReposatory()
        {
            lstcar = new List<Car>();
            lstcar.Add(new Car() { Name="i10",Color= "blue",Compny="hyundai",Wheel=4});
            lstcar.Add(new Car() { Name="i20", Color= "blue", Compny="hyundai", Wheel=4 });
            lstcar.Add(new Car() { Name="hondacity", Color= "blue", Compny="honda", Wheel=4 });
            lstcar.Add(new Car() { Name="verna", Color= "black", Compny="honda", Wheel=4 });
            lstcar.Add(new Car() { Name="wagonr", Color= "blue", Compny="hyundai", Wheel=4 });


        }
        public int Breakpower(int a)
        {
            return a*10;
        }

        public void deletecar(Car car)
        {
            lstcar.Remove(car);
        }

        public List<Car> GetCars()
        {
            return lstcar;
        }

        public void insertcar(Car car)
        {
            lstcar.Add(car);
        }

        public int Speed(int b)
        {
            return b*2;
        }

        public Car updatecar(Car car)
        {
            return car;
        }
    }
}

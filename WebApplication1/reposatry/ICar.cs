using WebApplication1.Models;

namespace WebApplication1.reposatry
{
    public interface ICar
    {
        public List<Car> GetCars();
        public int Breakpower(int a);
        public int Speed(int b);
        public void insertcar(Car car);
        public Car updatecar(Car car);
        public void deletecar(Car car);

    }
}

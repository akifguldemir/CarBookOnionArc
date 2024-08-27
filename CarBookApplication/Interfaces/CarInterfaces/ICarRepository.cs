using CarbookDomain.Entities;

namespace CarBookApplication.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        List<Car> GetCarsListWithBrands();
        List<Car> GetLAst5CarsWithBrands();
    }
}

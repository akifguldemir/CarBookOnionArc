using CarbookDomain.Entities;

namespace CarBookApplication.Interfaces.CarFeatureInterfaces
{
    public interface ICarFeatureRepository
    {
        List<CarFeature> GetCarFeaturesByCarId(int carID);
    }
}

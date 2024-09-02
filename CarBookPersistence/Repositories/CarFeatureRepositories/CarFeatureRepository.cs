using CarBookApplication.Interfaces.CarFeatureInterfaces;
using CarbookDomain.Entities;
using CarBookPersistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookPersistence.Repositories.CarFeatureRepositories
{
    public class CarFeatureRepository : ICarFeatureRepository
    {
        private readonly CarBookContext _context;

        public CarFeatureRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<CarFeature> GetCarFeaturesByCarId(int carID)
        {
            var values = _context.CarFeatures.Where(x => x.CarID == carID).ToList();
            return values;
        }
    }
}

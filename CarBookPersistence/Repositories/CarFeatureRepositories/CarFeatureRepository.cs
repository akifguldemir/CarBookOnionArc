using CarBookApplication.Interfaces.CarFeatureInterfaces;
using CarbookDomain.Entities;
using CarBookPersistence.Context;
using Microsoft.EntityFrameworkCore;
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

        public void ChangeCarFeatureAvailableToFalse(int id)
        {
            var value = _context.CarFeatures.Where(x => x.CarFeatureID == id).FirstOrDefault();
            value.Available = false;
            _context.SaveChanges();
        }

        public void ChangeCarFeatureAvailableToTrue(int id)
        {
            var value = _context.CarFeatures.Where(x => x.CarFeatureID == id).FirstOrDefault();
            value.Available = true;
            _context.SaveChanges();
        }

        public List<CarFeature> GetCarFeaturesByCarId(int carID)
        {
            var values = _context.CarFeatures.Include(y=>y.Feature).Where(x => x.CarID == carID).ToList();
            return values;
        }
    }
}

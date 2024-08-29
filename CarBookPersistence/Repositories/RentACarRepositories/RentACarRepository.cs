using CarBookApplication.Interfaces.RentACarInterfaces;
using CarbookDomain.Entities;
using CarBookPersistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CarBookPersistence.Repositories.RentACarRepositories
{
    public class RentACarRepository : IRentACarRepository
    {
        private readonly CarBookContext _context;

        public RentACarRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            var values = await _context.RentACars.Where(filter).Include(x => x.Car).ThenInclude(y => y.Brand).ToListAsync();
            return values;
        }
    }
}


//var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(z => z.Pricing).Where(t => t.PricingID == 2).ToList();


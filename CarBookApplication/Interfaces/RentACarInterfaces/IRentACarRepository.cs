using CarbookDomain.Entities;
using System.Linq.Expressions;

namespace CarBookApplication.Interfaces.RentACarInterfaces
{
    public interface IRentACarRepository
    {
        Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter);
    }
}

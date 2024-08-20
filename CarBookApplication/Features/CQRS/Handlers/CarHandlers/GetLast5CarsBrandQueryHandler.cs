using CarBookApplication.Features.CQRS.Results.CarResults;
using CarBookApplication.Interfaces.CarInterfaces;

namespace CarBookApplication.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarsBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetLast5CarsBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<GetLast5CarsBrandQueryResult> Handle()
        {
            var values = _carRepository.GetLAst5CarsWithBrands();
            return values.Select(x => new GetLast5CarsBrandQueryResult
            {
                BrandName = x.Brand.Name,
                CarID = x.CarID,
                BigImageUrl = x.BigImageUrl,
                BrandID = x.BrandID,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission
            }).ToList();
        }
    }
}

using CarBookApplication.Features.CQRS.Results.CarResults;
using CarBookApplication.Interfaces;
using CarBookApplication.Interfaces.CarInterfaces;
using CarbookDomain.Entities;

namespace CarBookApplication.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetCarWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<GetCarWihtBrandQueryResult> Handle()
        {
            var values = _carRepository.GetCarsListWithBrands();
            return values.Select(x => new GetCarWihtBrandQueryResult
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

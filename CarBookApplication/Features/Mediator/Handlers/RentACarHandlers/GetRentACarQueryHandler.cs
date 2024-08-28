using CarBookApplication.Features.Mediator.Queries.RentACarQueries;
using CarBookApplication.Features.Mediator.Results.RentACarResults;
using CarBookApplication.Interfaces.RentACarInterfaces;
using MediatR;

namespace CarBookApplication.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;

        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationId == request.LocationID && x.Available == true);
            var results = values.Select(x => new GetRentACarQueryResult
            {
                CarId = x.CarID    
            }).ToList();
            return results;
        }
    }
}

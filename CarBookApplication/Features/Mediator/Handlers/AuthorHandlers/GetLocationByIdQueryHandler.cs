using CarBookApplication.Features.Mediator.Queries.LocationQueries;
using CarBookApplication.Features.Mediator.Results.FooterAddressResults;
using CarBookApplication.Features.Mediator.Results.LocationResult;
using CarBookApplication.Interfaces;
using CarbookDomain.Entities;
using MediatR;

namespace CarBookApplication.Features.Mediator.Handlers.LocationHandlers
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly IRepository<Location> _repository;

        public GetAuthorByIdQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetLocationByIdQueryResult
            {
               Name = value.Name,
               LocationID = value.LocationID
            };
        }
    }
}

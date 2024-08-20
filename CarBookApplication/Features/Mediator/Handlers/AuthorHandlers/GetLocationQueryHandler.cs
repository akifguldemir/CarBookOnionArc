using CarBookApplication.Features.Mediator.Queries.LocationQueries;
using CarBookApplication.Features.Mediator.Results.LocationResult;
using CarBookApplication.Interfaces;
using CarbookDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Handlers.LocationHandlers
{
    public class GetAuthorQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
        private readonly IRepository<Location> _repository;

        public GetAuthorQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetLocationQueryResult {
                LocationID = x.LocationID,
                Name = x.Name
            }).ToList();
        }
    }
}

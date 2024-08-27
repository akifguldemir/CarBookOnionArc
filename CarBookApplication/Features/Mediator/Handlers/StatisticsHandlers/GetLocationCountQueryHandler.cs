using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBookApplication.Features.Mediator.Queries.StatisticsQueries;
using CarBookApplication.Features.Mediator.Results.StatisticsResults;
using CarBookApplication.Interfaces.CarInterfaces;
using CarBookApplication.Interfaces.StatisticsInterfaces;

namespace CarBookApplication.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetLocationCountQueryHandler : IRequestHandler<GetLocationCountQuery, GetLocationCountQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetLocationCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationCountQueryResult> Handle(GetLocationCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetLocationCount();
            return new GetLocationCountQueryResult
            {
                LocationCount = value
            };
        }
    }
}

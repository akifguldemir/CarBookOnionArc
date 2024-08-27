using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBookApplication.Features.Mediator.Queries.StatisticsQueries;
using CarBookApplication.Features.Mediator.Results.StatisticsResults;
using CarBookApplication.Interfaces.StatisticsInterfaces;

namespace CarBookApplication.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarBrandAndModelByRentPriceDailyMaxQueryHandler : IRequestHandler<GetCarBrandAndModelByRentPriceDailyMaxQuery, GetCarBrandAndModelByRentPriceDailyMaxQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarBrandAndModelByRentPriceDailyMaxQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarBrandAndModelByRentPriceDailyMaxQueryResult> Handle(GetCarBrandAndModelByRentPriceDailyMaxQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarBrandAndModelByRentPriceDailyMax();
            return new GetCarBrandAndModelByRentPriceDailyMaxQueryResult
            {
                CarBrandAndModelByRentPriceDailyMax = value
            };
        }
    }
}

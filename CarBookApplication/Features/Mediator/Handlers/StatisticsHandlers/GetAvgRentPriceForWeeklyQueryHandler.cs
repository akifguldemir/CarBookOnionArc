﻿using MediatR;
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
    public class GetAvgRentPriceForWeeklyQueryHandler : IRequestHandler<GetAvgRentPriceForWeeklyQuery, GetAvgRentPriceForWeeklyQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAvgRentPriceForWeeklyQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgRentPriceForWeeklyQueryResult> Handle(GetAvgRentPriceForWeeklyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForWeekly();
            return new GetAvgRentPriceForWeeklyQueryResult
            {
                AvgRentPriceForWeekl = value
            };
        }
    }
}

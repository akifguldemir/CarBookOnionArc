using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBookApplication.Features.Mediator.Results.StatisticsResults;

namespace CarBookApplication.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarCountByFuelElectricQuery:IRequest<GetCarCountByFuelElectricQueryResult>
    {
    }
}

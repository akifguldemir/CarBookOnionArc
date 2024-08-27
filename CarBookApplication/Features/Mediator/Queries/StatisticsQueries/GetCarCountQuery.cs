using CarBookApplication.Features.Mediator.Results.StatisticsResults;
using MediatR;

namespace CarBookApplication.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarCountQuery : IRequest<GetCarCountQueryResult>
    {
    }
}

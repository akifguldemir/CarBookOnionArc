using CarBookApplication.Features.Mediator.Results.FeatureResults;
using MediatR;

namespace CarBookApplication.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery : IRequest<List<GetFeatureQueryResult>>
    {
    }
}

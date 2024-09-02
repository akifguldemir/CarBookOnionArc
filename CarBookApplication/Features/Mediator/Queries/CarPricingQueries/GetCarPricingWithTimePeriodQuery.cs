using CarBookApplication.Features.Mediator.Results.CarPricingResults;
using MediatR;

namespace CarBookApplication.Features.Mediator.Queries.CarPricingQueries
{
	public class GetCarPricingWithTimePeriodQuery : IRequest<List<GetCarPricingWithTimePeriodQueryResult>>
	{
	}
}

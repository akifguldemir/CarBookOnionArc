using CarBookApplication.Features.Mediator.Results.FooterAddressResults;
using MediatR;

namespace CarBookApplication.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressQuery : IRequest<List<GetFooterAddressQueryResult>>
    {
    }
}

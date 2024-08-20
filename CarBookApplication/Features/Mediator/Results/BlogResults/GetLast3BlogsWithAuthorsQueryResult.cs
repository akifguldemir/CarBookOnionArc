using CarBookApplication.Features.Mediator.Queries.BlogQueries;
using CarbookDomain.Entities;
using MediatR;

namespace CarBookApplication.Features.Mediator.Results.BlogResults
{
    public class GetLast3BlogsWithAuthorsQuery : IRequest<List<GetLast3BlogsWithAuthorsQueryResult>>
    {
    }
}

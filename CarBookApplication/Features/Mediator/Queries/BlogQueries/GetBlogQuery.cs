using CarBookApplication.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBookApplication.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogQuery : IRequest<List<GetBlogQueryResult>>
    {
       
    }
}

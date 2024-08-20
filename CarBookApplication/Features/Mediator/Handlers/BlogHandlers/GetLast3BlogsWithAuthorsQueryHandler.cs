using CarBookApplication.Features.CQRS.Results.CarResults;
using CarBookApplication.Features.Mediator.Queries.BlogQueries;
using CarBookApplication.Features.Mediator.Results.BlogResults;
using CarBookApplication.Interfaces.BlogInterfaces;
using CarBookApplication.Interfaces.CarInterfaces;
using MediatR;

namespace CarBookApplication.Features.Mediator.Handlers.BlogHandlers
{
    public class GetLast3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResult>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetLast3BlogsWithAuthorsQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetLast3BlogsWithAuthorsQueryResult>> Handle(GetLast3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _blogRepository.GetLast3BlogsWithAuthors();
            return values.Select(x => new GetLast3BlogsWithAuthorsQueryResult
            {

                AuthorID = x.AuthorID,
                BlogID = x.BlogID,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
                CategoryID = x.CategoryID,
                AuthorName = x.Author.Name

            }).ToList();
        }
    }
}

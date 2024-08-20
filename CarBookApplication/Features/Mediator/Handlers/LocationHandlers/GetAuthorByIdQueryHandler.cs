using CarBookApplication.Features.Mediator.Queries.AuthorQueries;
using CarBookApplication.Features.Mediator.Results.AuthorResults;
using CarBookApplication.Interfaces;
using CarbookDomain.Entities;
using MediatR;

namespace CarBookApplication.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly IRepository<Author> _repository;

        public GetAuthorByIdQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetAuthorByIdQueryResult
            {
               Name = value.Name,
               AuthorID = value.AuthorID,
               Description = value.Description,
               ImageUrl = value.ImageUrl
            };
        }
    }
}

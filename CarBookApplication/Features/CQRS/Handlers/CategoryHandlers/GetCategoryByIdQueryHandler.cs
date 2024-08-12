using CarBookApplication.Features.CQRS.Queries.CategoryQeries;
using CarBookApplication.Features.CQRS.Results.CategoryResults;
using CarBookApplication.Interfaces;
using CarbookDomain.Entities;

namespace CarBookApplication.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryID = values.CategoryID,
                Name = values.Name
            };

        }
    }
}

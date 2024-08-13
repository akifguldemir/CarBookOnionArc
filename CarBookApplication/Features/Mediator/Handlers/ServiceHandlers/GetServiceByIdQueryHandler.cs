using CarBookApplication.Interfaces;
using CarbookDomain.Entities;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.ServiceQueries;
using UdemyCarBook.Application.Features.Mediator.Results.ServiceResults;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetPricingByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;
        public GetPricingByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                ServiceID = values.ServiceID,
                Description = values.Description,
                Title = values.Title,
                IconUrl = values.IconUrl
            };
        }
    }
}

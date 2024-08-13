using CarBookApplication.Interfaces;
using CarbookDomain.Entities;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using UdemyCarBook.Application.Features.Mediator.Results.SocialMediaResults;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
    {
        private readonly IRepository<SocialMedia> _repository;
        public GetServiceQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResult
            {
                Name = x.Name,
                SocialMediaID = x.SocialMediaID,
                Url = x.Url,
                Icon = x.Icon
            }).ToList();
        }
    }
}

using CarBookApplication.Interfaces;
using CarbookDomain.Entities;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.SocialMediaCommands;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class UpdatePricingCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;
        public UpdatePricingCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.SocialMediaID);
            values.Name = request.Name;
            values.Url = request.Url;
            values.SocialMediaID = request.SocialMediaID;
            values.Icon= request.Icon;
            await _repository.UpdateAsync(values);
        }
    }
}

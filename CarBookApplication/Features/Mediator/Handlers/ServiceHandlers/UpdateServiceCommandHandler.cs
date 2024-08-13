using CarBookApplication.Interfaces;
using CarbookDomain.Entities;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.ServiceCommands;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class UpdatePricingCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly IRepository<Service> _repository;
        public UpdatePricingCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ServiceID);
            values.Title = request.Title;
            values.Description = request.Description;
            values.IconUrl = request.IconUrl;
            await _repository.UpdateAsync(values);
        }
    }
}

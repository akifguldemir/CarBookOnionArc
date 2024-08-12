using CarBookApplication.Features.Mediator.Commands.FeatureCommands;
using CarBookApplication.Interfaces;
using CarbookDomain.Entities;
using MediatR;

namespace CarBookApplication.Features.Mediator.Handlers.FeatureHandlers
{
    public class RemoveFeatureCommandHandler : IRequestHandler<RemoveFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;

        public RemoveFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
        {
            var value =await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}

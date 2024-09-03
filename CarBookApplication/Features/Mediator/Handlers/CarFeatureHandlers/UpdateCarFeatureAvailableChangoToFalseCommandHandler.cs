using CarBookApplication.Features.Mediator.Commands.CarFeatureCommands;
using CarBookApplication.Interfaces.CarFeatureInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class UpdateCarFeatureAvailableChangoToFalseCommandHandler : IRequestHandler<UpdateCarFeatureAvailableChangoToFalseCommand>
    {
        private readonly ICarFeatureRepository _repository;
        public UpdateCarFeatureAvailableChangoToFalseCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }
        public Task Handle(UpdateCarFeatureAvailableChangoToFalseCommand request, CancellationToken cancellationToken)
        {
            _repository.ChangeCarFeatureAvailableToFalse(request.Id);
            return Task.CompletedTask;
        }
    }
}

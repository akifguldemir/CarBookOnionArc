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
    public class UpdateCarFeatureAvailableChangoToTrueCommandHandler : IRequestHandler<UpdateCarFeatureAvailableChangoToTrueCommand>
    {
        private readonly ICarFeatureRepository _repository;

        public UpdateCarFeatureAvailableChangoToTrueCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public Task Handle(UpdateCarFeatureAvailableChangoToTrueCommand request, CancellationToken cancellationToken)
        {
            _repository.ChangeCarFeatureAvailableToTrue(request.Id);
            return Task.CompletedTask;
        }
    }
}

using MediatR;

namespace CarBookApplication.Features.Mediator.Commands.FeatureCommands
{
    public class UpdateFeatureCommand : IRequest
    {
        public int FeatureID { get; set; }
        public string Name { get; set; }
    }
}

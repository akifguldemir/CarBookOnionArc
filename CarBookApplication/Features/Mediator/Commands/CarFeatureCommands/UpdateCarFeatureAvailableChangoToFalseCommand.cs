using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Commands.CarFeatureCommands
{
    public class UpdateCarFeatureAvailableChangoToFalseCommand :IRequest
    {
        public int Id { get; set; }

        public UpdateCarFeatureAvailableChangoToFalseCommand(int id)
        {
            Id = id;
        }
    }
}

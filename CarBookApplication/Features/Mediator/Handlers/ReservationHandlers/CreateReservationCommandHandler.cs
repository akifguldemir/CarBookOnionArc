﻿using CarBookApplication.Features.Mediator.Commands.ReservationCommands;
using CarBookApplication.Interfaces;
using CarbookDomain.Entities;
using MediatR;

namespace CarBookApplication.Features.Mediator.Handlers.ReservationHandlers
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand>
    {
        private readonly IRepository<Reservation> _repository;
        public CreateReservationCommandHandler(IRepository<Reservation> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Reservation
            {
                Age = request.Age,
                CarID = request.CarID,
                Description = request.Description,
                DriverLicenseYear = request.DriverLicenseYear,
                DropOffLocationID = request.DropOffLocationID,
                Email = request.Email,
                Name = request.Name,
                Phone = request.Phone,
                PickUpLocationID = request.PickUpLocationID,
                Surname = request.Surname,
                Status = "Rezervasyon Alındı"
            });
        }
    }
}

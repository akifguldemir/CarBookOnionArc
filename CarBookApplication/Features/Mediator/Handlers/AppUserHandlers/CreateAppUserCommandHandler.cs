﻿using CarBookApplication.Enums;
using CarBookApplication.Features.Mediator.Commands.AppUserCommands;
using CarBookApplication.Interfaces;
using CarbookDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Handlers.AppUserHandlers
{
	public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
	{
		private readonly IRepository<AppUser> _repository;

		public CreateAppUserCommandHandler(IRepository<AppUser> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new AppUser
			{
				Password = request.Password,
				Username = request.Username,
				AppRoleId = (int)RolesType.Member
			});
		}
	}
}

﻿using CarBookApplication.Features.Mediator.Commands.AuthorCommands;
using CarBookApplication.Interfaces;
using CarbookDomain.Entities;
using MediatR;

namespace CarBookApplication.Features.Mediator.Handlers.AuthorHandlers
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public CreateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Author {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
            });
        }
    }
}

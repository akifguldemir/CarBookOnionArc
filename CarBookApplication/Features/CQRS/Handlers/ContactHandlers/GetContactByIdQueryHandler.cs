﻿using CarBookApplication.Features.CQRS.Queries.ContactQueries;
using CarBookApplication.Features.CQRS.Results.ContactResults;
using CarBookApplication.Interfaces;
using CarbookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetContactByIdQueryResult
            {
                ContactID = values.ContactID,
                Name = values.Name,
                Email = values.Email,
                SendDate = values.SendDate,
                Message = values.Message,
                Subject = values.Subject
            };

        }
    }
}

using CarBookApplication.Features.Mediator.Results.AppUserResults;
using MediatR;

namespace CarBookApplication.Features.Mediator.Queries.AppUserQueries
{
	public class GetCheckAppUserQuery : IRequest<GetCheckAppUserQueryResult>
	{
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

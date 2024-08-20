using CarbookDomain.Entities;
using MediatR;

namespace CarBookApplication.Features.Mediator.Commands.LocationCommands
{
    public class CreateBlogCommand : IRequest
    {
        public string Title { get; set; }
        public string AuthorID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CategoryID { get; set; }
    }
}

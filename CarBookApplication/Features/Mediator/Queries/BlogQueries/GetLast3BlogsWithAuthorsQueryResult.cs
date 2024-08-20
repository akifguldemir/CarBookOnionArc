using CarbookDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Queries.BlogQueries
{
    public class GetLast3BlogsWithAuthorsQueryResult
    {

        public int BlogID { get; set; }
        public string Title { get; set; }
        public string AuthorID { get; set; }
        public string CategoryID { get; set; }
        public string AuthorName { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

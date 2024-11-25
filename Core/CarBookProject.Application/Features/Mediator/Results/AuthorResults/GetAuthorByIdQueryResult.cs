using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Results.AuthorResults
{
    public class GetAuthorByIdQueryResult
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}

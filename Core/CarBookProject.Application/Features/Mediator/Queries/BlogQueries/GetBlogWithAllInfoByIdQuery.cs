using CarBookProject.Application.Features.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogWithAllInfoByIdQuery
    {
        public int Id { get; set; }

        public GetBlogWithAllInfoByIdQuery(int id)
        {
            Id = id;
        }
    }
}

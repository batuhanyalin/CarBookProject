using CarBookProject.Application.Features.Mediator.Results.CommentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Queries.CommentQueries
{
    public class GetCommentByBlogIdQuery:IRequest<List<GetCommentByBlogIdQueryResult>>
    {
        public int Id { get; set; }

        public GetCommentByBlogIdQuery(int id)
        {
            Id = id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Results.TagBlogResults
{
    public class GetTagBlogByIdQueryResult
    {
        public int TagBlogId { get; set; }
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public int TagId { get; set; }
        public string TagName { get; set; }
    }
}
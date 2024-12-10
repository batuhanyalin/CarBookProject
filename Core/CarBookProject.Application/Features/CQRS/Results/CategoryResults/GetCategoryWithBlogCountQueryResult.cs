using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Results.CategoryResults
{
    public class GetCategoryWithBlogCountQueryResult
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int BlogCount { get; set; }
    }
}

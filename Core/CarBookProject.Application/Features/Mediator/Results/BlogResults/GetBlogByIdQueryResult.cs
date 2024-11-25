using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogByIdQueryResult
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int AuthorId { get; set; }
        public string CoverImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}

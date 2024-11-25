using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Dto.BlogDtos
{
    public class BlogUpdateDto
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Dto.TagBlogDtos
{
    public class TagBlogCreateDto
    {
        public int TagBlogId { get; set; }
        public int BlogId { get; set; }
        public int TagId { get; set; }
    }
}

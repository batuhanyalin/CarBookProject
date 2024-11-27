using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Dto.TagBlogDtos
{
    public class TagBlogListDto
    {

            public int tagBlogId { get; set; }
            public int blogId { get; set; }
            public object blogName { get; set; }
            public int tagId { get; set; }
            public string tagName { get; set; }

    }
}

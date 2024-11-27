using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Dto.CommentDtos
{
    public class CommentCreateDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BlogId { get; set; }
    }
}

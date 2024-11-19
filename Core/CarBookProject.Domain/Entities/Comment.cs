using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Domain.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string User { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}

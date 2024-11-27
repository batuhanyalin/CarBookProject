using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Interfaces.CommentInterfaces
{
    public interface ICommentRepository
    {
        public List<Comment> GetCommentListByBlogId(int id);
    }
}

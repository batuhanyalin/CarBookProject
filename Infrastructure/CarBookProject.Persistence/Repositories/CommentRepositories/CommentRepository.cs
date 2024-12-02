using CarBookProject.Application.Interfaces.CommentInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly CarBookContext _context;

        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Comment> GetCommentListByBlogId(int id)
        {
            var values = _context.Comments.Where(x => x.BlogId == id).Include(x => x.Blog).ThenInclude(x => x.Author).ToList();
            return values;
        }
        public List<Comment> GetCommentListWithAllInfo()
        {
            var values = _context.Comments.Include(x => x.Blog).ThenInclude(x => x.Author).ToList();
            return values;
        }
    }
}

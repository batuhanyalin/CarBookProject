using CarBookProject.Application.Interfaces.BlogInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _context;

        public BlogRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Blog> GetBlogLast3WithAllInfo()
        {
            var value= _context.Blogs.Include(x=>x.Category).Include(x=>x.Author).Include(x=>x.Comments).OrderByDescending(x=>x.BlogId).ToList();
            return value;
        }

        public List<Blog> GetBlogListWithAllInfo()
        {
            var values= _context.Blogs.Include(x=>x.Category).Include(x=>x.Author).Include(x => x.Comments).ToList();
            return values;
        }
        public Blog GetBlogWithAllInfoById(int id)
        {
            var value = _context.Blogs.Where(x=>x.BlogId==id).Include(x => x.Category).Include(x => x.Comments).Include(x => x.Author).FirstOrDefault();
            return value;
        }
    }
}

using CarBookProject.Application.Interfaces.TagBlogInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.TagBlogRepositories
{
    public class TagBlogRepository : ITagBlogRepository
    {
        private readonly CarBookContext _context;

        public TagBlogRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<TagBlog> GetTagBlogByBlogId(int id)
        {
            var values = _context.TagBlogs.Where(x => x.BlogId == id).Include(x => x.Blog).Include(x => x.Tag).ToList();
            return values;
        }
        public List<TagBlog> GetBlogListByTagId(int id)
        {
            var values = _context.TagBlogs.Where(x => x.Tag.TagId == id).Include(x => x.Blog).ThenInclude(x=>x.Author).Include(x => x.Tag).Include(x=>x.Blog).ThenInclude(x=>x.Category).ToList();
            return values;
        }
    }
}

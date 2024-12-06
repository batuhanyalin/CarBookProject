using CarBookProject.Application.Interfaces.AuthorInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.AuthorRepositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly CarBookContext _context;

        public AuthorRepository(CarBookContext context)
        {
            _context = context;
        }
        public List<Blog> GetBlogListByAuthorId(int id)
        {
            var values = _context.Blogs.Where(x => x.AuthorId == id).ToList();
            return values;
        }
    }
}

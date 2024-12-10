using CarBookProject.Application.Interfaces.CategoryInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.CategoryRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CarBookContext _context;

        public CategoryRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Category> GetCategoryListWithBlogCount()
        {
           var values= _context.Categories.Include(x=>x.Blogs).ToList();
            return values;
        }
    }
}

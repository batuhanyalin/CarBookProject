using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Interfaces.CategoryInterfaces
{
    public interface ICategoryRepository
    {
        public List<Category> GetCategoryListWithBlogCount();
    }
}

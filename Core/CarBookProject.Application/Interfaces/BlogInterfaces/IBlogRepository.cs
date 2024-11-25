
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        List<Blog> GetBlogListWithAllInfo();
        public Blog GetBlogWithAllInfoById(int id);
        List<Blog> GetBlogLast3WithAllInfo();
    }
}

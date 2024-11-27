using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Interfaces.TagBlogInterfaces
{
    public interface ITagBlogRepository
    {
        public List<TagBlog> GetTagBlogByBlogId(int id);
        public List<TagBlog> GetBlogListByTagId(int id);
    }
}

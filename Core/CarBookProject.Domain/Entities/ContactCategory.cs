using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Domain.Entities
{
    public class ContactCategory
    {
        public int ContactCategoryId { get; set; }
        public string Name { get; set; }
        public List<Contact>? Contacts { get; set; }
    }
}

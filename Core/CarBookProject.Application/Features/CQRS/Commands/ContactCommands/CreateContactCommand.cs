using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Commands.ContactCommands
{
    public class CreateContactCommand
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public DateTime SendingDate { get; set; }
        public int ContactCategoryId { get; set; }
        public bool IsApproved { get; set; }
    }
}

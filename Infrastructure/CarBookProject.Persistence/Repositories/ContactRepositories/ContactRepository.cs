using CarBookProject.Application.Interfaces.ContactInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.ContactRepositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly CarBookContext _context;

        public ContactRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Contact> GetContactListWithCategory()
        {
            var values = _context.Contacts.Include(x => x.ContactCategory).ToList();
            return values;
        }
    }
}

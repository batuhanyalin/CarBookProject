using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Interfaces.ContactInterfaces
{
    public interface IContactRepository
    {
        List<Contact> GetContactListWithCategory();
    }
}

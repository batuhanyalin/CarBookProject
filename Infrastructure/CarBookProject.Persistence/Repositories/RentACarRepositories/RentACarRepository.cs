using CarBookProject.Application.Interfaces.RentACarInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.RentACarRepositories
{
    public class RentACarRepository : IRentACarRepository
    {
        private readonly CarBookContext _context;

        public RentACarRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<RentACar> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
           var values= _context.RentACars.Where(filter); //Burada filtrerdan gelen şart sorgu olarak gönderiliyor.
            return values.ToList();
        }
    }
}

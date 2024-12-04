using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Interfaces.RentACarInterfaces
{
    public interface IRentACarRepository
    {
        List<RentACar> GetByFilterAsync(Expression<Func<RentACar, bool>> filter); //bool= geriye dönecek olan durumu belirtecek, filter= gönderilecek olan şart.
    }
}

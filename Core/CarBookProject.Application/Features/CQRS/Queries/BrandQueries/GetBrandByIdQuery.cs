using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Queries.BrandQueries
{
    public class GetBrandByIdQuery
    {
        public int Id { get; set; }

        public GetBrandByIdQuery(int id)
        {
            Id = id;
        }
    }
}

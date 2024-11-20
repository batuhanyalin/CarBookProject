using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Results.BrandResults
{
    public class GetBrandQueryResult
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
    }
}

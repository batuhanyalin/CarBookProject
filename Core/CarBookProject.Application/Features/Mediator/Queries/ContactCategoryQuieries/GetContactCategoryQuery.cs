using CarBookProject.Application.Features.Mediator.Results.ContactCategoryResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Queries.ContactCategoryQuieries
{
    public class GetContactCategoryQuery:IRequest<List<GetContactCategoryQueryResult>>
    {
    }
}

using CarBookProject.Application.Features.CQRS.Results.ContactResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Queries.ContactQueries
{
    public class GetContactWithCategoryQuery : IRequest<List<GetContactWithCategoryQueryResult>>
    {

    }
}

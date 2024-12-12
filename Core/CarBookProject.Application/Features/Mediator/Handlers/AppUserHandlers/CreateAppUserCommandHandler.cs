using CarBookProject.Application.Enums;
using CarBookProject.Application.Features.Mediator.Commands.AppUserCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
    {
        private readonly IRepository<AppUser> _appUserRepository;

        public CreateAppUserCommandHandler(IRepository<AppUser> appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            await _appUserRepository.CreateAsync(new AppUser
            {
                AppRoleId = (int)RolesType.Member, //Enum kullanımı
                Username =request.Username,
                Password=request.Password
             });

        }
    }
}

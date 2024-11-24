using CarBookProject.Application.Features.CQRS.Commands.BannerCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBannerCommand command)
        {
            var value = await _repository.GetByIdAsync(command.BannerId);
            value.VideoDescription = command.VideoDescription;
            value.Title = command.Title;
            value.VideoUrl = command.VideoUrl;
            value.Description = command.Description;
            value.ImageUrl = command.ImageUrl;
            await _repository.UpdateAsync(value);
        }
    }
}

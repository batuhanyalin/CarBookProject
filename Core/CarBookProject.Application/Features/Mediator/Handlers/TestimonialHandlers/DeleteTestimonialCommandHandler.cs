using CarBookProject.Application.Features.Mediator.Commands.TestimonialCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class DeleteTestimonialCommandHandler : IRequestHandler<DeleteTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;

        public DeleteTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteTestimonialCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}

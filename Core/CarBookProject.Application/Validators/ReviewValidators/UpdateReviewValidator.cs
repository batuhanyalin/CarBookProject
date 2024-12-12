using CarBookProject.Application.Features.Mediator.Commands.ReviewCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Validators.ReviewValidators
{
    public class UpdateReviewValidator:AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad bilgisi boş geçilemez.").MinimumLength(3).WithMessage("Ad bilgisi en az 3 karakter olmak zorundadır.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad bilgisi boş geçilemez.").MinimumLength(3).WithMessage("Ad bilgisi en az 3 karakter olmak zorundadır.");
            RuleFor(x => x.Text).NotEmpty().WithMessage("Yorum bilgisi boş geçilemez.").MinimumLength(50).WithMessage("Yorum bilgisi en az 50 karakter olmak zorundadır.").MaximumLength(500).WithMessage("Yorum bilgisi en fazla 500 karakter olabilir.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email bilgisi boş geçilemez.").EmailAddress().WithMessage("Doğru e-posta adresi formatı kullanın.");
        }
    }
}

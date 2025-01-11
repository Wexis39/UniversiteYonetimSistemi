using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Validators
{
    public class FakulteValidator:AbstractValidator<Fakulte>
    {
        public FakulteValidator()
        {
            RuleFor(x => x.FakulteAdi)
                .NotEmpty()
                .WithMessage("Fakülte adı boş olamaz.")
                .Length(3, 100)
                .WithMessage("Fakülte adı en az 3, en fazla 100 karakter olmalıdır.");
        }
    }
}

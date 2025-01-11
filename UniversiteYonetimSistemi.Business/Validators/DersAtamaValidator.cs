using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Validators
{
    public class DersAtamaValidator:AbstractValidator<DersAtama>
    {
        public DersAtamaValidator()
        {
            RuleFor(x => x.Ders)
                .NotEmpty()
                .WithMessage("Ders adı boş olamaz.");
        }
    }
}

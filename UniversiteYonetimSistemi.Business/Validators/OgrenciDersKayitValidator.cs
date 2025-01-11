using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Validators
{
    public class OgrenciDersKayitValidator:AbstractValidator<OgrenciDersKayit>
    {
        public OgrenciDersKayitValidator()
        {
            RuleFor(x => x.Not)
                .InclusiveBetween(0, 100)
                .WithMessage("Not 0 ile 100 arasında olmalıdır.");
        }
    }
}

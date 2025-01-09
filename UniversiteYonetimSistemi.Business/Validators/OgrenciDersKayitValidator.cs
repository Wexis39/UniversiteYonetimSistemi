using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Validators
{
    public class OgrenciDersKayitValidator:AbstractValidator<OgrenciDersKayitlari>
    {
        public OgrenciDersKayitValidator()
        {
            RuleFor(x => x.KayitID)
                .GreaterThan(0)
                .WithMessage("Kayıt ID sıfırdan büyük olmalıdır.");

            RuleFor(x => x.OgrenciID)
                .GreaterThan(0)
                .WithMessage("Öğrenci ID sıfırdan büyük olmalıdır.");

            RuleFor(x => x.DersID)
                .GreaterThan(0)
                .WithMessage("Ders ID sıfırdan büyük olmalıdır.");

            RuleFor(x => x.Not)
                .InclusiveBetween(0, 100)
                .WithMessage("Not 0 ile 100 arasında olmalıdır.");
        }
    }
}

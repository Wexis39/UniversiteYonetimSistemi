using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Validators
{
    public class DersAtamaValidator:AbstractValidator<DersAtamalari>
    {
        public DersAtamaValidator()
        {
            // AtamaID validasyonu (pozitif bir değer olmalı)
            RuleFor(x => x.AtamaID)
                .GreaterThan(0)
                .WithMessage("Atama ID sıfırdan büyük olmalıdır.");

            // DersID validasyonu (pozitif bir değer olmalı)
            RuleFor(x => x.DersID)
                .GreaterThan(0)
                .WithMessage("Ders ID sıfırdan büyük olmalıdır.");

            // OgretimGorevlisiID validasyonu (pozitif bir değer olmalı)
            RuleFor(x => x.OgretimGorevlisiID)
                .GreaterThan(0)
                .WithMessage("Öğretim Görevlisi ID sıfırdan büyük olmalıdır.");
        }
    }
}

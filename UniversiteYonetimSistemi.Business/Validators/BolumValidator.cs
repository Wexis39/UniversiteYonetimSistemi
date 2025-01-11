using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Validators
{
    public class BolumValidator:AbstractValidator<Bolum>
    {
        public BolumValidator()
        {
            // BolumAdi validasyonu (boş geçilemez ve uzunluğu sınırlandırılabilir)
            RuleFor(x => x.BolumAdi)
                .NotEmpty()
                .WithMessage("Bölüm adı boş olamaz.")
                .Length(3, 100)
                .WithMessage("Bölüm adı en az 3, en fazla 100 karakter olmalıdır.");
        }
    }
}

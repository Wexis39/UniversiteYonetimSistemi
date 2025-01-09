using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Validators
{
    public class DerslerValidator : AbstractValidator<Dersler>
    {
        public DerslerValidator()
        {
            // DersID sıfırdan büyük olmalı
            RuleFor(d => d.DersID)
                .GreaterThan(0)
                .WithMessage("Ders ID sıfırdan büyük olmalıdır.");

            // DersAdi boş olamaz, uzunluk sınırı 3-100 karakter
            RuleFor(d => d.DersAdi)
                .NotEmpty()
                .WithMessage("Ders Adı boş bırakılamaz.")
                .Length(3, 100)
                .WithMessage("Ders Adı en az 3, en fazla 100 karakter olmalıdır.");

            // Kredi en az 1, en fazla 10 (ihtiyaca göre değiştirin)
            RuleFor(d => d.Kredi)
                .InclusiveBetween(1, 10)
                .WithMessage("Kredi değeri 1 ile 10 arasında olmalıdır.");

            // BolumID sıfırdan büyük olmalı
            RuleFor(d => d.BolumID)
                .GreaterThan(0)
                .WithMessage("Bölüm ID sıfırdan büyük olmalıdır.");
        }
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Validators
{
    public class OgretimGorevlisiValidator:AbstractValidator<OgretimGorevlisi>
    {
        public OgretimGorevlisiValidator()
        {
            // OgretimGorevlisiID validasyonu
            RuleFor(x => x.OgretimGorevlisiID)
                .GreaterThan(0)
                .WithMessage("Öğretim Görevlisi ID sıfırdan büyük olmalıdır.");

            // Ad validasyonu
            RuleFor(x => x.Ad)
                .NotEmpty()
                .WithMessage("Ad boş olamaz.")
                .Length(2, 50)
                .WithMessage("Ad en az 2, en fazla 50 karakter olmalıdır.");

            // Soyad validasyonu
            RuleFor(x => x.Soyad)
                .NotEmpty()
                .WithMessage("Soyad boş olamaz.")
                .Length(2, 50)
                .WithMessage("Soyad en az 2, en fazla 50 karakter olmalıdır.");

            // Eposta validasyonu
            RuleFor(x => x.Eposta)
                .NotEmpty()
                .WithMessage("E-posta adresi boş olamaz.")
                .EmailAddress()
                .WithMessage("Geçerli bir e-posta adresi olmalıdır.");

            // Telefon validasyonu
            RuleFor(x => x.Telefon)
                .NotEmpty()
                .WithMessage("Telefon numarası boş olamaz.")
                .Matches(@"^\d{10}$")
                .WithMessage("Telefon numarası tam 10 rakamdan oluşmalıdır.");

            // BolumID validasyonu
            RuleFor(x => x.BolumID)
                .GreaterThan(0)
                .WithMessage("Bölüm ID sıfırdan büyük olmalıdır.");
        }
    }
}

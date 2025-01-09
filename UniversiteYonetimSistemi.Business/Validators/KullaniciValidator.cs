using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Validators
{
    public class KullaniciValidator:AbstractValidator<Kullanicilar>
    {
        public KullaniciValidator()
        {
            RuleFor(x => x.KullaniciID)
                .GreaterThan(0)
                .WithMessage("Kullanıcı ID sıfırdan büyük olmalıdır.");

            RuleFor(x => x.KullaniciAdi)
                .NotEmpty()
                .WithMessage("Kullanıcı adı boş olamaz.")
                .Length(3, 50)
                .WithMessage("Kullanıcı adı en az 3, en fazla 50 karakter olmalıdır.");

            RuleFor(x => x.Sifre)
                .NotEmpty()
                .WithMessage("Şifre boş olamaz.")
                .Length(6, 20)
                .WithMessage("Şifre en az 6, en fazla 20 karakter olmalıdır.");

            RuleFor(x => x.Rol)
                .NotEmpty()
                .WithMessage("Rol boş olamaz.");
        }
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Validators
{
    public class OgrenciValidator:AbstractValidator<Ogrenci>
    {
        public OgrenciValidator()
        {
            RuleFor(x => x.Ad)
                .NotEmpty()
                .WithMessage("Öğrenci adı boş olamaz.")
                .Length(2, 50)
                .WithMessage("Öğrenci adı en az 2, en fazla 50 karakter olmalıdır.");

            RuleFor(x => x.Soyad)
                .NotEmpty()
                .WithMessage("Öğrenci soyadı boş olamaz.")
                .Length(2, 50)
                .WithMessage("Öğrenci soyadı en az 2, en fazla 50 karakter olmalıdır.");

            RuleFor(x => x.TCNo)
                .NotEmpty()
                .WithMessage("TC No boş olamaz.")
                .Matches(@"^\d{11}$")
                .WithMessage("TC No tam 11 rakamdan oluşmalıdır.");

            RuleFor(x => x.DogumTarihi)
                .LessThan(DateTime.Now)
                .WithMessage("Doğum tarihi bugünden önce olmalıdır.")
                .GreaterThan(DateTime.Now.AddYears(-120))
                .WithMessage("Doğum tarihi 120 yıldan eski olamaz.");

            RuleFor(x => x.Eposta)
                .NotEmpty()
                .WithMessage("E-posta adresi boş olamaz.")
                .EmailAddress()
                .WithMessage("Geçerli bir e-posta adresi olmalıdır.");

            RuleFor(x => x.Telefon)
                .NotEmpty()
                .WithMessage("Telefon numarası boş olamaz.")
                .Matches(@"^\d{10}$")
                .WithMessage("Telefon numarası tam 10 rakamdan oluşmalıdır.");

            RuleFor(x => x.Adres)
                .NotEmpty()
                .WithMessage("Adres boş olamaz.")
                .Length(5, 200)
                .WithMessage("Adres en az 5, en fazla 200 karakter olmalıdır.");
        }
    }
}

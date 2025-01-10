using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Business.Validators;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Services
{
    public class DersService
    {
        public class DersService:IServiceProvider
        {
            private readonly DerslerRepository _derslerRepository;

            // Repository bağımlılığını constructor'da alıyoruz (Dependency Injection)
            public DersService(DersRepository dersRepository)
            {
                _dersRepository = dersRepository;
            }

            // Tüm Dersler verilerini döndür
            public IEnumerable<Ders> GetAllDers()
            {
                return _derslerRepository.GetAll();
            }

            // ID'ye göre tek bir Ders kaydını getir
            public Ders GetDersById(int id)
            {
                return _derslerRepository.GetByID(id);
            }

            // Yeni bir Ders ekle
            public void AddDers(Ders ders)
            {
                // 1) FluentValidation ile doğrulama
                var validator = new DerslerValidator();
                ValidationResult result = validator.Validate(ders);

                if (!result.IsValid)
                {
                    // Doğrulama başarısızsa, ValidationException fırlatarak işlemi durdur
                    throw new ValidationException(result.Errors);
                }

                // 2) Doğrulama başarılı ise repository üzerinden veritabanına ekle
                _dersRepository.Add(ders);
            }

            // Var olan bir Ders kaydını güncelle
            public void UpdateDers(Ders ders)
            {
                // İstersen burada da validator çalıştırabilirsin
                _dersRepository.Update(ders);
            }

            // Ders kaydını sil
            public void DeleteDers(int id)
            {
                _dersRepository.Delete(id);
            }

            // Aynı Ders adı var mı yok mu kontrol
            // (Örnek bir metod; eğer ders adının varlığını sorgulamak istiyorsan)
            public bool IfEntityExists(string dersAdi)
            {
                return _dersRepository.IfEntityExists(d => d.DersAdi == dersAdi);
            }
        }
    }
}

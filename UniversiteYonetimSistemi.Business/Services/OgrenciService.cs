using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Business.Validators;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Services
{
    public class OgrenciService
    {
        private readonly OgrenciRepository _ogrenciRepository;

        public OgrenciService(OgrenciRepository ogrenciRepository)
        {
            _ogrenciRepository = ogrenciRepository;
        }

        // Tüm öğrencileri getir
        public IEnumerable<Ogrenci> GetAllOgrenciler()
        {
            return _ogrenciRepository.GetAll();
        }

        // Id ile tek öğrenci getir
        public Ogrenci GetOgrenciById(int id)
        {
            return _ogrenciRepository.GetByID(id);
        }

        // Yeni öğrenci ekle
        public void AddOgrenci(Ogrenci ogrenci)
        {
            // Validasyon
            var validator = new OgrenciValidator();
            ValidationResult result = validator.Validate(ogrenci);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _ogrenciRepository.Add(ogrenci);
        }

        // Öğrenci güncelle
        public void UpdateOgrenci(Ogrenci ogrenci)
        {
            // Dilersen validasyon tekrar yapabilirsin
            _ogrenciRepository.Update(ogrenci);
        }

        // Öğrenci sil
        public void DeleteOgrenci(int id)
        {
            _ogrenciRepository.Delete(id);
        }

        // Belirli bir koşulla öğrenci var mı?
        // Örneğin TCNo veya Eposta bazlı kontrol
        public bool IfEntityExists(string tcNo)
        {
            return _ogrenciRepository.IfEntityExists(o => o.TCNo == tcNo);
        }

    }
}

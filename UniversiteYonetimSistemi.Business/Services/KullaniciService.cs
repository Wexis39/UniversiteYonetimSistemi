using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Business.Abstractions;
using UniversiteYonetimSistemi.Business.Validators;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Services
{
    public class KullaniciService
    {
        private readonly KullaniciRepository _kullaniciRepository;

        public KullaniciService(KullaniciRepository kullaniciRepository)
        {
            _kullanicilarRepository = kullaniciRepository;
        }

        public IEnumerable<Kullanici> GetAllKullanicilar()
        {
            return _kullaniciRepository.GetAll();
        }

        public Kullanici GetKullaniciById(int id)
        {
            return _kullaniciRepository.GetByID(id);
        }

        public void AddKullanici(Kullanici kullanici)
        {
            var validator = new KullaniciValidator();
            var result = validator.Validate(kullanici);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _kullaniciRepository.Add(kullanici);
        }

        public void UpdateKullanici(Kullanici kullanici)
        {
            _kullaniciRepository.Update(kullanici);
        }

        public void DeleteKullanici(int id)
        {
            _kullaniciRepository.Delete(id);
        }

        // Örneğin kullanıcı adı var mı?
        public bool IfEntityExists(string kullaniciAdi)
        {
            return _kullaniciRepository.IfEntityExists(u => u.KullaniciAdi == kullaniciAdi);
        }
    }
}

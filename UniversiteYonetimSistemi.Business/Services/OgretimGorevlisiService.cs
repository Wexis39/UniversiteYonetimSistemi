using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Business.Validators;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Services
{
    public class OgretimGorevlisiService
    {
        private readonly OgretimGorevlisiRepository _ogretimGorevlisiRepository;

        public OgretimGorevlisiService(OgretimGorevlisiRepository ogretimGorevlisiRepository)
        {
            _ogretimGorevlisiRepository = ogretimGorevlisiRepository;
        }

        public IEnumerable<OgretimGorevlisi> GetAllOgretimGorevlisi()
        {
            return _ogretimGorevlisiRepository.GetAll();
        }

        public OgretimGorevlisi GetOgretimGorevlisiById(int id)
        {
            return _ogretimGorevlisiRepository.GetByID(id);
        }

        public void AddOgretimGorevlisi(OgretimGorevlisi ogretimGorevlisi)
        {
            var validator = new OgretimGorevlisiValidator();
            var result = validator.Validate(ogretimGorevlisi);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _ogretimGorevlisiRepository.Add(ogretimGorevlisi);
        }

        public void UpdateOgretimGorevlisi(OgretimGorevlisi ogretimGorevlisi)
        {
            _ogretimGorevlisiRepository.Update(ogretimGorevlisi);
        }

        public void DeleteOgretimGorevlisi(int id)
        {
            _ogretimGorevlisiRepository.Delete(id);
        }

        // Belirli bir adı-soyadı olan öğretim görevlisi var mı?
        public bool IfEntityExists(string ad, string soyad)
        {
            return _ogretimGorevlisiRepository.IfEntityExists(g => g.Ad == ad && g.Soyad == soyad);
        }
    }
}

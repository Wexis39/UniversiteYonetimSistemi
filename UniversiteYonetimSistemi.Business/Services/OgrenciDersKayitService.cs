using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Business.Validators;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Services
{
    public class OgrenciDersKayitService
    {
        private readonly OgrenciDersKayitRepository _ogrenciDersKayitRepository;

        public OgrenciDersKayitService(OgrenciDersKayitRepository ogrenciDersKayitRepository)
        {
            _ogrenciDersKayitRepository = ogrenciDersKayitRepository;
        }

        public IEnumerable<OgrenciDersKayit> GetAllKayitlar()
        {
            return _ogrenciDersKayitRepository.GetAll();
        }

        public OgrenciDersKayit GetKayitById(int id)
        {
            return _ogrenciDersKayitRepository.GetByID(id);
        }

        public void AddKayit(OgrenciDersKayit kayit)
        {
            var validator = new OgrenciDersKayitValidator();
            var result = validator.Validate(kayit);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _ogrenciDersKayitRepository.Add(kayit);
        }

        public void UpdateKayit(OgrenciDersKayit kayit)
        {
            _ogrenciDersKayitRepository.Update(kayit);
        }

        public void DeleteKayit(int id)
        {
            _ogrenciDersKayitRepository.Delete(id);
        }

        public bool IfEntityExists(int ogrenciId, int dersId)
        {
            return _ogrenciDersKayitRepository.IfEntityExists(k => k.OgrenciID == ogrenciId && k.DersID == dersId);
        }
    }
}

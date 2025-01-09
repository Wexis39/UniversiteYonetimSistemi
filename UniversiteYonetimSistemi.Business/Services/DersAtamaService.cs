using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Business.Validators;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Services
{
    public class DersAtamaService
    {
        private readonly DersAtamaRepository _dersAtamaRepository;

        public DersAtamalariService(DersAtamaRepository dersAtamaRepository)
        {
            _dersAtamaRepository = dersAtamaRepository;
        }

        public IEnumerable<DersAtamalari> GetAllDersAtamalari()
        {
            return _dersAtamaRepository.GetAll();
        }

        public DersAtamalari GetDersAtamalariById(int id)
        {
            return _dersAtamaRepository.GetByID(id);
        }

        public void AddDersAtamasi(DersAtamalari dersAtama)
        {
            var validator = new DersAtamaValidator();
            var result = validator.Validate(dersAtama);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _dersAtamaRepository.Add(dersAtama);
        }

        public void UpdateDersAtamasi(DersAtamalari dersAtama)
        {
            _dersAtamaRepository.Update(dersAtama);
        }

        public void DeleteDersAtamasi(int id)
        {
            _dersAtamaRepository.Delete(id);
        }

        public bool IfEntityExists(int dersId, int ogretimGorevlisiId)
        {
            return _dersAtamaRepository.IfEntityExists(a => a.DersID == dersId && a.OgretimGorevlisiID == ogretimGorevlisiId);
        }
    }
}

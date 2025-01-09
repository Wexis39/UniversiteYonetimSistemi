using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Business.Validators;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Services
{
    public class BolumService
    {
        private readonly BolumRepository _bolumRepository;

        public BolumService(BolumRepository bolumRepository)
        {
            _bolumRepository = bolumRepository;
        }

        public IEnumerable<Bolumler> GetAllBolumler()
        {
            return _bolumRepository.GetAll();
        }

        public Bolumler GetBolumById(int id)
        {
            return _bolumRepository.GetByID(id);
        }

        public void AddBolum(Bolumler bolum)
        {
            var validator = new BolumValidator();
            var result = validator.Validate(bolum);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _bolumRepository.Add(bolum);
        }

        public void UpdateBolum(Bolumler bolum)
        {
            _bolumRepository.Update(bolum);
        }

        public void DeleteBolum(int id)
        {
            _bolumRepository.Delete(id);
        }

        // Aynı isimde bolum var mı?
        public bool IfEntityExists(string bolumAdi)
        {
            return _bolumRepository.IfEntityExists(b => b.BolumAdi == bolumAdi);
        }
    }
}

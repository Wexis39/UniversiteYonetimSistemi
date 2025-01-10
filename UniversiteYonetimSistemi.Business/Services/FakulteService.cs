using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Business.Validators;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Services
{
    public class Fakulte
    {
        private readonly FakulteRepository _fakulteRepository;

        public FakulteService(FakulteRepository fakulteRepository)
        {
            _fakulteRepository = fakulteRepository;
        }

        public IEnumerable<Entities.Models.Fakulte> GetAllFakulteler()
        {
            return _fakulteRepository.GetAll();
        }

        public Entities.Models.Fakulte GetFakulteById(int id)
        {
            return _fakulteRepository.GetByID(id);
        }

        public void AddFakulte(Entities.Models.Fakulte fakulte)
        {
            var validator = new FakulteValidator();
            var result = validator.Validate(fakulte);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _fakulteRepository.Add(fakulte);
        }

        public void UpdateFakulte(Entities.Models.Fakulte fakulte)
        {
            _fakulteRepository.Update(fakulte);
        }

        public void DeleteFakulte(int id)
        {
            _fakulteRepository.Delete(id);
        }

        // Aynı Fakülte adına sahip kayıt var mı?
        public bool IfEntityExists(string fakulteAdi)
        {
            return _fakulteRepository.IfEntityExists(f => f.FakulteAdi == fakulteAdi);
        }
    }
}

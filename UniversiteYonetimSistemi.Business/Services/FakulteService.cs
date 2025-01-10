using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Business.Abstractions;
using UniversiteYonetimSistemi.Business.Validators;
using UniversiteYonetimSistemi.DAL.Repositories;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Services
{
    public class Fakulte: IService<Fakulte>
    {
        private readonly FakulteRepository _fakulteRepository;

        public FakulteService(FakulteRepository fakulteRepository)
        {
            _fakulteRepository = fakulteRepository;
        }

        public void Add(Fakulte entity)
        {
            _fakulteRepository.Add(entity);
        }

        public void Update(Fakulte entity)
        {
            _fakulteRepository.Update(entity);
        }

        public void Delete(Guid id)
        {
            _fakulteRepository.Delete(id);
        }

        public Fakulte GetById(Guid id)
        {
            return _fakulteRepository.GetByID(id);
        }

        public IEnumerable<Fakulte> GetAll()
        {
            return _fakulteRepository.GetAll();
        }

        public bool IfEntityExists(Expression<Func<Fakulte, bool>> filter)
        {
            return _fakulteRepository.IfEntityExists(filter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Business.Validators;
using UniversiteYonetimSistemi.DAL.Repositories;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Services
{
        public class DersAtamaService : IService<DersAtama>
        {
            private readonly DersAtamaRepository _dersAtamaRepository;

            public DersAtamaService(DersAtamaRepository dersAtamaRepository)
            {
                _dersAtamaRepository = dersAtamaRepository;
            }

            public void Add(DersAtama entity)
            {
                _dersAtamaRepository.Add(entity);
            }

            public void Update(DersAtama entity)
            {
                _dersAtamaRepository.Update(entity);
            }

            public void Delete(Guid id)
            {
                _dersAtamaRepository.Delete(id);
            }

            public DersAtama GetById(Guid id)
            {
                return _dersAtamaRepository.GetByID(id);
            }

            public IEnumerable<DersAtama> GetAll()
            {
                return _dersAtamaRepository.GetAll();
            }

            public bool IfEntityExists(Expression<Func<DersAtama, bool>> filter)
            {
                return _dersAtamaRepository.IfEntityExists(filter);
            }
        }
}

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
        public class OgrenciService: IService<Ogrenci>
        {
            private readonly OgrenciRepository _ogrenciRepository;

            public OgrenciService(OgrenciRepository ogrenciRepository)
            {
                _ogrenciRepository = ogrenciRepository;
            }

            public void Add(Ogrenci entity)
            {
                _ogrenciRepository.Add(entity);
            }

            public void Update(Ogrenci entity)
            {
                _ogrenciRepository.Update(entity);
            }

            public void Delete(Guid id)
            {
                _ogrenciRepository.Delete(id);
            }

            public Ogrenci GetById(Guid id)
            {
                return _ogrenciRepository.GetByID(id);
            }

            public IEnumerable<Ogrenci> GetAll()
            {
                return _ogrenciRepository.GetAll();
            }

            public bool IfEntityExists(Expression<Func<Ogrenci, bool>> filter)
            {
                return _ogrenciRepository.IfEntityExists(filter);
            }

        }
}

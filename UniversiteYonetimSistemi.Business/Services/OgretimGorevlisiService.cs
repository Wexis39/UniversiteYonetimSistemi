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
    public class OgretimGorevlisiService:IService<OgretimGorevlisi>
    {
        private readonly OgretimGorevlisiRepository _ogretimGorevlisiRepository;

        public OgretimGorevlisiService(OgretimGorevlisiRepository ogretimGorevlisiRepository)
        {
            _ogretimGorevlisiRepository = ogretimGorevlisiRepository;
        }

        public void Add(OgretimGorevlisi entity)
        {
            _ogretimGorevlisiRepository.Add(entity);
        }

        public void Update(OgretimGorevlisi entity)
        {
            _ogretimGorevlisiRepository.Update(entity);
        }

        public void Delete(Guid id)
        {
            _ogretimGorevlisiRepository.Delete(id);
        }

        public OgretimGorevlisi GetById(Guid id)
        {
            return _ogretimGorevlisiRepository.GetByID(id);
        }

        public IEnumerable<OgretimGorevlisi> GetAll()
        {
            return _ogretimGorevlisiRepository.GetAll();
        }

        public bool IfEntityExists(Expression<Func<OgretimGorevlisi, bool>> filter)
        {
            return _ogretimGorevlisiRepository.IfEntityExists(filter);
        }
    }
}

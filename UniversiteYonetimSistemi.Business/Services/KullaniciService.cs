using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Business.Abstractions;
using UniversiteYonetimSistemi.Business.Validators;
using UniversiteYonetimSistemi.DAL.Repositories;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.Business.Services
{
    public class KullaniciService: IService<Kullanici>
    {
        private readonly KullaniciRepository _kullaniciRepository;

        public KullaniciService(KullaniciRepository kullaniciRepository)
        {
            _kullaniciRepository = kullaniciRepository;
        }

        public void Add(Kullanici entity)
        {
            _kullaniciRepository.Add(entity);
        }

        public void Update(Kullanici entity)
        {
            _kullaniciRepository.Update(entity);
        }

        public void Delete(Guid id)
        {
            _kullaniciRepository.Delete(id);
        }

        public Kullanici GetById(Guid id)
        {
            return _kullaniciRepository.GetByID(id);
        }

        public IEnumerable<Kullanici> GetAll()
        {
            return _kullaniciRepository.GetAll();
        }

        public bool IfEntityExists(Expression<Func<Kullanici, bool>> filter)
        {
            return _kullaniciRepository.IfEntityExists(filter);
        }
    }
}

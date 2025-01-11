using FluentValidation;
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
            KullaniciValidator validator = new KullaniciValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => throw new Exception(x.ErrorMessage));
            }
            _kullaniciRepository.Add(entity);
        }

        public void Update(Kullanici entity)
        {
            KullaniciValidator validator = new KullaniciValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => throw new Exception(x.ErrorMessage));
            }

            _kullaniciRepository.Update(entity);
        }

        public void Delete(Guid id)
        {
            _kullaniciRepository.Delete(id);
        }

        public Kullanici GetById(Guid id)
        {
            return _kullaniciRepository.GetById(id);
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

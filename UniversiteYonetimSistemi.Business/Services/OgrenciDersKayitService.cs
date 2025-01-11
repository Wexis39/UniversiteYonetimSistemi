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
    public class OgrenciDersKayitService : IService<OgrenciDersKayit>
    {
        private readonly OgrenciDersKayitRepository _ogrenciDersKayitRepository;

        public OgrenciDersKayitService(OgrenciDersKayitRepository ogrenciDersKayitRepository)
        {
            _ogrenciDersKayitRepository = ogrenciDersKayitRepository;
        }

        public void Add(OgrenciDersKayit entity)
        {
            OgrenciDersKayitValidator validator = new OgrenciDersKayitValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => throw new Exception(x.ErrorMessage));
            }
            _ogrenciDersKayitRepository.Add(entity);
        }

        public void Update(OgrenciDersKayit entity)
        {
            OgrenciDersKayitValidator validator = new OgrenciDersKayitValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => throw new Exception(x.ErrorMessage));
            }

            _ogrenciDersKayitRepository.Update(entity);
        }

        public void Delete(Guid id)
        {
            _ogrenciDersKayitRepository.Delete(id);
        }

        public OgrenciDersKayit GetById(Guid id)
        {
            return _ogrenciDersKayitRepository.GetById(id);
        }

        public IEnumerable<OgrenciDersKayit> GetAll()
        {
            return _ogrenciDersKayitRepository.GetAll();
        }

        public bool IfEntityExists(Expression<Func<OgrenciDersKayit, bool>> filter)
        {
            return _ogrenciDersKayitRepository.IfEntityExists(filter);
        }
    }
}

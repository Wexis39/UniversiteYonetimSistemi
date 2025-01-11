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
    public class DersAtamaService : IService<DersAtama>
    {
        private readonly DersAtamaRepository _dersAtamaRepository;

        public DersAtamaService(DersAtamaRepository dersAtamaRepository)
        {
            _dersAtamaRepository = dersAtamaRepository;
        }

        public void Add(DersAtama entity)
        {
            DersAtamaValidator validator = new DersAtamaValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => throw new Exception(x.ErrorMessage));
            }
            _dersAtamaRepository.Add(entity);
        }

        public void Update(DersAtama entity)
        {
            DersAtamaValidator validator = new DersAtamaValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => throw new Exception(x.ErrorMessage));
            }

            _dersAtamaRepository.Update(entity);
        }

        public void Delete(Guid id)
        {
            _dersAtamaRepository.Delete(id);
        }

        public DersAtama GetById(Guid id)
        {
            return _dersAtamaRepository.GetById(id);
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

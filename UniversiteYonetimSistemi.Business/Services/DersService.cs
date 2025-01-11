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
    public class DersService : IService<Ders>
    {
        private readonly DersRepository _dersRepository;

        public DersService(DersRepository dersRepository)
        {
            _dersRepository = dersRepository;
        }

        public void Add(Ders entity)
        {
            DersValidator validator = new DersValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => throw new Exception(x.ErrorMessage));
            }
            _dersRepository.Add(entity);
        }

        public void Update(Ders entity)
        {
            DersValidator validator = new DersValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => throw new Exception(x.ErrorMessage));
            }

            _dersRepository.Update(entity);
        }

        public void Delete(Guid id)
        {
            _dersRepository.Delete(id);
        }

        public Ders GetById(Guid id)
        {
            return _dersRepository.GetById(id);
        }

        public IEnumerable<Ders> GetAll()
        {
            return _dersRepository.GetAll();
        }

        public bool IfEntityExists(Expression<Func<Ders, bool>> filter)
        {
            return _dersRepository.IfEntityExists(filter);
        }
    }

}

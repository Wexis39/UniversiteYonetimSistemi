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
    public class FakulteService: IService<Fakulte>
    {
        private readonly FakulteRepository _fakulteRepository;

        public FakulteService(FakulteRepository fakulteRepository)
        {
            _fakulteRepository = fakulteRepository;
        }

        public void Add(Fakulte entity)
        {
            FakulteValidator validator = new FakulteValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => throw new Exception(x.ErrorMessage));
            }
            _fakulteRepository.Add(entity);
        }

        public void Update(Fakulte entity)
        {
            FakulteValidator validator = new FakulteValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => throw new Exception(x.ErrorMessage));
            }

            _fakulteRepository.Update(entity);
        }

        public void Delete(Guid id)
        {
            _fakulteRepository.Delete(id);
        }

        public Fakulte GetById(Guid id)
        {
            return _fakulteRepository.GetById(id);
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

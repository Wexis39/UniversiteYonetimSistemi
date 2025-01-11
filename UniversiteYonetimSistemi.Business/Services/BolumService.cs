using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public class BolumService : IService<Bolum>
    {
        private readonly BolumRepository _bolumRepository;

        public BolumService(BolumRepository bolumRepository)
        {
            _bolumRepository = bolumRepository;
        }

        public void Add(Bolum entity)
        {
            BolumValidator validator = new BolumValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => throw new Exception(x.ErrorMessage));
            }

            _bolumRepository.Add(entity);
        }

        public void Update(Bolum entity)
        {
            BolumValidator validator = new BolumValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => throw new Exception(x.ErrorMessage));
            }

            _bolumRepository.Update(entity);
        }

        public void Delete(Guid id)
        {
            _bolumRepository.Delete(id);
        }

        public Bolum GetById(Guid id)
        {
            return _bolumRepository.GetById(id);
        }

        public IEnumerable<Bolum> GetAll()
        {
            return _bolumRepository.GetAll();
        }

        public bool IfEntityExists(Expression<Func<Bolum, bool>> filter)
        {
            return _bolumRepository.IfEntityExists(filter);
        }
    }
}

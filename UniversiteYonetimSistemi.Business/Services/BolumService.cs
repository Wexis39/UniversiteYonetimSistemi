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
    public class BolumService:IService<Bolum>
    {
        public class BolumService : IService<Bolumler>
        {
            private readonly BolumRepository _bolumRepository;

            public BolumService(BolumRepository bolumRepository)
            {
                _bolumRepository = bolumRepository;
            }

            public void Add(Bolumler entity)
            {
                var validator = new BolumValidator();
                var result = validator.Validate(entity);

                if (!result.IsValid)
                {
                    throw new ValidationException(result.Errors);
                }

                _bolumRepository.Add(entity);
            }

            public void Update(Bolumler entity)
            {
                _bolumRepository.Update(entity);
            }

            public void Delete(Guid id)
            {
                _bolumRepository.Delete(id);
            }

            public Bolumler GetById(Guid id)
            {
                return _bolumRepository.GetByID(id);
            }

            public IEnumerable<Bolumler> GetAll()
            {
                return _bolumRepository.GetAll();
            }

            public bool IfEntityExists(Expression<Func<Bolumler, bool>> filter)
            {
                return _bolumRepository.IfEntityExists(filter);
            }
        }

    }
}

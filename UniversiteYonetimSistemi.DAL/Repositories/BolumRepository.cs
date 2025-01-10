using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.DAL.Context;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.DAL.Repositories
{
    public class BolumRepository : GenericRepository<Bolum>
    {
        public BolumRepository(UniversiteDbContext universiteDbContext) : base(universiteDbContext)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.DAL.Context;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.DAL.Repositories
{
    public class DersRepository : GenericRepository<Ders>
    {
        public DersRepository(UniversiteDbContext universiteDbContext) : base(universiteDbContext)
        {
        }
    }
}

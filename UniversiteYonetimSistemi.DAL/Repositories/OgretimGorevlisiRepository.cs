using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.DAL.Context;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.DAL.Repositories
{
    public class OgretimGorevlisiRepository : GenericRepository<OgretimGorevlisi>
    {
        public OgretimGorevlisiRepository(UniversiteDbContext universiteDbContext) : base(universiteDbContext)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteYonetimSistemi.Entities.Abstractions
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.CORE.Entities
{
    public interface IBaseEntity
    {
        long ID { get; set; }
        DateTime OlusturulmaTarihi { get; set; }
    }
}

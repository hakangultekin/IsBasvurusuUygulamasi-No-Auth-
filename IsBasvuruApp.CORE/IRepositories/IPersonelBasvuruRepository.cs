using IsBasvuruApp.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.CORE.IRepositories
{
    public interface IPersonelBasvuruRepository : IBaseRepository<PersonelBasvuru>
    {
        Task<List<PersonelBasvuru>> GetAllByPersonelIdIncludesIller(long personelId);
    }
}

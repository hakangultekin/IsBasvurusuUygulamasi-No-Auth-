using IsBasvuruApp.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.BLL.Services.IlceService
{
    public interface IILceService
    {
        Task<Ilce> GetById(long id);
        Task<List<Ilce>> GetAllBySehir(long sehirId);
    }
}

using IsBasvuruApp.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.BLL.Services.ILService
{
    public interface IILService
    {
        Task<List<Il>> GetAll();
        Task<Il> GetById(long Id);
    }
}

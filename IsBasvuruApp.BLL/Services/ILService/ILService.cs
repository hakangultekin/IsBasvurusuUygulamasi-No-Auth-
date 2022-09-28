using IsBasvuruApp.CORE.Entities;
using IsBasvuruApp.CORE.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.BLL.Services.ILService
{
    public class ILService : IILService
    {
        private readonly IIlRepository ilRepository;

        public ILService(IIlRepository ilRepository)
        {
            this.ilRepository = ilRepository;
        }

        public async Task<List<Il>> GetAll()
        {
            return await ilRepository.GetAll();
        }

        public async Task<Il> GetById(long Id)
        {
            return await ilRepository.GetWhere(a => a.ID == Id);
        }
    }
}

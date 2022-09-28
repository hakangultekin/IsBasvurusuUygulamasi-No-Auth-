using IsBasvuruApp.CORE.Entities;
using IsBasvuruApp.CORE.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.BLL.Services.IlceService
{
    public class ILceService : IILceService
    {
        private readonly IIlceRepository ilceRepository;

        public ILceService(IIlceRepository ilceRepository)
        {
            this.ilceRepository = ilceRepository;
        }

        public async Task<List<Ilce>> GetAllBySehir(long sehirId)
        {
            return await ilceRepository.GetAllWhere(x => x.IlID == sehirId);
        }

        public async Task<Ilce> GetById(long id)
        {
            return await ilceRepository.GetWhere(x => x.ID == id);
        }
    }
}

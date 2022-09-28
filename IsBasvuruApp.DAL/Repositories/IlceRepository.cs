using IsBasvuruApp.CORE.Entities;
using IsBasvuruApp.CORE.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.DAL.Repositories
{
    public class IlceRepository : BaseRepository<Ilce>, IIlceRepository
    {
        public IlceRepository(AppDbContext db) : base(db)
        {

        }
    }
}

using IsBasvuruApp.CORE.Entities;
using IsBasvuruApp.CORE.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.DAL.Repositories
{
    public class IlRepository : BaseRepository<Il>, IIlRepository
    {
        public IlRepository(AppDbContext db) : base(db)
        {

        }
    }
}

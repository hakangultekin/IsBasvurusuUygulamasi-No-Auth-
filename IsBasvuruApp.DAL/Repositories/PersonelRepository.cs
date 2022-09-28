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
    public class PersonelRepository : BaseRepository<Personel>, IPersonelRepository
    {
        public PersonelRepository(AppDbContext db) : base(db)
        {

        }

    }
}

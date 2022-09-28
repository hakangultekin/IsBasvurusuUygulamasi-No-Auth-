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
    public class PersonelBasvuruRepository : BaseRepository<PersonelBasvuru>, IPersonelBasvuruRepository
    {
        private readonly AppDbContext db;

        public PersonelBasvuruRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }

        public async Task<List<PersonelBasvuru>> GetAllByPersonelIdIncludesIller(long personelId)
        {
            return await db.PersonelBasvurulari.Where(a => a.PersonelID == personelId).Include("Il").ToListAsync();
        }
    }
}

using IsBasvuruApp.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.BLL.Services.PersonelBasvuruService
{
    public interface IPersonelBasvuruService
    {
        Task<bool> Create(PersonelBasvuru entity);
        Task<bool> Update(PersonelBasvuru entity);
        Task<bool> Delete(long id);
        Task<List<PersonelBasvuru>> GetAllByPersonelId(long personelId);
        Task<List<PersonelBasvuru>> GetAllByPersonelIdIncludesIller(long personelId);
        Task<PersonelBasvuru> GetById(long id);
    }
}

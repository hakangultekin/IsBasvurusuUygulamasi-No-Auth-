using IsBasvuruApp.BLL.ViewModels;
using IsBasvuruApp.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.BLL.Services.PersonelService
{
    public interface IPersonelService
    {
        Task<bool> CreatePersonel(Personel entity);
        Task<bool> UpdatePersonel(Personel entity);
        Task<bool> DeletePersonel(long personelId);
        Task<List<PersonelListVM>> GetAll();
        Task<Personel> GetPersonelById(long personelId);

    }
}

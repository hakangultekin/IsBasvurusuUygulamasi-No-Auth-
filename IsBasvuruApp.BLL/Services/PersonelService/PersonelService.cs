using IsBasvuruApp.BLL.ViewModels;
using IsBasvuruApp.CORE.Entities;
using IsBasvuruApp.CORE.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.BLL.Services.PersonelService
{
    public class PersonelService : IPersonelService
    {
        private readonly IPersonelRepository personelRepository;

        public PersonelService(IPersonelRepository personelRepository)
        {
            this.personelRepository = personelRepository;
        }
        public async Task<bool> CreatePersonel(Personel entity)
        {
            return await personelRepository.Create(entity);
        }
        public async Task<bool> DeletePersonel(long personelId)
        {
            Personel personel = await personelRepository.GetWhere(x => x.ID == personelId);
            return await personelRepository.Delete(personel);
        }

        public async Task<List<PersonelListVM>> GetAll()
        {
            List<PersonelListVM> vm = await personelRepository.GetFilteredList(
                    selector: x => new PersonelListVM
                    {
                        ID = x.ID,
                        Aciklama = x.Aciklama,
                        AdiSoyadi = x.AdiSoyadi,
                        Cinsiyet = x.Cinsiyet,
                        DogumTarihi = x.DogumTarihi,
                        IlAdi = x.Il.Adi,
                        IlceAdi = x.Ilce.Adi,
                    },
                    expression: x => x.ID > 0,
                    includes: x => x.Include(x => x.Il).Include(x => x.Ilce),
                    orderBy: x => x.OrderByDescending(x => x.ID)
                    );
            return vm;
        }

        public async Task<Personel> GetPersonelById(long personelId)
        {
            return await personelRepository.GetWhere(x => x.ID == personelId);
        }

        public async Task<bool> UpdatePersonel(Personel entity)
        {
            return await personelRepository.Update(entity);
        }

    }
}

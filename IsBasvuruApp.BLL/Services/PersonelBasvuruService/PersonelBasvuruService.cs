using IsBasvuruApp.CORE.Entities;
using IsBasvuruApp.CORE.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.BLL.Services.PersonelBasvuruService
{
    public class PersonelBasvuruService : IPersonelBasvuruService
    {
        private readonly IPersonelBasvuruRepository personelBasvuruRepository;

        public PersonelBasvuruService(IPersonelBasvuruRepository personelBasvuruRepository)
        {
            this.personelBasvuruRepository = personelBasvuruRepository;
        }

        public async Task<bool> Create(PersonelBasvuru entity)
        {
            return await personelBasvuruRepository.Create(entity);
        }

        public async Task<bool> Delete(long id)
        {
            PersonelBasvuru entity = await personelBasvuruRepository.GetWhere(a => a.ID == id);
            return await personelBasvuruRepository.Delete(entity);
        }

        public async Task<bool> Update(PersonelBasvuru entity)
        {
            return await personelBasvuruRepository.Update(entity);
        }

        public async Task<List<PersonelBasvuru>> GetAllByPersonelId(long personelId)
        {
            return await personelBasvuruRepository.GetAllWhere(x => x.PersonelID == personelId);
        }

        public async Task<PersonelBasvuru> GetById(long id)
        {
            return await personelBasvuruRepository.GetWhere(x => x.ID == id);
        }

        public async Task<List<PersonelBasvuru>> GetAllByPersonelIdIncludesIller(long personelId)
        {
            return await personelBasvuruRepository.GetAllByPersonelIdIncludesIller(personelId);
        }
    }
}

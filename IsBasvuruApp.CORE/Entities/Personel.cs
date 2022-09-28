using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.CORE.Entities
{
    public class Personel : IBaseEntity
    {
        public Personel()
        {
            PersonelBasvurulari = new HashSet<PersonelBasvuru>();
        }

        // Implement Interface
        public long ID { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;

        public string AdiSoyadi { get; set; }
        public long IlID { get; set; }
        public Il Il { get; set; }
        public long IlceID { get; set; }
        public Ilce Ilce { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Aciklama { get; set; }
        public ICollection<PersonelBasvuru> PersonelBasvurulari { get; set; }
    }
}

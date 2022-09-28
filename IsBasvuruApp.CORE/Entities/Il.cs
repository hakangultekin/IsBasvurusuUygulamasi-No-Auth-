using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.CORE.Entities
{
    public class Il : IBaseEntity
    {
        public Il()
        {
            Ilceler = new HashSet<Ilce>();
            PersonelBasvurulari = new HashSet<PersonelBasvuru>();
            Personeller = new HashSet<Personel>();
        }
        // Implement Interface
        public long ID { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;

        public string Adi { get; set; }
        public ICollection<Ilce> Ilceler { get; set; }
        public ICollection<PersonelBasvuru> PersonelBasvurulari { get; set; }
        public ICollection<Personel> Personeller { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.CORE.Entities
{
    public class Ilce : IBaseEntity
    {
        public Ilce()
        {
            Personeller = new HashSet<Personel>();
        }

        // Implement Interface
        public long ID { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public string Adi { get; set; }
        public long IlID { get; set; }
        public Il Il { get; set; }
        public ICollection<Personel> Personeller { get; set; }
    }
}

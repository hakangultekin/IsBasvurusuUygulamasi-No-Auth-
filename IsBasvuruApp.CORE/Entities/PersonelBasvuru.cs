using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.CORE.Entities
{
    public class PersonelBasvuru : IBaseEntity
    {
        // Implement Interface
        public long ID { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;

        public long PersonelID { get; set; }
        public Personel Personel { get; set; }
        public DateTime BasvuruTarihi { get; set; }
        public long IlID { get; set; }
        public Il Il { get; set; }
        public bool SeyahatEngeliYok { get; set; }
        public string IsyeriAdi { get; set; }
        public string Pozisyon { get; set; }
        public string Aciklama { get; set; }
    }
}

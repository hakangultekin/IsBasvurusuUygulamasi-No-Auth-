using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.BLL.ViewModels
{
    public class PersonelListVM
    {
        public long ID { get; set; }
        public string AdiSoyadi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Aciklama { get; set; }
    }
}

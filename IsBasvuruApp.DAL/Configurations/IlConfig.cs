using IsBasvuruApp.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruApp.DAL.Configurations
{
    public class IlConfig : IEntityTypeConfiguration<Il>
    {
        public void Configure(EntityTypeBuilder<Il> builder)
        {
            builder.Property(x => x.Adi).HasMaxLength(100).HasColumnType("varchar");

            DateTime now = DateTime.Now;
            builder.HasData(
                new Il { ID = 1, Adi = "ADANA", OlusturulmaTarihi = now },
                new Il { ID = 2, Adi = "ADIYAMAN", OlusturulmaTarihi = now },
                new Il { ID = 3, Adi = "AFYON", OlusturulmaTarihi = now },
                new Il { ID = 4, Adi = "AĞRI", OlusturulmaTarihi = now },
                new Il { ID = 5, Adi = "AMASYA", OlusturulmaTarihi = now },
                new Il { ID = 6, Adi = "ANKARA", OlusturulmaTarihi = now },
                new Il { ID = 7, Adi = "ANTALYA", OlusturulmaTarihi = now },
                new Il { ID = 8, Adi = "ARTVİN", OlusturulmaTarihi = now },
                new Il { ID = 9, Adi = "AYDIN", OlusturulmaTarihi = now },
                new Il { ID = 10, Adi = "BALIKESİR", OlusturulmaTarihi = now },
                new Il { ID = 11, Adi = "BİLECİK", OlusturulmaTarihi = now },
                new Il { ID = 12, Adi = "BİNGÖL", OlusturulmaTarihi = now },
                new Il { ID = 13, Adi = "BİTLİS", OlusturulmaTarihi = now },
                new Il { ID = 14, Adi = "BOLU", OlusturulmaTarihi = now },
                new Il { ID = 15, Adi = "BURDUR", OlusturulmaTarihi = now },
                new Il { ID = 16, Adi = "BURSA", OlusturulmaTarihi = now },
                new Il { ID = 17, Adi = "ÇANAKKALE", OlusturulmaTarihi = now },
                new Il { ID = 18, Adi = "ÇANKIRI", OlusturulmaTarihi = now },
                new Il { ID = 19, Adi = "ÇORUM", OlusturulmaTarihi = now },
                new Il { ID = 20, Adi = "DENİZLİ", OlusturulmaTarihi = now },
                new Il { ID = 21, Adi = "DİYARBAKIR", OlusturulmaTarihi = now },
                new Il { ID = 22, Adi = "EDİRNE", OlusturulmaTarihi = now },
                new Il { ID = 23, Adi = "ELAZIĞ", OlusturulmaTarihi = now },
                new Il { ID = 24, Adi = "ERZİNCAN", OlusturulmaTarihi = now },
                new Il { ID = 25, Adi = "ERZURUM", OlusturulmaTarihi = now },
                new Il { ID = 26, Adi = "ESKİŞEHİR", OlusturulmaTarihi = now },
                new Il { ID = 27, Adi = "GAZİANTEP", OlusturulmaTarihi = now },
                new Il { ID = 28, Adi = "GİRESUN", OlusturulmaTarihi = now },
                new Il { ID = 29, Adi = "GÜMÜŞHANE", OlusturulmaTarihi = now },
                new Il { ID = 30, Adi = "HAKKARİ", OlusturulmaTarihi = now },
                new Il { ID = 31, Adi = "HATAY", OlusturulmaTarihi = now },
                new Il { ID = 32, Adi = "ISPARTA", OlusturulmaTarihi = now },
                new Il { ID = 33, Adi = "İÇEL", OlusturulmaTarihi = now },
                new Il { ID = 34, Adi = "İSTANBUL", OlusturulmaTarihi = now },
                new Il { ID = 35, Adi = "İZMİR", OlusturulmaTarihi = now },
                new Il { ID = 36, Adi = "KARS", OlusturulmaTarihi = now },
                new Il { ID = 37, Adi = "KASTAMONU", OlusturulmaTarihi = now },
                new Il { ID = 38, Adi = "KAYSERİ", OlusturulmaTarihi = now },
                new Il { ID = 39, Adi = "KIRKLARELİ", OlusturulmaTarihi = now },
                new Il { ID = 40, Adi = "KIRŞEHİR", OlusturulmaTarihi = now },
                new Il { ID = 41, Adi = "KOCAELİ", OlusturulmaTarihi = now },
                new Il { ID = 42, Adi = "KONYA", OlusturulmaTarihi = now },
                new Il { ID = 43, Adi = "KÜTAHYA", OlusturulmaTarihi = now },
                new Il { ID = 44, Adi = "MALATYA", OlusturulmaTarihi = now },
                new Il { ID = 45, Adi = "MANİSA", OlusturulmaTarihi = now },
                new Il { ID = 46, Adi = "KAHRAMANMARAŞ", OlusturulmaTarihi = now },
                new Il { ID = 47, Adi = "MARDİN", OlusturulmaTarihi = now },
                new Il { ID = 48, Adi = "MUĞLA", OlusturulmaTarihi = now },
                new Il { ID = 49, Adi = "MUŞ", OlusturulmaTarihi = now },
                new Il { ID = 50, Adi = "NEVŞEHİR", OlusturulmaTarihi = now },
                new Il { ID = 51, Adi = "NİĞDE", OlusturulmaTarihi = now },
                new Il { ID = 52, Adi = "ORDU", OlusturulmaTarihi = now },
                new Il { ID = 53, Adi = "RİZE", OlusturulmaTarihi = now },
                new Il { ID = 54, Adi = "SAKARYA", OlusturulmaTarihi = now },
                new Il { ID = 55, Adi = "SAMSUN", OlusturulmaTarihi = now },
                new Il { ID = 56, Adi = "SİİRT", OlusturulmaTarihi = now },
                new Il { ID = 57, Adi = "SİNOP", OlusturulmaTarihi = now },
                new Il { ID = 58, Adi = "SİVAS", OlusturulmaTarihi = now },
                new Il { ID = 59, Adi = "TEKİRDAĞ", OlusturulmaTarihi = now },
                new Il { ID = 60, Adi = "TOKAT", OlusturulmaTarihi = now },
                new Il { ID = 61, Adi = "TRABZON", OlusturulmaTarihi = now },
                new Il { ID = 62, Adi = "TUNCELİ", OlusturulmaTarihi = now },
                new Il { ID = 63, Adi = "ŞANLIURFA", OlusturulmaTarihi = now },
                new Il { ID = 64, Adi = "UŞAK", OlusturulmaTarihi = now },
                new Il { ID = 65, Adi = "VAN", OlusturulmaTarihi = now },
                new Il { ID = 66, Adi = "YOZGAT", OlusturulmaTarihi = now },
                new Il { ID = 67, Adi = "ZONGULDAK", OlusturulmaTarihi = now },
                new Il { ID = 68, Adi = "AKSARAY", OlusturulmaTarihi = now },
                new Il { ID = 69, Adi = "BAYBURT", OlusturulmaTarihi = now },
                new Il { ID = 70, Adi = "KARAMAN", OlusturulmaTarihi = now },
                new Il { ID = 71, Adi = "KIRIKKALE", OlusturulmaTarihi = now },
                new Il { ID = 72, Adi = "BATMAN", OlusturulmaTarihi = now },
                new Il { ID = 73, Adi = "ŞIRNAK", OlusturulmaTarihi = now },
                new Il { ID = 74, Adi = "BARTIN", OlusturulmaTarihi = now },
                new Il { ID = 75, Adi = "ARDAHAN", OlusturulmaTarihi = now },
                new Il { ID = 76, Adi = "IĞDIR", OlusturulmaTarihi = now },
                new Il { ID = 77, Adi = "YALOVA", OlusturulmaTarihi = now },
                new Il { ID = 78, Adi = "KARABÜK", OlusturulmaTarihi = now },
                new Il { ID = 79, Adi = "KİLİS", OlusturulmaTarihi = now },
                new Il { ID = 80, Adi = "OSMANİYE", OlusturulmaTarihi = now },
                new Il { ID = 81, Adi = "DÜZCE", OlusturulmaTarihi = now }
            );
        }
    }
}

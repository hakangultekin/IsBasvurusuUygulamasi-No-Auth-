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
    public class PersonelBasvuruConfig : IEntityTypeConfiguration<PersonelBasvuru>
    {
        public void Configure(EntityTypeBuilder<PersonelBasvuru> builder)
        {
            builder.Property(x => x.BasvuruTarihi).HasColumnType("datetime");
            builder.Property(x => x.IsyeriAdi).HasMaxLength(100).HasColumnType("varchar");
            builder.Property(x => x.Pozisyon).HasMaxLength(100).HasColumnType("varchar");
            builder.Property(x => x.Aciklama).HasMaxLength(100).HasColumnType("varchar");
            builder.HasOne(a => a.Personel).WithMany(b => b.PersonelBasvurulari).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

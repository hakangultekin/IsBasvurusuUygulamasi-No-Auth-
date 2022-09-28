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
    public class PersonelConfig : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.Property(x => x.AdiSoyadi).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.Cinsiyet).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.DogumTarihi).HasMaxLength(50).HasColumnType("datetime");
            builder.Property(x => x.Aciklama).HasMaxLength(100).HasColumnType("varchar");
            builder.HasOne(a => a.Il).WithMany(b => b.Personeller).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(a => a.PersonelBasvurulari).WithOne(b => b.Personel).HasForeignKey(c => c.PersonelID).OnDelete(DeleteBehavior.NoAction);

            
        }
    }
}

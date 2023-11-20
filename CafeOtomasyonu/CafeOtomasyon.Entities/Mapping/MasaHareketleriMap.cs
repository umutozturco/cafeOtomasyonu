using CafeOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Mapping
{
    public class MasaHareketleriMap:EntityTypeConfiguration<MasaHareketleri>
    {
        public MasaHareketleriMap()
        {
            this.ToTable("MasaHareketleri");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.tarih).HasColumnType("Date");
            this.Property(p => p.satisKodu).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.aciklama).HasColumnType("varchar").HasMaxLength(300);

            this.HasOptional(x=>x.Masalar).WithMany(x=>x.MasaHareketleri).HasForeignKey(x=>x.masaId);
            this.HasRequired(x=>x.Urun).WithMany(x=>x.MasaHareketleri).HasForeignKey(x=>x.urunId);
        }
    }
}

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
    public class KullanicilarMap:EntityTypeConfiguration<Kullanicilar>
    {
        public KullanicilarMap()
        {
            this.ToTable("Kullanicilar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.adres).HasColumnType("varchar").HasMaxLength(500);
            this.Property(p => p.adSoyad).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.telefon).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.email).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.gorevi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.kullaniciAdi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.parola).HasColumnType("varchar").HasMaxLength(20);
            this.Property(p => p.hatirlatmaSorusu).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.cevap).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.aciklama).HasColumnType("varchar").HasMaxLength(300);
            
        }
    }
}

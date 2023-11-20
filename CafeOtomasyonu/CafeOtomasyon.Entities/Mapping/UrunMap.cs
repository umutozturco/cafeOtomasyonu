using CafeOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CafeOtomasyon.Entities.Mapping
{
    public class UrunMap:EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            this.ToTable("Urun");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p=>p.urunKodu).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p=>p.urunAdi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p=>p.aciklama).HasColumnType("varchar").HasMaxLength(300);
            this.Property(p => p.birimFiyati1).HasColumnType("decimal").HasPrecision(28, 2);
            this.Property(p => p.birimFiyati2).HasColumnType("decimal").HasPrecision(28, 2);
            this.Property(p => p.birimFiyati3).HasColumnType("decimal").HasPrecision(28, 2);
            this.Property(p => p.urunKodu).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.urunKodu).HasColumnType("varchar").HasMaxLength(15);
            
            this.HasRequired(x=> x.Menu).WithMany(x=> x.Urun).HasForeignKey(x=>x.menuId);

        }
    }
}

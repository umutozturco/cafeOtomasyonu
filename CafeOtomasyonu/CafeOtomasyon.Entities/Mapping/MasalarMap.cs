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
    public class MasalarMap:EntityTypeConfiguration<Masalar>
    {
        public MasalarMap()
        {
            this.ToTable("Masalar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.masaAdi).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.SatisKodu).HasColumnType("varchar").HasMaxLength(20);
            this.Property(p => p.aciklama).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.eklenmeTarihi).HasColumnType("Date");

            this.HasOptional(x => x.Kullanicilar).WithMany().HasForeignKey(m => m.kullaniciId);



        }
    }
}

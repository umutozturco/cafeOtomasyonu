using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyon.Entities.Interfaces;
using CafeOtomasyon.Entities.Models;

namespace CafeOtomasyon.Entities.Mapping
{
    public class MusterilerMap:EntityTypeConfiguration<Musteriler>
    {
        public MusterilerMap()
        {
            this.ToTable("Musteriler");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.adSoyad).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.telefon).HasColumnType("varchar").HasMaxLength(25);
            this.Property(p => p.adres).HasColumnType("varchar").HasMaxLength(200);
            this.Property(p => p.email).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.aciklama).HasColumnType("varchar").HasMaxLength(500);

            
        }
    }
}

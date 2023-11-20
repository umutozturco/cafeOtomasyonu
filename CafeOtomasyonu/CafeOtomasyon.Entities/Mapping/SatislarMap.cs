﻿using CafeOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Mapping
{
    public class SatislarMap:EntityTypeConfiguration<Satislar>
    {   
        public SatislarMap()
        {
            this.ToTable("Satislar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.satisKodu).HasColumnType("varchar").HasMaxLength(15);
            
            this.Property(p => p.aciklama).HasColumnType("varchar").HasMaxLength(300);
            this.HasOptional(s => s.Musteriler).WithMany(s => s.Satislar).HasForeignKey(s => s.musterId);

        }
       
    }
}

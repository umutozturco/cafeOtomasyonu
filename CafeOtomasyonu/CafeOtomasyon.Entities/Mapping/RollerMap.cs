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
    public class RollerMap:EntityTypeConfiguration<Roller>
    {
        public RollerMap()
        {
            this.ToTable("Roller");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.controlCaption).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.controlName).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.formName).HasColumnType("varchar").HasMaxLength(50);
            
        }
    }
}

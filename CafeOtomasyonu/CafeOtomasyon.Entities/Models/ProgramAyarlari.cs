using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyon.Entities.Interfaces;

namespace CafeOtomasyon.Entities.Models
{
    [Table("ProgramAyarlari")]
    public class ProgramAyarlari:IEntity
    {
        public int Id { get; set; }
        public string ayarTanimi { get; set; }
        public string ayarAdi { get; set; }
    }
}

using CafeOtomasyon.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    [Table("KullaniciHareketleri")]
    public class KullaniciHareketleri : IEntity
    {
        public int Id { get; set; }
        
        public int kullaniciId { get; set; }
        public string aciklama { get; set; }
        public DateTime tarih { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyon.Entities.Interfaces;

namespace CafeOtomasyon.Entities.Models
{
    public class Musteriler:IEntity
    {
        public int Id { get; set; }
        public string adSoyad { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public string email { get; set; }
        public string aciklama { get; set; }
        public DateTime tarih { get; set; }
        public virtual ICollection<Satislar> Satislar { get; set; }
    }
}

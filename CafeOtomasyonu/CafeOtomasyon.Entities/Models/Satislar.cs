using CafeOtomasyon.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    
    public class Satislar:IEntity
    {
        public int Id { get; set; }
        public string satisKodu { get; set; }
        public int? musterId { get; set; }
        public decimal tutar { get; set; }
        public decimal indirimToplami { get; set; }
        public decimal odenen { get; set; }
        public decimal kalan { get; set; }
        public string aciklama { get; set; }
        public DateTime sonIslemTarihi { get; set; }
        public bool paketSiparisMi { get; set; } = false;
        public virtual Musteriler Musteriler { get; set; }

    }
}

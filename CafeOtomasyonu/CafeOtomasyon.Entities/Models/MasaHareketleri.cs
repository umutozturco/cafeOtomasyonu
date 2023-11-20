using CafeOtomasyon.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    public class MasaHareketleri:IEntity
    {
        
        public int Id { get; set; }
        public string satisKodu { get; set; }
        public int? masaId { get; set; }
        //public int menuId { get; set; }
        public int urunId { get; set; }
        public int miktari { get; set; }
        public decimal birimFiyati { get; set; }
       // public decimal indirimTutari { get; set; }
       public decimal indirimOrani { get; set; } = 0;
        public string aciklama { get; set; }
        public DateTime tarih { get; set; }
        
        public virtual Masalar Masalar { get; set; }
        public virtual Urun Urun { get; set; }
    }
}

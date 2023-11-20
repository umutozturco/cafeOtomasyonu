using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyon.Entities.Interfaces;

namespace CafeOtomasyon.Entities.Models
{
    
    public class Urun:IEntity
    {
        
        public int Id { get; set; }
        
        public int menuId { get; set; }
        
        public string urunKodu { get; set; }
        public string urunAdi { get; set; }
        public decimal birimFiyati1 { get; set; }
        public decimal birimFiyati2 { get; set; }
        
        public decimal birimFiyati3 { get; set; }

        public string aciklama { get; set; }
        public DateTime tarih { get; set; }
        public bool hizliSatis { get; set; } = false;
        public string resim { get; set; }
        public virtual Menu Menu { get; set; }
        
        public virtual ICollection<MasaHareketleri> MasaHareketleri { get; set; }

    }
}

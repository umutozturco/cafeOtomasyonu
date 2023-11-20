using CafeOtomasyon.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    
    public class Masalar:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string masaAdi { get; set; }
        public string aciklama { get; set; }
        public bool durumu { get; set; } = false;
        public bool rezerveMi { get; set; } =false;
        public DateTime eklenmeTarihi { get; set; }=DateTime.Now;
        public DateTime sonIslemTarihi { get; set; }=DateTime.Now;
        public string islem { get; set; }
        public string SatisKodu { get; set; }
        public int? kullaniciId  { get; set; }
        public virtual ICollection<MasaHareketleri> MasaHareketleri { get; set; }
        public virtual ICollection<Kullanicilar> Kullanicilar { get; set; }
    }
}

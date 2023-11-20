using CafeOtomasyon.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    public class Kullanicilar : IEntity
    {
        public int Id { get; set; }
        public string adSoyad { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public string email { get; set; }
        public string gorevi { get; set; }
        public string kullaniciAdi { get; set; }
        public string parola { get; set; }
        public string hatirlatmaSorusu { get; set; }
        public string cevap { get; set; }
        public string aciklama { get; set; }
        public DateTime kayitTarihi { get; set; }
        public bool aktifMi { get; set; } = true;
        public bool IsAdmin { get; set; } = false;
        public virtual ICollection<KullaniciHareketleri> KullanıcıHareketleri { get; set; }
        public virtual ICollection<Masalar> Masalar { get; set; }
    }
}

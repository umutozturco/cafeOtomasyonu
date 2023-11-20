using CafeOtomasyon.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    public class OdemeHareketleri:IEntity
    {
        public int Id { get; set; }
        public string satisKodu { get; set; }
        public string odemeTuru { get; set; }
        public decimal odenen { get; set; }
        public string aciklama { get; set; }
        public DateTime tarih { get; set; }
    }
}

using CafeOtomasyon.Entities.Models;
using CafeOtomasyon.Entities.Repository;
using CafeOtomasyon.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.DAL
{
    public class KullaniciHareketleriDal:EntityRepositoryBase<CafeContext,KullaniciHareketleri,KullaniciHareketleriValidator>
    {
        //public static int kullaniciId { get; set; }
        public void KullaniciHareketleriEkle(CafeContext context, KullaniciHareketleri kullaniciHareketleri,string aciklama)
        {
            KullaniciHareketleriDal kullanıcıHareketleriDal = new KullaniciHareketleriDal();
            kullaniciHareketleri.tarih=DateTime.Now;
            kullaniciHareketleri.aciklama = aciklama;
            if (kullanıcıHareketleriDal.AddOrUpdate(context,kullaniciHareketleri))
            {
                kullanıcıHareketleriDal.Save(context);

            }
        }
    }
}

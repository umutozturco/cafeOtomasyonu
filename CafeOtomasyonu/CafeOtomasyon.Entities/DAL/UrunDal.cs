 
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
    public class UrunDal : EntityRepositoryBase<CafeContext, Urun, UrunValidator>
    {
        public object UrunListele(CafeContext context)
        {
            var liste = (from u in context.Urun
                select new
                {
                    u.Id,
                    u.menuId,
                    u.Menu.menuAdi,
                    u.urunKodu,
                    u.urunAdi,
                    u.birimFiyati1,
                    u.birimFiyati2,
                    u.birimFiyati3,
                    u.aciklama,
                    u.resim,
                    u.tarih,
                    u.hizliSatis


                }).ToList();
            return liste;
        }
    }
}

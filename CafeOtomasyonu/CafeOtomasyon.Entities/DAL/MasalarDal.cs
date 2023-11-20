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
    public class MasalarDal : EntityRepositoryBase<CafeContext, Masalar,MasalarValidator>
    {
        public object MasalariListele(CafeContext context)
        {
            var model = (from masa in context.Masalars join k in context.Kullanicilar.DefaultIfEmpty() on masa.kullaniciId equals k.Id into kullanici from kullanicimasa in kullanici.DefaultIfEmpty()
                select new
                {
                    masa.aciklama,
                    masa.durumu,    
                    masa.eklenmeTarihi,
                    masa.Id,
                    masa.islem,
                    masa.masaAdi,
                    masa.rezerveMi,
                    masa.sonIslemTarihi,
                    Kullanici=kullanicimasa.kullaniciAdi
                }).ToList();
            return model;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyon.Entities.Models;
using CafeOtomasyonu.WinForms.WinTools;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace CafeOtomasyonu.WinForms.Roller
{
    public class KullaniciYetki
    {
        public static void YetkileriGetir(CafeContext context, RibbonControl ribbon)
        {
            foreach (var item in ribbon.Items)
            {
                foreach (var roller in context.Rollers.Where(r=>r.kullaniciId==KullaniciAyarlari.kullaniciId).ToList())
                {
                    if (item is BarButtonItem)
                    {
                        var btn= item as BarButtonItem;
                        if (btn.Caption==roller.controlCaption&&roller.Visible==true)
                        {
                            btn.Enabled = true;
                        }
                        if (btn.Caption == roller.controlCaption && !roller.Visible)
                        {
                            btn.Enabled = false;
                        }
                    }
                }
            }
        }

        public static void AdminMi(CafeContext context, params dynamic[] obj)
        {
            var adminKontrol = context.Kullanicilar.FirstOrDefault(k => k.Id == KullaniciAyarlari.kullaniciId);
            if (adminKontrol.IsAdmin)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].Enabled = true;
                }
                
            }
            else if (!adminKontrol.IsAdmin)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].Enabled = false; 
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Entities.Models;
using Menu = CafeOtomasyon.Entities.Models.Menu;

namespace CafeOtomasyon.Entities.Tools
{
    public class ConnectionTools
    {
        public static string baglan()
        {
            string readStr;
            string path = @"ConnectionStr\baglanti.txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            using (var reader = new StreamReader(fileStream))
            {
                string row = reader.ReadLine();
                readStr = row;
                reader.Close();
            }
            fileStream.Close();
            return readStr;
        }
        public static void BaglantiKontrol()
        {
            using (var context = new CafeContext())
            {
                if (!context.Database.Exists())
                {
                    context.Database.CreateIfNotExists();
                }
                
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<CafeContext,Entities.Migrations.Configuration>());
            }
        }

        public static void VeriDoldur(CafeContext context)
        {
            if (!context.Masalars.Any())
            {
                List<Masalar> list = new List<Masalar>()
                {
                    new Masalar
                    {
                        masaAdi = "Masa 6",
                        aciklama = "A Grubu 6. sıra",
                        islem = "Masa 6 oluşturuldu."
                    },
                    new Masalar
                    {
                        masaAdi = "Masa 7",
                        aciklama = "A Grubu 7. sıra",
                        islem = "Masa 7 oluşturuldu."
                    },
                    new Masalar
                    {
                        masaAdi = "Masa 8",
                        aciklama = "A Grubu 8. sıra",
                        islem = "Masa 8 oluşturuldu."
                    }
                };
                context.Masalars.AddRange(list);
            }

            if (!context.Menu.Any())

            {
                List<Menu> menuList = new List<Menu>
                {
                    new Menu
                    {
                        menuAdi = "Dondurmalar",
                        aciklama = "Dondurma Seçenekleri"

                    },
                    new Menu
                    {
                        menuAdi = "Soğuk Sandviçler",
                        aciklama = "Soğuk Sandviç Seçenekleri"
                    },
                    new Menu
                    {
                        menuAdi = "Çorbalar",
                        aciklama = "Çorba Seçenekleri"
                    }

                };
                context.Menu.AddRange(menuList);

            }

            if (!context.SatisKodu.Any())
            {
                List<SatisKodu> satisKoduList = new List<SatisKodu>
                
                {
                    new SatisKodu

                    {
                        satisTanimi = "Satis",
                        sayi = 1
                    }

                };
                context.SatisKodu.AddRange(satisKoduList);
            }

            context.SaveChanges();
        }
    }
}

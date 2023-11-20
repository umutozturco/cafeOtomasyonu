using CafeOtomasyonu.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Entities.Models;
using CafeOtomasyon.Entities.Tools;
using CafeOtomasyonu.WinForms.AnaMenu;

namespace restaurantOtomasyon
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionTools.BaglantiKontrol();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new frmAnaMenu());
        }
    }
}

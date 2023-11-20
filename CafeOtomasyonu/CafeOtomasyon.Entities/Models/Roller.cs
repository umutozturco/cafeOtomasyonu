using CafeOtomasyon.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    public class Roller:IEntity
    {
        public int Id { get; set; }
        public int kullaniciId { get; set; }
        public string formName { get; set; }
        public string controlName { get; set; }
        public string controlCaption { get; set; }
        public bool Visible { get; set; }
    }
}

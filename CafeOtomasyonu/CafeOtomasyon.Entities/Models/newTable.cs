using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyon.Entities.Interfaces;

namespace CafeOtomasyon.Entities.Models
{
    public class newTable:IEntity
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

    }
}

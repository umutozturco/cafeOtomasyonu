﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    [Table("SatisKodu")]
    public class SatisKodu
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string satisTanimi { get; set; }
        public int sayi { get; set; }
    }
}

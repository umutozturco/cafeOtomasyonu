using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyon.Entities.Models;
using FluentValidation;

namespace CafeOtomasyon.Entities.Validations
{
    public class MusterilerValidator : AbstractValidator<Musteriler>
    {
        public MusterilerValidator()
        {
            RuleFor(p => p.adSoyad).NotEmpty().WithMessage("Ad soyad alanı boş geçilemez");
            RuleFor(p => p.telefon).NotEmpty().WithMessage("Satış kodu boş geçilemez");
            
        }
    }
}

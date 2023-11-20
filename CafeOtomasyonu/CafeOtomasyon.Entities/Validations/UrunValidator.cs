
using CafeOtomasyon.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Validations
{
    public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(p => p.urunKodu).NotEmpty().WithMessage("Ürün kodu boş bırakılamaz.");
            RuleFor(p => p.urunAdi).NotEmpty().WithMessage("Ürün adı boş bırakılamaz.");
            RuleFor(p => p.birimFiyati1).NotEmpty().WithMessage("Birim fiyatı 1 boş bırakılamaz.");
            RuleFor(p => p.birimFiyati2).NotEmpty().WithMessage("Birim fiyatı 2 boş bırakılamaz.");
            RuleFor(p => p.birimFiyati3).NotEmpty().WithMessage("Birim fiyatı 3 boş bırakılamaz.");
        }
    }
}

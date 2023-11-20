using CafeOtomasyon.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Validations
{
    public class MasaHareketleriValidator:AbstractValidator<MasaHareketleri>
    {
        public MasaHareketleriValidator()
        {
            RuleFor(p => p.satisKodu).NotEmpty().WithMessage("Satış kodu boş geçilemez");
            //RuleFor(p => p.satisKodu).Length(12).WithMessage("Satış kodu 12 karakterden oluşmalıdır.");
            RuleFor(p => p.miktari).NotEmpty().WithMessage("Miktar alanı boş geçilemez.");
            RuleFor(p => p.miktari).GreaterThan(0).WithMessage("Miktar 1'den az olamaz.");

            RuleFor(p => p.birimFiyati).NotEmpty().WithMessage("Birim fiyatı boş geçilemez.");
            RuleFor(p => p.birimFiyati).LessThanOrEqualTo(150).WithMessage("Birim fiyatı en fazla 150 olabilir.");

        }
    }
}

using CafeOtomasyon.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Validations
{
    public class KullanicilarValidator:AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidator()
        {
            RuleFor(p => p.adSoyad).NotEmpty().WithMessage("Ad soyad alanı boş geçilemez.");
            RuleFor(p => p.kullaniciAdi).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez.");
            RuleFor(p => p.kullaniciAdi).MinimumLength(4).WithMessage("Kullanıcı adı alanı 4 karakterden az olmamalıdır.");
            RuleFor(p => p.kullaniciAdi).MaximumLength(15).WithMessage("Kullanıcı adı alanı 15 karakterden çok olmamalıdır.");
            RuleFor(p => p.parola).NotEmpty().WithMessage("Parola alanı boş geçilemez.");
            RuleFor(p => p.kullaniciAdi).MinimumLength(6).WithMessage("Kullanıcı adı alanı 6 karakterden az olmamalıdır.");
            RuleFor(p => p.kullaniciAdi).MaximumLength(15).WithMessage("Kullanıcı adı alanı 15 karakterden fazla olmamalıdır.");
            RuleFor(p => p.telefon).NotEmpty().WithMessage("Telefon alanı boş geçilemez.");
            RuleFor(p => p.email).NotEmpty().WithMessage("E mail alanı boş geçilemez.");
            RuleFor(p => p.email).EmailAddress().WithMessage("Yanlış email adres formatı.");
        }
    }
}

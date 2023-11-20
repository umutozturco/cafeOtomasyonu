using CafeOtomasyon.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Validations
{
    public class MenuValidator:AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(p => p.menuAdi).NotEmpty().WithMessage("Menü adı boş bırakılamaz.");
            RuleFor(p => p.menuAdi).MinimumLength(3).WithMessage("Menü adı alanı en az 3 karakterden oluşmalıdır.");
            RuleFor(p => p.menuAdi).MaximumLength(20).WithMessage("Menü adı alanı en fazla 20 karakterden oluşmalıdır.");   
        }
    }
}

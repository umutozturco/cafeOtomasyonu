﻿using CafeOtomasyon.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Validations
{
    public class MasalarValidator:AbstractValidator<Masalar>
    {
        public MasalarValidator()
        {
            RuleFor(p => p.masaAdi).NotEmpty().WithMessage("Masa adı boş bırakılamaz.");
        }
    }
}

﻿using CafeOtomasyon.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Validations
{
    public class SatislarValidator:AbstractValidator<Satislar>
    {
        public SatislarValidator()
        {
            RuleFor(p => p.satisKodu).NotEmpty().WithMessage("Satış kodu boş bırakılamaz.");
        }
    }
}

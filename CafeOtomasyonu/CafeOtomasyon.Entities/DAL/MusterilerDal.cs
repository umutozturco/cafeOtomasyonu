using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyon.Entities.Models;
using CafeOtomasyon.Entities.Repository;
using CafeOtomasyon.Entities.Validations;

namespace CafeOtomasyon.Entities.DAL
{
    public class MusterilerDal:EntityRepositoryBase<CafeContext,Musteriler,MusterilerValidator>
    {

    }
}

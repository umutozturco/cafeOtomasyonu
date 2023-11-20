using CafeOtomasyon.Entities.Models;
using CafeOtomasyon.Entities.Repository;
using CafeOtomasyon.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.DAL
{
    public class RollerDal : EntityRepositoryBase<CafeContext, Roller,RollerValidator>
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    class EfDeneme1_MatematikDal : GenericRepository<Deneme1_Matematik>, IDeneme1_MatematikDal
    {
    }
}

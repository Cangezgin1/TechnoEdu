using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    class EfDeneme1_FenDal : GenericRepository<Deneme1_Fen>, IDeneme1_FenDal
    {
    }
}

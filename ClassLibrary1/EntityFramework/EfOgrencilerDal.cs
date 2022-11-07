using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfOgrencilerDal : GenericRepository<Ogrenciler>, IOgrencilerDal
    {
    }
}

using System;
using System.Collections.Generic;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    class EfDeneme1Dal : GenericRepository<Deneme1>, IDeneme1Dal
    {
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    class EfDeneme1_SosyalBilgilerDal : GenericRepository<Deneme1_SosyalBilgiler>, IDeneme1_SosyalBilgilerDal
    {
    }
}

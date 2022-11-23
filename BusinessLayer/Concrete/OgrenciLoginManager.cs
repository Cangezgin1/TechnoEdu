using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OgrenciLoginManager : IOgrenciLoginService
    {
        IOgrencilerDal _ogrencilerDal;

        public OgrenciLoginManager(IOgrencilerDal ogrencilerDal)
        {
            _ogrencilerDal = ogrencilerDal;
        }

        public Ogrenciler GetOgrenci(string Kullanıcıadı, string sifre)
        {
            throw new NotImplementedException();
        }
    }
}

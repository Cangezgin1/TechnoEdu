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

        public void TAdd(Ogrenciler t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Ogrenciler t)
        {
            throw new NotImplementedException();
        }

        public Ogrenciler TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ogrenciler> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Ogrenciler t)
        {
            throw new NotImplementedException();
        }
    }
}

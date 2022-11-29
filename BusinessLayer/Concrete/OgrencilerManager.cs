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
    public class OgrencilerManager : IOgrencilerService
    {
        IOgrencilerDal _ogrencilerDal;

        public OgrencilerManager(IOgrencilerDal ogrencilerDal)
        {
            _ogrencilerDal = ogrencilerDal;
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
            return _ogrencilerDal.GetList();
        }

        public void TUpdate(Ogrenciler t)
        {
            throw new NotImplementedException();
        }
    }
}

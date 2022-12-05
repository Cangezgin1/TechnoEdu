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
    public class OgretmenlerManager : IOgretmenlerService
    {

        IOgretmenlerDal _ogretmenlerDal;

        public OgretmenlerManager(IOgretmenlerDal ogretmenlerDal)
        {
            _ogretmenlerDal = ogretmenlerDal;
        }

        public void TAdd(Ogretmenler t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Ogretmenler t)
        {
            throw new NotImplementedException();
        }

        public Ogretmenler TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ogretmenler> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Ogretmenler t)
        {
            throw new NotImplementedException();
        }

        public void AddOgretmen(Ogretmenler ogretmenler)
        {
            _ogretmenlerDal.Insert(ogretmenler);
        }

        public void DeleteOgretmen(Ogretmenler ogretmenler)
        {
            _ogretmenlerDal.Delete(ogretmenler);
        }

        public Ogretmenler GetByID(int id)
        {
            return _ogretmenlerDal.Get(x => x.OgretmenID == id);
        }

        public void UpdateOgretmen(Ogretmenler ogretmenler)
        {
            _ogretmenlerDal.Update(ogretmenler);
        }
    }
}

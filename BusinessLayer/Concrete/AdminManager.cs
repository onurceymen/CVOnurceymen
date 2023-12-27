using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
       private readonly IAdminDal _adminDal;

       public AdminManager(IAdminDal adminDal)
       {
           _adminDal = adminDal;
       }
       
       public void TAdd(Admin t)
        {
            _adminDal.Insert(t);
        }

        public void TDelete(Admin t)
        {
            _adminDal.Delete(t);
        }

        public void TUpdate(Admin t)
        {
            _adminDal.Update(t);
        }

        public List<Admin> TGetList()
        {
            return new List<Admin>();
        }

        public Admin TGetById(int id)
        {
            return _adminDal.GetByID(id);
        }
    }
}

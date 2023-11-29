using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            this.adminDal = adminDal;
        }
        public void Tadd(Admin t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Admin t)
        {
            throw new NotImplementedException();
        }

        public Admin TgetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> TgetList()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(Admin t)
        {
            throw new NotImplementedException();
        }
    }
}

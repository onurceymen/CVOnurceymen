using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfAdminDal : Repository<Admin>, IAdminDal
    {
        public EfAdminDal(CvProjectDbContext projectDbContext) : base(projectDbContext)
        {
        }
    }
}

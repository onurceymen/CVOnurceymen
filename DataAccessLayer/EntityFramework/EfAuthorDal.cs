using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfAuthorDal : Repository<Author>, IAuthorDal
    {
        public EfAuthorDal(CvProjectDbContext projectDbContext) : base(projectDbContext)
        {
        }
    }
}

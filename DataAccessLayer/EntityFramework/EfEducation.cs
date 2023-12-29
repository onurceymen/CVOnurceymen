using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfEducation : Repository<Education>, IEducationDal
{
    public EfEducation(CvProjectDbContext projectDbContext) : base(projectDbContext)
    {
    }
}
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfProjectDal : Repository<Project>, IProjectDal
{
    public EfProjectDal(CvProjectDbContext projectDbContext) : base(projectDbContext)
    {
    }
}
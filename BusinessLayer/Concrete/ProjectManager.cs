using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ProjectManager : IProjectService
{
    private IProjectDal _projectDal;

    public ProjectManager(IProjectDal projectDal)
    {
        _projectDal = projectDal;
    }

    public void TAdd(Project t)
    {
        throw new NotImplementedException();
    }

    public void TDelete(Project t)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(Project t)
    {
        throw new NotImplementedException();
    }

    public List<Project> TGetList()
    {
        throw new NotImplementedException();
    }

    public Project TGetById(int id)
    {
        throw new NotImplementedException();
    }
}
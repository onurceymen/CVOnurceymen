using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ProjectManager : IProjectService
{
    IProjectDal _projectDal;
    
    public ProjectManager()
    {
    }

    public void Tadd(Project t)
    {
        throw new NotImplementedException();
    }

    public void Tdelete(Project t)
    {
        throw new NotImplementedException();
    }

    public void Tupdate(Project t)
    {
        throw new NotImplementedException();
    }

    public List<Project> TgetList()
    {
        throw new NotImplementedException();
    }

    public Project TgetById(int id)
    {
        throw new NotImplementedException();
    }
}
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class EducationManager : IEducationService
{
    IEducationDal EducationDal;

    public void TAdd(Education t)
    {
        throw new NotImplementedException();
    }

    public void TDelete(Education t)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(Education t)
    {
        throw new NotImplementedException();
    }

    public List<Education> TGetList()
    {
        throw new NotImplementedException();
    }

    public Education TGetById(int id)
    {
        throw new NotImplementedException();
    }
}
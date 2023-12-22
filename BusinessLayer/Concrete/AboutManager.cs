using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal aboutdal;
        Repository<About> repoAbout = new Repository<About>();

        public AboutManager(IAboutDal aboutdal)
        {
            this.aboutdal = aboutdal;
        }
        public void Tadd(About t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(About t)
        {
            throw new NotImplementedException();
        }

        public About TgetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TgetList()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}

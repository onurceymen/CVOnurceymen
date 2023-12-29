using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
        private void UpdateAboutInDatabase(About about)
        {
            var existingAbout = _aboutDal.GetByID(about.ID);

            if (existingAbout != null)
            {
                existingAbout.Name = about.Name;
                existingAbout.Surname = about.Surname;
                existingAbout.Content1 = about.Content1;
                existingAbout.Content2 = about.Content2;
                existingAbout.Image1 = about.Image1;
                existingAbout.Image2 = about.Image2;

                _aboutDal.Update(existingAbout);
            }
        }

        public List<About> TGetList()
        {
            return _aboutDal.List();
           //return new List<About>();
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetByID(id);
        }
    }
}

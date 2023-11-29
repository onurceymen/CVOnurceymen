using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            this.authorDal = authorDal;
        }
        public void Tadd(Author t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Author t)
        {
            throw new NotImplementedException();
        }

        public Author TgetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Author> TgetList()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(Author t)
        {
            throw new NotImplementedException();
        }
    }
}

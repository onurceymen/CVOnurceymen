using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal authorDal;


        public void TAdd(Author t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Author t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Author t)
        {
            throw new NotImplementedException();
        }

        public List<Author> TGetList()
        {
            throw new NotImplementedException();
        }

        public Author TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

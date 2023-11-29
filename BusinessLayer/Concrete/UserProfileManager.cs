using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;


namespace BusinessLayer.Concrete
{
    public class UserProfileManager
    {
        Repository<Author> repoAuthor = new Repository<Author>();
        public List<Author> GetAuthorByMail(string mail)
        {
            return repoAuthor.List(x => x.Mail == mail);
        }
    }
}

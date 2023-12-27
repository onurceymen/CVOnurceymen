using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void TAdd(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void TDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void TUpdate(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> TGetList()
        {
            return new List<Blog>();
        }

        public Blog TGetById(int id)
        {
            return _blogDal.GetByID(id);
        }
    }
}
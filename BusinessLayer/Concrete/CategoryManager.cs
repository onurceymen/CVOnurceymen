using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;


namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TAdd(Category t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Category t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> TGetList()
        {
            throw new NotImplementedException();
        }

        public Category TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

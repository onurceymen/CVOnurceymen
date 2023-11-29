using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;


        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }
        public void Tadd(Category t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Category t)
        {
            throw new NotImplementedException();
        }

        public Category TgetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> TgetList()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(Category t)
        {
            throw new NotImplementedException();
        }
    }
}

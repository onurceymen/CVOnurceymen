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
    public class BlogManager : IBlogService
    {
        IBlogDal blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            this.blogDal = blogDal;
        }

        public void Tadd(Blog t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Blog t)
        {
            throw new NotImplementedException();
        }

        public Blog TgetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> TgetList()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(Blog t)
        {
            throw new NotImplementedException();
        }
    }
}

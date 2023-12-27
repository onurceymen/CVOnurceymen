using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        T GetByID(int id);
        List<T> List(Expression<Func<T, bool>> where);
        T Find(Expression<Func<T, bool>> where);
    }
}

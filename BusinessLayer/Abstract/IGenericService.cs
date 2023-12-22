namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Tadd(T t);
        void Tdelete(T t);
        void Tupdate(T t);
        List<T> TgetList();
        T TgetById(int id);
    }
}

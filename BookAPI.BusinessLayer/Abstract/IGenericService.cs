using System.Linq.Expressions;

namespace BookAPI.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetByID(int id);
        List<T> TGetListByFilter(Expression<Func<T, bool>> filter);
    }
} 
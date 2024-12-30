using BookAPI.BusinessLayer.Abstract;
using BookAPI.DataAccessLayer.Abstract;
using BookAPI.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BookAPI.BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        private readonly IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void TDelete(Writer t)
        {
            _writerDal.Delete(t);
        }

        public Writer TGetByID(int id)
        {
            return _writerDal.GetByID(id);
        }

        public List<Writer> TGetList()
        {
            return _writerDal.GetList();
        }

        public List<Writer> TGetListByFilter(Expression<Func<Writer, bool>> filter)
        {
            return _writerDal.GetListByFilter(filter);
        }

        public void TInsert(Writer t)
        {
            _writerDal.Insert(t);
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }

        public List<Writer> TGetWriterWithBooks()
        {
            return _writerDal.GetList();
        }
    }
} 
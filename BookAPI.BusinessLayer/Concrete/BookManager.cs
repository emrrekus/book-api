using BookAPI.BusinessLayer.Abstract;
using BookAPI.DataAccessLayer.Abstract;
using BookAPI.EntityLayer.Concrete;
using BookAPI.DataAccessLayer.Dtos;
using System.Linq.Expressions;

namespace BookAPI.BusinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void TDelete(Book t)
        {
            _bookDal.Delete(t);
        }

        public Book TGetByID(int id)
        {
            return _bookDal.GetByID(id);
        }

        public List<Book> TGetList()
        {
            return _bookDal.GetList();
        }

        public List<Book> TGetListByFilter(Expression<Func<Book, bool>> filter)
        {
            return _bookDal.GetListByFilter(filter);
        }

        public void TInsert(Book t)
        {
            _bookDal.Insert(t);
        }

        public void TUpdate(Book t)
        {
            _bookDal.Update(t);
        }

        public List<Book> TGetBookWithCategory()
        {
            return _bookDal.GetList();
        }

        public List<Book> TGetBookWithWriter()
        {
            return _bookDal.GetList();
        }

        public List<ResultBookDto> TGetLast4Book()
        {
            return _bookDal.GetLast4Book();
        }

        public ResultBookDto TRandomBook()
        {
            return _bookDal.RandomBook();
        }

        public List<ResultBookDto> TGetBookByCategory()
        {
            return _bookDal.GetBookByCategory();
        }
    }
} 
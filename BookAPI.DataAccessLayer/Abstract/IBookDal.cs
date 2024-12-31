using BookAPI.EntityLayer.Concrete;
using BookAPI.DataAccessLayer.Dtos;

namespace BookAPI.DataAccessLayer.Abstract
{
    public interface IBookDal : IGenericDal<Book>
    {
        List<ResultBookDto> GetLast4Book();

        ResultBookDto RandomBook();

        List<ResultBookDto> GetBookByCategory();
    }
} 
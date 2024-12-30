using BookAPI.EntityLayer.Concrete;
using BookAPI.DataAccessLayer.Dtos;
namespace BookAPI.BusinessLayer.Abstract
{
    public interface IBookService : IGenericService<Book>
    {
        List<Book> TGetBookWithCategory();
        List<Book> TGetBookWithWriter();
        List<ResultBookDto> TGetLast4Book();

        ResultBookDto TRandomBook();
    }
} 
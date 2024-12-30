using BookAPI.EntityLayer.Concrete;

namespace BookAPI.BusinessLayer.Abstract
{
    public interface IBookService : IGenericService<Book>
    {
        List<Book> TGetBookWithCategory();
        List<Book> TGetBookWithWriter();
    }
} 
using BookAPI.EntityLayer.Concrete;

namespace BookAPI.BusinessLayer.Abstract
{
    public interface IWriterService : IGenericService<Writer>
    {
        List<Writer> TGetWriterWithBooks();
    }
} 
using BookAPI.EntityLayer.Concrete;

namespace BookAPI.BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        List<Category> TGetCategoryWithBooks();
    }
} 
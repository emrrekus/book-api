using BookAPI.DataAccessLayer.Abstract;
using BookAPI.DataAccessLayer.Context;
using BookAPI.DataAccessLayer.Repository;
using BookAPI.EntityLayer.Concrete;

namespace BookAPI.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(BookContext context) : base(context)
        {
        }
    }
} 
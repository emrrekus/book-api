using BookAPI.DataAccessLayer.Abstract;
using BookAPI.DataAccessLayer.Context;
using BookAPI.DataAccessLayer.Repository;
using BookAPI.EntityLayer.Concrete;

namespace BookAPI.DataAccessLayer.EntityFramework
{
    public class EfBookDal : GenericRepository<Book>, IBookDal
    {
        public EfBookDal(BookContext context) : base(context)
        {
        }
    }
} 
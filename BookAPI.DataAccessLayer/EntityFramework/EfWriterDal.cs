using BookAPI.DataAccessLayer.Abstract;
using BookAPI.DataAccessLayer.Context;
using BookAPI.DataAccessLayer.Repository;
using BookAPI.EntityLayer.Concrete;

namespace BookAPI.DataAccessLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        public EfWriterDal(BookContext context) : base(context)
        {
        }
    }
} 
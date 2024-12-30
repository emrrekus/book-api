using BookAPI.DataAccessLayer.Abstract;
using BookAPI.DataAccessLayer.Context;
using BookAPI.DataAccessLayer.Repository;
using BookAPI.EntityLayer.Concrete;

namespace BookAPI.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(BookContext context) : base(context)
        {
        }
    }
} 
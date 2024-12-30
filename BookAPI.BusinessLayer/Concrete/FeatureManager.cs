using BookAPI.BusinessLayer.Abstract;
using BookAPI.DataAccessLayer.Abstract;
using BookAPI.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BookAPI.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public Feature TGetByID(int id)
        {
            return _featureDal.GetByID(id);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public List<Feature> TGetListByFilter(Expression<Func<Feature, bool>> filter)
        {
            return _featureDal.GetListByFilter(filter);
        }

        public void TInsert(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
} 
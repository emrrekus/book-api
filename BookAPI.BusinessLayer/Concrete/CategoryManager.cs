using BookAPI.BusinessLayer.Abstract;
using BookAPI.DataAccessLayer.Abstract;
using BookAPI.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BookAPI.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public List<Category> TGetListByFilter(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.GetListByFilter(filter);
        }

        public void TInsert(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }

        public List<Category> TGetCategoryWithBooks()
        {
            return _categoryDal.GetList();
        }
    }
} 
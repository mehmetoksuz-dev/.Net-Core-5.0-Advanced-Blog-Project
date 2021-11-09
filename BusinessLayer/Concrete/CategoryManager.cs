using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //business katmanında conctrete içerisinde yer alan class'lar "manager" olarak adlandırılıyor.
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal) //constructor method 
        {
            _categoryDal = categoryDal;
        }

        //public void CategoryAdd(Category category) comment oldu çünkü statik bir yapı vardı.
        //{
        //    _categoryDal.Insert(category);
        //}

        //public void CategoryDelete(Category category)
        //{
        //    _categoryDal.Delete(category);
        //}

        //public void CategoryUpdate(Category category)
        //{
        //    _categoryDal.Update(category);
        //}

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}

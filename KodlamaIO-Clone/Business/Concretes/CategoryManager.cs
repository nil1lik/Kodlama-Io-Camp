﻿using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(x => x.Id == id);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList().ToList();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}

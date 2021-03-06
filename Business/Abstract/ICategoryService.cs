using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);
        public void Add(Category category);
        


    }
}

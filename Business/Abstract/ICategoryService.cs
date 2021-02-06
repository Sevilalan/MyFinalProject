using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //category ile ilgili dış dünyaya neyi servis etmek istiyorsam 
  public  interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}

﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IProductService
    {
       IDataResult< List<Product>> GetAll();
       IDataResult< List<Product>> GetAllByCategoryId(int id);
       IDataResult< List<Product>> GetByUnitPrice(decimal min, decimal max);
       IDataResult<List<ProductDetailDto>> GetProductDetails();
       IDataResult< Product> GetById(int productId); //tek başına bir ürün döndürür örneğin bir ürünün detayını istiyorum sadece o ürünün detayını veririr.

       IResult Add(Product product);
    }
}

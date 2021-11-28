﻿using NetCoreMvcMicroservice.Models;
using System.Collections.Generic;

namespace NetCoreMvcMicroservice.Repository
{
  public interface IProductRepository
  {
    IEnumerable<Product> GetProducts();
    Product GetProductByID(int product);
    void InsertProduct(Product product);
    void DeleteProduct(int productId);
    void UpdateProduct(Product product);
    void Save();
  }
}

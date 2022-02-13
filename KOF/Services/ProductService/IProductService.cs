using KOF.DTO_S;
using KOF.Models;
using KOF.Services.GenericService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Services.ProductService
{
    public interface IProductService : IGenericRepository<Product>
    {
        Task<string> CreateProduct(ProductDto dto);
        Task<object> GetProducts();
        Task<string> UpdateProduct(ProductDto dto);

  
    }
}

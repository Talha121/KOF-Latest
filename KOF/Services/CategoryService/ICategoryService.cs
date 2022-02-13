using KOF.DTO_S;
using KOF.Models;
using KOF.Services.GenericService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Services.CategoryService
{
    public interface ICategoryService: IGenericRepository<Category>
    {
        Task<string> UploadCategory(CategoreyDto dto);
        Task<string> UpdateCategory(CategoreyDto dto);
        Task<string> updateCategoryImage(CategoreyDto dto);


    }
}

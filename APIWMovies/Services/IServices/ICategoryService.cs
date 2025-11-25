using API.P.Movies.Controllers;
using APIWMovies.DAL.Models;
using APIWMovies.DAL.Models.Dtos;

namespace APIWMovies.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync(); 
        Task<CategoryDto> GetCategoryAsync(int id);
        Task<CategoryDto> CreateCategoryAsync(DAL.Models.Dtos.CategoryCreateUpdateDto categoryDto);
        Task<CategoryDto> UpdateCategoryAsync(DAL.Models.Dtos.CategoryCreateUpdateDto dto, int id); 
        Task<bool> DeleteCategoryAsync(int id);
        Task<bool> CategoryExistsByIdAsync(int id);
        Task<bool> CategoryExistsByNameAsync(string name);
        Task CreateCategoryAsync(API.P.Movies.Controllers.CategoryCreateUpdateDto categoryCreateDto);
    }
}

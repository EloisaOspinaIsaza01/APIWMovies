using APIWMovies.DAL.Models;
using APIWMovies.DAL.Models.Dtos;

namespace APIWMovies.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync(); 
        Task<CategoryDto> GetCategoryAsync(int id); 
        Task<bool> CategoryExistsByIdAsync(int id); 
        Task<bool> CategoryExistsByNameAsync(string name); 
        Task<CategoryDto> CreateCategoryAsync(CategoryCreateDto categoryCreateDto); 
        Task<bool> UpdateCategoryAsync(Category category); 
        Task<bool> DeleteCategoryAsync(int id);
    }
}

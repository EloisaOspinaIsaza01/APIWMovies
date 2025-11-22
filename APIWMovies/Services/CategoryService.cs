using APIWMovies.DAL.Models;
using APIWMovies.DAL.Models.Dtos;
using APIWMovies.Repository.IRepository;
using APIWMovies.Services.IServices;
using AutoMapper;

namespace APIWMovies.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper) 
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public Task<bool> CategoryExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CategoryExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CategoryDto>> GetCategoriesAsync()
        {
            var categories = _categoryRepository.GetCategoriesAsync(); //Solo estoy llamando el mètodo desde la capa de Repository

            return _mapper.Map<ICollection<CategoryDto>>(categories); //Mapeo la lista de categorias a una lista de categorias DTO
        }
        public Task<bool> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        Task<CategoryDto> ICategoryService.GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

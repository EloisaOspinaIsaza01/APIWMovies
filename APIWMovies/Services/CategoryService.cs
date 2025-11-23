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

        public async Task<bool> CategoryExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CategoryExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryDto> CreateCategoryAsync(CategoryCreateDto categoryCreateDto)
        {
            var categoryExists = await _categoryRepository.CategoryExistsByNameAsync(categoryCreateDto.Name);

            if (categoryExists)
            {
                throw new InvalidOperationException($"Ya existe una categorìa con el nombre de '{categoryCreateDto.Name}'");
            }

            //Mapear el DTO a la entidad   
            var category = _mapper.Map<Category>(categoryCreateDto);

            //Crear la categorìa en el repositorio
            var categoryCreated = await _categoryRepository.CreateCategoryAsync(category);

                if (!categoryCreated)
                {
                    throw new Exception("Ocurriò un error al crear la categorìa");
                }

                //Mapear la entidad creada a DTO
                return _mapper.Map<CategoryDto>(category);
            }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CategoryDto>> GetCategoriesAsync()
        {
            //obtener las catagorìas del repositorio
            var categories = await _categoryRepository.GetCategoriesAsync();

            //Mapear toda la colecciòn de una vez
            return _mapper.Map<ICollection<CategoryDto>>(categories);
        }


        public async Task<CategoryDto> GetCategoryAsync(int id)
        {
            //obtener la catagorìa del repositorio
            var category = await _categoryRepository.GetCategoryAsync(id);

            //Mapear toda la colecciòn de una vez
            return _mapper.Map<CategoryDto> (category);
        }

        public Task<CategoryDto> UpdateCategoryAsync(int id, Category categoryDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}

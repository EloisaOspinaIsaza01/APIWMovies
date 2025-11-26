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

        public async Task<CategoryDto> CreateCategoryAsync(CategoryCreateUpdateDto categoryCreateDto)
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

        public Task CreateCategoryAsync(API.P.Movies.Controllers.CategoryCreateUpdateDto categoryCreateDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            //Verificar si la categoria existe
            var categoryExists = await _categoryRepository.GetCategoryAsync(id);

            if (categoryExists == null)
            {
                throw new InvalidOperationException($"No se encontrò la categorìa con ID: '{id}'");
            }

            //Eliminar la categorìa del repositorio
            var categoryDeleted = await _categoryRepository.DeleteCategoryAsync(id);
            
            if (!categoryDeleted)
            {
                throw new Exception("Ocurriò un error al eliminar la categorìa.");
            }
            return categoryDeleted;
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

            if (category == null)
            {
                throw new InvalidOperationException($"No se encontrò la categoria con ID '{id}'");
            }

            //Mapear toda la colecciòn de una vez
            return _mapper.Map<CategoryDto> (category);
        }

        public async Task<CategoryDto> UpdateCategoryAsync(CategoryCreateUpdateDto dto, int id)
        {
            //Validar se la catagoria ya existe
            var categoryExists = await _categoryRepository.GetCategoryAsync(id);

            if (categoryExists == null)
            {
                throw new InvalidOperationException($"No se encontrò la categoria con ID '{id}'");
            }

            var nameExists = await _categoryRepository.CategoryExistsByNameAsync(dto.Name);

            if (nameExists)
            {
                throw new InvalidOperationException($"Ya existe una categorìa con el nombre de '{dto.Name}'");
            }

            //Mapear el DTO a la entidad   
            _mapper.Map(dto, categoryExists);

            //Actualizamos la categoria en el repositorio
            var categoryUpdated = await _categoryRepository.UpdateCategoryAsync(categoryExists);

            if (!categoryUpdated)
            {
                throw new Exception("Ocurriò un error al actualizar la categorìa");
            }

            //Retornar el DTO actualizado
            return _mapper.Map<CategoryDto>(categoryExists);
        }
    }
}

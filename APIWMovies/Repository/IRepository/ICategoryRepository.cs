using APIWMovies.DAL.Models;

namespace APIWMovies.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task <ICollection<Category>> GetCategoriesAsync(); //Me retorna UNA LISTA DE CATEGORIAS
        Task<Category> GetCategoryAsync(int id); //Me retorna Una Categoria POR ID
        Task<bool> CategoryExistsByIdAsync(int id); //Me dice si existe una categoria por ID
        Task<bool> CategoryExistsByNameAsync(string name); //Me dice si existe una categoria por Nombre
        Task<bool> CreateCategoryAsync(Category category); //Me crea una categoria
        Task<bool> UpdateCategoryAsync(Category category); //Me crea una categoria --piedo actualizar el nombre y la fecha de actualizaciòn
        Task<bool> DeleteCategoryAsync(int id); //Me elimina una categoria
    }
}

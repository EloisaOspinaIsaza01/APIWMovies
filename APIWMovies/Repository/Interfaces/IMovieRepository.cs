using APIWMovies.DAL.Models;

namespace APIWMovies.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<ICollection<Movie>> GetMoviesAsync();                     //Lista de Movies
        Task<Movie?> GetMovieAsync(int id);                            //Una Movie por ID
        Task<bool> MovieExistsByIdAsync(int id);                       //Existe Movie por ID
        Task<bool> MovieExistsByNameAsync(string name);                //Existe Movie por Nombre
        Task<bool> CreateMovieAsync(Movie movie);                      //Crear Movie
        Task<bool> UpdateMovieAsync(Movie movie);                      //Actualizar Movie
        Task<bool> DeleteMovieAsync(int id);                           //Eliminar Movie
    }
}

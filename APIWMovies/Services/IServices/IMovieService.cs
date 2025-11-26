using API.W.Movies.DAL.Models.Dtos;

namespace API.W.Movies.Services.IServices
{
    public interface IMovieService
    {
        Task<bool> MovieExistsByIdAsync(int id);
        Task<bool> MovieExistsByNameAsync(string name);

        Task<MovieDto> CreateMovieAsync(MovieCreateDto movieCreateDto);
        Task<ICollection<MovieDto>> GetMoviesAsync();
        Task<MovieDto> GetMovieAsync(int id);

        Task<MovieDto> UpdateMovieAsync(MovieUpdateDto movieUpdateDto, int id);
        Task<bool> DeleteMovieAsync(int id);
    }
}
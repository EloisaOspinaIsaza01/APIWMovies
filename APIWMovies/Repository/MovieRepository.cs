using API.W.Movies.DAL;
using API.W.Movies.DAL.Models;
using API.W.Movies.Repository.IRepository;
using APIWMovies.DAL;
using Microsoft.EntityFrameworkCore;

namespace API.W.Movies.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _db;

        public MovieRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> CreateMovieAsync(Movie movie)
        {
            await _db.Movies.AddAsync(movie);
            return await SaveAsync();
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movie = await _db.Movies.FindAsync(id);
            if (movie == null)
                return false;

            _db.Movies.Remove(movie);
            return await SaveAsync();
        }

        public async Task<Movie?> GetMovieAsync(int id)
        {
            return await _db.Movies
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<Movie>> GetMoviesAsync()
        {
            return await _db.Movies
                .AsNoTracking()
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task<bool> MovieExistsByIdAsync(int id)
        {
            return await _db.Movies.AnyAsync(x => x.Id == id);
        }

        public async Task<bool> MovieExistsByNameAsync(string name)
        {
            return await _db.Movies
                .AnyAsync(x => x.Name.ToLower() == name.ToLower());
        }

        public async Task<bool> UpdateMovieAsync(Movie movie)
        {
            _db.Movies.Update(movie);
            return await SaveAsync();
        }

        public async Task<bool> SaveAsync()
        {
            return await _db.SaveChangesAsync() > 0;
        }
    }
}
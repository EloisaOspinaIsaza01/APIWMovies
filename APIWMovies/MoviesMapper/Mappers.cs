using API.W.Movies.Controllers;
using API.W.Movies.DAL.Models;
using API.W.Movies.DAL.Models.Dtos;
using AutoMapper;

using APIWMovies.DAL.Models;
using APIWMovies.DAL.Models.Dtos;
using AutoMapper;

namespace APIWMovies.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            // Category
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap <Category, CategoryCreateUpdateDto>().ReverseMap();

            // Movies
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<MovieCreateDto, Movie>().ReverseMap();
            CreateMap<MovieUpdateDto, Movie>().ReverseMap();
        }
    }
}

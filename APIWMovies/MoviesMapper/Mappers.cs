using APIWMovies.DAL.Models;
using APIWMovies.DAL.Models.Dtos;
using AutoMapper;

namespace APIWMovies.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap <Category, CategoryCreateDto>().ReverseMap();
        }
    }
}

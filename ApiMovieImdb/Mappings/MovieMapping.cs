using ApiMovieImdb.Dtos;
using ApiMovieImdb.Models;
using AutoMapper;

namespace ApiMovieImdb.Mappings
{
    public class MovieMapping : Profile
    {
        public MovieMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<MovieResponse, Movie>();
            CreateMap<Movie, MovieResponse>();
        }
        
    }
}
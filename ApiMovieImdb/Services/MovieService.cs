using ApiMovieImdb.Dtos;
using ApiMovieImdb.Interfaces;
using AutoMapper;

namespace ApiMovieImdb.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMapper _mapper;
        private readonly IOmdbApi _omdbApi;

        public MovieService(IMapper mapper, IOmdbApi omdbApi)
        {
            _mapper = mapper;
            _omdbApi = omdbApi;
        }

        public async Task<ResponseGenerico<MovieResponse>> BuscarFilme(string filme, string apiKey)
        {
            var tituloFilme = await _omdbApi.BuscarFilme(filme, apiKey);
            return _mapper.Map<ResponseGenerico<MovieResponse>>(tituloFilme);
        }

    }
}
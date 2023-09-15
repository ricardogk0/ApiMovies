using ApiMovieImdb.Dtos;
using ApiMovieImdb.Models;

namespace ApiMovieImdb.Interfaces
{
    public interface IOmdbApi
    {
        Task<ResponseGenerico<Movie>> BuscarFilme(string filme, string apiKey);
    }
}
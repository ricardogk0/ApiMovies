using ApiMovieImdb.Dtos;

namespace ApiMovieImdb.Interfaces
{
    public interface IMovieService
    {
        Task<ResponseGenerico<MovieResponse>> BuscarFilme(string filme, string apiKey);
    }
}
using System.Dynamic;
using System.Text.Json;
using ApiMovieImdb.Dtos;
using ApiMovieImdb.Interfaces;
using ApiMovieImdb.Models;

namespace ApiMovieImdb.Rest
{
    public class MovieRest : IOmdbApi
    {
        public async Task<ResponseGenerico<Movie>> BuscarFilme(string filme, string apiKey)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"http://www.omdbapi.com/?t={filme}&apikey={apiKey}");
            var response = new ResponseGenerico<Movie>();

            using (var client = new HttpClient())
            {
                var responseMovieApi = await client.SendAsync(request);
                var contentResponse = await responseMovieApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<Movie>(contentResponse);

                if(responseMovieApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseMovieApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseMovieApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }

                return response;
            }
        }

    }
}
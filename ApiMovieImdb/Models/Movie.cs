using System.Text.Json.Serialization;

namespace ApiMovieImdb.Models
{
    public class Movie
    {
        [JsonPropertyName("Title")]
        public string? Titulo { get; set; }

        [JsonPropertyName("Year")]
        public string? Ano { get; set; }

        [JsonPropertyName("Released")]
        public string? Lancamento { get; set; }

        [JsonPropertyName("Runtime")]
        public string? Duracao { get; set; }

        [JsonPropertyName("Genre")]
        public string? Genero { get; set; }
    }
}
using System.Net;
using ApiMovieImdb.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiMovieImdb.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MovieController : ControllerBase
    {
        public readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("buscar/{filme}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarFilme(string filme, string apiKey)
        {
            var response = await _movieService.BuscarFilme(filme, apiKey);

            if(response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }        
        }

    }
}
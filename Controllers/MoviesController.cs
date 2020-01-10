using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        // GET: api/Movies
        [HttpGet]
        public string Get()
        {
            MovieLista listaFilmes = new MovieLista();
            GenList listaGeneros = new GenList().Listar();
            List<Movie> filmes = new List<Movie>();
            int paging = 1;
            int totalPages = 0;

            do
            {
                MovieList upCMovies = listaFilmes.Listar(paging);
                paging = upCMovies.page;
                totalPages = upCMovies.total_pages;
                foreach (var movie in upCMovies.results)
                {
                    Movie filme = new Movie()
                    {
                        title = movie.title,
                        release_date = movie.release_date,
                        genre = new List<string>()
                    };
                    foreach (int genreId in movie.genre_ids)
                    {
                        filme.genre.Add(listaGeneros.genres.Where(g => g.id == genreId).First().name);
                    }

                    filmes.Add(filme);
                }
                paging++;
            } while (paging != totalPages + 1);

            return JsonConvert.SerializeObject(filmes);
        }
    }
}

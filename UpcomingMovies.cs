using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MovieAPI
{
    public class Result
    {
        public double popularity { get; set; }
        public int vote_count { get; set; }
        public bool video { get; set; }
        public string poster_path { get; set; }
        public int id { get; set; }
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public List<int> genre_ids { get; set; }
        public string title { get; set; }
        public double vote_average { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
    }

    public class Dates
    {
        public string maximum { get; set; }
        public string minimum { get; set; }
    }

    public class MovieList
    {
        public List<Result> results { get; set; }
        public int page { get; set; }
        public int total_results { get; set; }
        public Dates dates { get; set; }
        public int total_pages { get; set; }
    }

    public class MovieLista
    {
        public MovieList Listar(int page)
        {
            WebClient client = new WebClient();
            string moviesUrl = "https://api.themoviedb.org/3/movie/upcoming?api_key=4c14e0872bc2ea913558b543d1f576a7&page=" + page;

            Stream dataMovie = client.OpenRead(moviesUrl);
            StreamReader readerMovie = new StreamReader(dataMovie);
            string movieJson = readerMovie.ReadToEnd();
            dataMovie.Close();
            readerMovie.Close();

            return JsonConvert.DeserializeObject<MovieList>(movieJson);
        }
    }
}

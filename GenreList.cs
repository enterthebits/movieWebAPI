using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MovieAPI
{
    public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class GenList
    {
        public List<Genre> genres { get; set; }
        
        public GenList Listar()
        {

            var client = new WebClient();
            var genresUrl = "https://api.themoviedb.org/3/genre/movie/list?api_key=4c14e0872bc2ea913558b543d1f576a7";


            Stream dataGenre = client.OpenRead(genresUrl);
            StreamReader readerGenre = new StreamReader(dataGenre);
            string genreJson = readerGenre.ReadToEnd();
            dataGenre.Close();
            readerGenre.Close();

            return JsonConvert.DeserializeObject<GenList>(genreJson);
        }
        
    }
}

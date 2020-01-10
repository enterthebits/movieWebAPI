using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI
{
    public class Movie
    {
        public string title { get; set; }
        public List<string> genre { get; set; }
        public string release_date { get; set; }
    }
}

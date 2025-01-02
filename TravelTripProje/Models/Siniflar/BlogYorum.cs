using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; } = new List<Blog>();
        public IEnumerable<Yorumlar> Deger2 { get; set; } = new List<Yorumlar>();
        public IEnumerable<Blog> Deger3 { get; set; } = new List<Blog>();

    }
}
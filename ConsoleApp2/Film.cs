using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Film
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Actors { get; set; }

        public Film(string title, string director, List<string> actors)
        {
            Title = title;
            Director = director;
            Actors = actors;
        }

        public override string ToString()
        {
            return $"Название: {Title}, Режиссер {Director}, В главной роли: {string.Join(", ", Actors)}";
        }
    }
}

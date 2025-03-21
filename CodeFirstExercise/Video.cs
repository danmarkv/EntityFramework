using System;
using System.Collections.Generic;

namespace CodeFirstExercise
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Genre> Genres { get; set; }
    }
}

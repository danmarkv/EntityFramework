using System.Collections.Generic;

namespace CodeFirstExercise
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Video> Videos { get; set; }
    }
}

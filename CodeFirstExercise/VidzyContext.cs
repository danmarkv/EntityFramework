using System.Data.Entity;

namespace CodeFirstExercise
{
    public class VidzyContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public VidzyContext()
            : base("VidzyConnection")
        {

        }
    }
}

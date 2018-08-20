namespace VasyanFilms
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Vasyan : DbContext
    {
        public Vasyan()
            : base("name=VasyanString")  // connection string
        {
        }


        virtual public DbSet<Genre> Genres { get; set; }
        virtual public DbSet<Actor> Actors { get; set; }
        virtual public DbSet<Film> Films { get; set; }

    }
}
namespace VasyanFilms.Context
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

    }
}
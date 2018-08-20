using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyanFilms
{
    public class Film
    {
        public Film()
        {
            Actors = new List<Actor>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Score { get; set; }


        //navigation
        virtual public Genre Genre { get; set; }
        virtual public List<Actor> Actors { get; set; }

    }
}
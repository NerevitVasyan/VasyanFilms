using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyanFilms
{
    public class Genre
    {

        public Genre()
        {
            Films = new List<Film>();
        }

        public int ID { get; set; }
        public string NameGenre { get; set; }



        //navigation
        virtual public List<Film> Films { get; set; }
    }
}

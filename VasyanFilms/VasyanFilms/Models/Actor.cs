using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyanFilms
{
    public class Actor
    {

        public Actor()
        {
            Films = new List<Film>();
        }

        public int ID { get; set; }
        public string NameActor { get; set; }

        //navigation
        virtual public List<Film> Films { get; set; }
    }
}

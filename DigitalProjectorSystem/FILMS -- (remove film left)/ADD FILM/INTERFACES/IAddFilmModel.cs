using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProjectorSystem.FILMS.ADD_FILM.INTERFACES
{
    interface IAddFilmModel
    {
        bool AddFilm(string Title, string Genre, int RunningTime, int Rating);
    }
}

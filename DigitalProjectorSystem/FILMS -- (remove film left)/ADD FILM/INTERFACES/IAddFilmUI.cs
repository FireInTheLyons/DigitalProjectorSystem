using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProjectorSystem.FILMS.ADD_FILM.INTERFACES
{
    interface IAddFilmUI
    {

        string FilmTitle { get; }
        string FilmGenre { get; }
        int FilmRating { get; } 
        int FilmRunningTime { get; }
        bool Status { get; }

        void ShowError(Exception ex);
    }
}

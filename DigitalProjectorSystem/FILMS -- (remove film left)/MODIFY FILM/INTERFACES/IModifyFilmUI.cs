using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProjectorSystem.FILMS.MODIFY_FILM.INTERFACES
{
    interface IModifyFilmUI
    {
        string SearchTerm { get; }
        string SearchColumn { get; }
        string FilmID { get; }
        string FilmTitle { get; }
        string FilmGenre { get; }
        string FilmRating { get; }
        string FilmRunningTime { get; }
        bool Status { get; }

        void ShowError(Exception ex);

    }
}

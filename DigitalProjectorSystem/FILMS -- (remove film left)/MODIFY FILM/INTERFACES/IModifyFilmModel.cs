using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProjectorSystem.FILMS.MODIFY_FILM.INTERFACES
{
    interface IModifyFilmModel
    {
        void ModifyFilm(string FilmID,string Title, string Genre, string RunningTime, string Rating);
        System.Data.DataTable getDataTable(string searchColumn, string searchTerm);
    }
}

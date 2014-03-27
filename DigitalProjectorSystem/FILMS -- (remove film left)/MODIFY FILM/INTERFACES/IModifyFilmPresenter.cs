using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProjectorSystem.FILMS.MODIFY_FILM.INTERFACES
{
    interface IModifyFilmPresenter
    {
        void ModifyFilm();

        System.Data.DataTable getDataTable();
    }

}
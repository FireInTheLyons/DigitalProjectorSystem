using DigitalProjectorSystem.FILMS.MODIFY_FILM.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProjectorSystem.FILMS.MODIFY_FILM.IMPLEMENTATION
{
    class ModifyFilmPresenter : IModifyFilmPresenter
    {

        private  IModifyFilmModel model;
        private  IModifyFilmUI view;

        public ModifyFilmPresenter(ModifyFilmModel m, ModifyFilmUI v)
        {
            
            model = m;
            view = v;
        }



        public void ModifyFilm()
        {
            model.ModifyFilm(view.FilmID,view.FilmTitle, view.FilmGenre, view.FilmRunningTime, view.FilmRating);
        }


        public System.Data.DataTable getDataTable()
        {
            return model.getDataTable(view.SearchColumn, view.SearchTerm);
        }
    }
}

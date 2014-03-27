using DigitalProjectorSystem.FILMS.ADD_FILM.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProjectorSystem.FILMS.ADD_FILM.IMPLEMENTATION
{
    class AddFilmPresenter : IAddFilmPresenter
    {

        private IAddFilmModel model;
        private IAddFilmUI view;
        //This is used to attempt to initialize the presenter
        public AddFilmPresenter(AddFilmModel m, AddFilmUI v)
        {
            
            model = m;
            view = v;
        }
        
        
        //This pulls the relevant details from the VIEW/UI, and sends them down to the model's add screen method
        public void AddFilm()
        {
            model.AddFilm(view.FilmTitle, view.FilmGenre, view.FilmRunningTime, view.FilmRating);
        }
    }
}

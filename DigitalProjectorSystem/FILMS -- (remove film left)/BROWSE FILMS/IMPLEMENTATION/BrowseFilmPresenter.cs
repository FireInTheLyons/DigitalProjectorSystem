using DigitalProjectorSystem.FILMS.BROWSE_FILMS.INTERFACES;
using DigitalProjectorSystem.FILMS.BROWSE_FILMS____MUST_EDIT.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProjectorSystem.FILMS.BROWSE_FILMS____MUST_EDIT.IMPLEMENTATION
{
    class BrowseFilmPresenter : IBrowseFilmPresenter
    {
        private IBrowseFilmModel model;
        private IBrowseFilmUI view;

        public BrowseFilmPresenter(BrowseFilmModel m, BrowseFilmUI v)
        {
            model = m;
            view = v;
        }
        
        
        public System.Data.DataTable getDataTable()
            {
                return model.getDataTable(view.SearchColumn, view.SearchTerm);
            }
    }

}

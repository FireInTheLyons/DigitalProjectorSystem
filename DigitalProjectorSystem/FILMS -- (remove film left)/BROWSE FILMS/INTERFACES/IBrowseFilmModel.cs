using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProjectorSystem.FILMS.BROWSE_FILMS.INTERFACES
{
    interface IBrowseFilmModel
    {
        System.Data.DataTable getDataTable(string SearchColumn, string SearchTerm);
        //return data table

    }
}

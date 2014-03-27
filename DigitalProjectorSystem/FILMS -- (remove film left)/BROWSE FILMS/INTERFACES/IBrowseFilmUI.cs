using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProjectorSystem.FILMS.BROWSE_FILMS____MUST_EDIT.INTERFACES
{
    interface IBrowseFilmUI
    {
        //searchterm & searchcolumn -- because these are properties and not methods...
        // round brackets are not needed.
        //We're getting and setting the properties directly because they're a string and not a method.

        string SearchTerm { get; }
        string SearchColumn { get; }
    }
}

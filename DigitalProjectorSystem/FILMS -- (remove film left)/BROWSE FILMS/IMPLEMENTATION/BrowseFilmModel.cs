using DigitalProjectorSystem.DATABASE_ENGINE;
using DigitalProjectorSystem.FILMS.BROWSE_FILMS.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProjectorSystem.FILMS.BROWSE_FILMS____MUST_EDIT.IMPLEMENTATION
{
    class BrowseFilmModel : IBrowseFilmModel
    {

        private SQLiteHelper helper;

        private System.Data.DataTable dt;

        public BrowseFilmModel()
        {
            helper = new SQLiteHelper();

            dt = new System.Data.DataTable();
        }
        
        
        
        public System.Data.DataTable getDataTable(string SearchColumn, string SearchTerm)
        {
            //first thing... check to see if they're numbers.
            if (SearchColumn == "RunningTime" || SearchColumn == "Rating") 
            
            {
                int validCheck;
                Int32.TryParse(SearchTerm, out validCheck);
                // if valid check is a number, you proceed. if valid check is not a number, it's equal to 0. 
                // if it's 0, then it's searchTerm is null.
                if (validCheck != 0)
                {

                    dt = helper.GetDataTable("SELECT * FROM Film WHERE " + SearchColumn + " = " + SearchTerm + ";");

                }

                else
                {
                    SearchTerm = null;
                }
            }
        
            if (SearchColumn == "Title" || SearchColumn == "Genre")
            {
                dt = helper.GetDataTable("SELECT * FROM Film WHERE " + SearchColumn + " LIKE '%" + SearchTerm + "%';");
            }

            if (SearchColumn == null || SearchColumn == "" || SearchTerm == null || SearchTerm == "")
            {
                dt = helper.GetDataTable("SELECT * From Film;");
            }

            return dt;
        }
    }
}

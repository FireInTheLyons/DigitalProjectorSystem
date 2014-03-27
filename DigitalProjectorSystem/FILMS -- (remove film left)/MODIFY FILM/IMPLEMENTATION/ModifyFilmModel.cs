using DigitalProjectorSystem.DATABASE_ENGINE;
using DigitalProjectorSystem.FILMS.MODIFY_FILM.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalProjectorSystem.FILMS.MODIFY_FILM.IMPLEMENTATION
{
    class ModifyFilmModel : IModifyFilmModel
    {
        private SQLiteHelper helper;

        private System.Data.DataTable dt; 

        public ModifyFilmModel()
        {
            helper = new SQLiteHelper();
        }
           
       

        public System.Data.DataTable getDataTable(string searchColumn, string searchTerm)
        {
            if (searchColumn == "RunningTime" || searchColumn == "Rating"){
                
                int validCheck;
                Int32.TryParse(searchTerm,out validCheck);
                if (validCheck != 0)
                {
                    dt = helper.GetDataTable("SELECT * FROM Film WHERE " + searchColumn + " = " + searchTerm + ";");
                }

                else
                {
                    searchTerm = null;
                }
            
            }

            if (searchColumn == "Title" || searchColumn == "Genre")
            {

                dt = helper.GetDataTable("SELECT * FROM Film WHERE " + searchColumn + " LIKE '%"+searchTerm+"%';");
                

            }
            
            if (searchColumn == null || searchColumn == "" || searchTerm == null || searchTerm == "")
            {
                dt = helper.GetDataTable("SELECT * From Film;");
            }

            return dt;
        }

        public void ModifyFilm(string FilmID, string Title, string Genre, string RunningTime, string Rating)
        {
             string status = "true";
            var data = new Dictionary<String, String>
        {
            {"Title", Title},
            {"Genre", Genre},
            {"RunningTime", RunningTime},
            {"Rating", Rating},
            {"Film_ID",FilmID},
            {"Status", status},
                
        };
            try
            {
                helper.Update("Film", data, "Film_ID = " + FilmID);
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
                
            }
        }
    }
}
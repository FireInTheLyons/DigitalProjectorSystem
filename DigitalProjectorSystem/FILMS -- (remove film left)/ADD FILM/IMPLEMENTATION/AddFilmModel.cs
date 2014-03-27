using DigitalProjectorSystem.DATABASE_ENGINE;
using DigitalProjectorSystem.FILMS.ADD_FILM.INTERFACES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalProjectorSystem.FILMS.ADD_FILM.IMPLEMENTATION
{
    class AddFilmModel : IAddFilmModel
    {
       
        //Initializes the SQLITE  Helper class(the thing that does all the connecting and horse-work), 
        //and the datatable to pass back up to the UI
        private SQLiteHelper helper;
        private DataTable dt;

        public AddFilmModel()
        {
            helper = new SQLiteHelper();
        }
           
        public bool AddFilm(string Title, string Genre, int RunningTime, int Rating)
        {
            
            //checks to see if the table exists, if not, build the table 
            try
            {
                dt = helper.GetDataTable("SELECT * FROM (SELECT name FROM sqlite_master WHERE type='table') WHERE name = 'Film'");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (dt.Rows.Count == 0)
            {
                BuildFilmTable();
            }
            
            
            //puts the contents to be added into a Dictionary: A linked list of two Objects in tandem
            string status = "true";
            var data = new Dictionary<String, String>
        {
            {"Title", Title},
            {"Genre", Genre},
            {"RunningTime", RunningTime.ToString()},
            {"Rating", Rating.ToString()},
            {"Status", status},
                
        };
            //this sends the film name, and the contents to be added down to the helper
            try
            {
                helper.Insert("Film", data);
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
                return false;
            }

            return true;
        }
        //method that builds the table to be used
        private void BuildFilmTable()
        {
           //Creates strings of the various items to be inserted into the 

            const string FilmID = "Film_ID INTEGER PRIMARY KEY AUTOINCREMENT"; // autogen
            const string Title = "Title varchar2(24)";
            const string Genre = "Genre varchar2(30)";
            const string RunningTime = "RunningTime varchar2(40)";
            const string Rating = "Rating varchar2(20)";
            const string Status = "Status varchar(10)";

            helper.ExecuteNonQuery(String.Format("create table Film ({0},{1},{2},{3},{4},{5});", FilmID, Title, Genre, RunningTime, Rating, Status));

        }
    }
}

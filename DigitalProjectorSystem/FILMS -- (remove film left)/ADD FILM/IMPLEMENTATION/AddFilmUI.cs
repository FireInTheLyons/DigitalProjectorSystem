using DigitalProjectorSystem.FILMS.ADD_FILM.INTERFACES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalProjectorSystem.FILMS.ADD_FILM.IMPLEMENTATION
{
    public partial class AddFilmUI : Form, IAddFilmUI
    {

        Films parent;

        public AddFilmUI(Films Parent)
        {
            parent = Parent;

            InitializeComponent();
            //Creates an instance of the Presenter, defining in it which model to use along with which front(this one, in this case)
            Presenter = new AddFilmPresenter(new AddFilmModel(),this);
        }

        private void AddFilmUI_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmAddFilm_Click(object sender, EventArgs e)
        {
            FilmTitle = AddFilmTitle.Text;
            FilmGenre = AddFilmGenre.Text;
           //Attempts to Parse the string from the relevant textbox into INT, as opposed to casting it.
            int FilmRunningTimeConvert = 0;
            if (Int32.TryParse(AddFilmRunningTime.Text, out FilmRunningTimeConvert))
                FilmRunningTime = FilmRunningTimeConvert;

            // FilmRunningTime = (int)AddFilmRunningTime.Text; <- This does not work, casting cannot be done from a string to a number

            int FilmRatingConvert = 0;
            if (Int32.TryParse(AddFilmRating.Text, out FilmRatingConvert))
                FilmRating = FilmRatingConvert;
            //Tells the presenter to go and pass the information down to the model
            Presenter.AddFilm();

        }

        public string FilmTitle
        {
            get;
            set;
        }

        public string FilmGenre
        {
            get;
            set;
        }

        public int FilmRating
        {
            get;
            set;
        }

        public int FilmRunningTime
        {
            get;
            set;
        }

        public bool Status
        {
            get;
            set;
        }

        public void ShowError(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        private void evnButtonClickToFilmsFrmAddFilmUI(object sender, EventArgs e)
        {
            parent.Reshow();
            this.Hide();
            ToConsole.print("Button Clicked to Films From AddFilmUI");
        }

        private void evnButtonClickToConfirmAddFilm(object sender, EventArgs e)
        {
            parent.Reshow();
            this.Hide();
            ToConsole.print("Film Successfully added to the database.");
        }


        internal AddFilmPresenter Presenter { get; set; }

        private void AddFilmUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

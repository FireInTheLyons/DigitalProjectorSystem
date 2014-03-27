using DigitalProjectorSystem.FILMS.BROWSE_FILMS____MUST_EDIT.INTERFACES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalProjectorSystem.FILMS.BROWSE_FILMS____MUST_EDIT.IMPLEMENTATION
{
    public partial class BrowseFilmUI : Form, IBrowseFilmUI
    {
        Films parent;

        private Dictionary<string, string> DictSearchItem;

        public BrowseFilmUI(Films Parent)
        {
            parent = Parent;

            InitializeComponent();
            Presenter = new BrowseFilmPresenter(new BrowseFilmModel(), this);

            DictSearchItem = new Dictionary<string, string>
            {
                {"Film ID", "Film_ID"},
                {"Title", "Title"},
                {"Genre", "Genre"},
                {"Running Time", "RunningTime"},
                {"Rating", "Rating"},
            };

            foreach (var d in DictSearchItem)
            {
                CBXSearchBy.Items.Add(d.Key.ToString());
            }

            CBXSearchBy.SelectedItem = "Title";

            FilmDataTable.DataSource = Presenter.getDataTable();
        }

        public string SearchTerm
        {
            get;
            set;
        }

        public string SearchColumn
        {
            get;
            set;
        }

        private void evnButtonClickToFilmsFromBrowseFilms(object sender, EventArgs e)
        {
            parent.Reshow();
            this.Hide();
            ToConsole.print("Browse Films to Films Button was Clicked.");
        }

        internal BrowseFilmPresenter Presenter { get; set; }

        private void BrowseFilmsUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

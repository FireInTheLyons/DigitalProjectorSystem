using DigitalProjectorSystem.FILMS.MODIFY_FILM.INTERFACES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalProjectorSystem.FILMS.MODIFY_FILM.IMPLEMENTATION
{
    public partial class ModifyFilmUI : Form, IModifyFilmUI
    {

        Films parent;

        private Dictionary<string, string> DictSearchItem;

        public ModifyFilmUI(Films Parent)
        {
            parent = Parent;

            InitializeComponent();
            Presenter = new ModifyFilmPresenter(new ModifyFilmModel(), this);

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

        private void ModifyFilmUI_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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

        public string FilmRating
        {
            get;
            set;
        }

        public string FilmRunningTime
        {
            get;
            set;
        }

        

        public void ShowError(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        private void evnButtonClickToFilmsFrmModifyFilmUI(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Hide();
            ToConsole.print("Button Clicked to Films From ModifyFilmUI");
        }

        internal ModifyFilmPresenter Presenter { get; set; }

        private void ModifyFilmUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ConfirmModifyFilm_Click_1(object sender, EventArgs e)
        {



            FilmTitle = ModifyFilmTitle.Text;
            FilmGenre = ModifyFilmGenre.Text;
            FilmID = ModifyFilm_ID.Text;
            FilmRunningTime = ModifyFilmRunningTime.Text;
            FilmRating = ModifyFilmRating.Text;

            Presenter.ModifyFilm();
            UpdateTable();
            ToConsole.print("Film Table successfully updated.");
            
        }

        private void ConfirmModifyFilm_Click_1()
        {



            FilmTitle = ModifyFilmTitle.Text;
            FilmGenre = ModifyFilmGenre.Text;
            FilmID = ModifyFilm_ID.Text;
            FilmRunningTime = ModifyFilmRunningTime.Text;
            FilmRating = ModifyFilmRating.Text;

            Presenter.ModifyFilm();
            UpdateTable();

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

        private void BTNSearchBy_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            SearchColumn = DictSearchItem[CBXSearchBy.SelectedItem.ToString()];

            SearchTerm = TBXSearchBy.Text;


            FilmDataTable.DataSource = Presenter.getDataTable();
        }

        private void FilmDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyFilm_ID.Text = FilmDataTable.Rows[FilmDataTable.CurrentCell.RowIndex].Cells[0].Value.ToString();
            ModifyFilmTitle.Text = FilmDataTable.Rows[FilmDataTable.CurrentCell.RowIndex].Cells[1].Value.ToString();
            ModifyFilmGenre.Text = FilmDataTable.Rows[FilmDataTable.CurrentCell.RowIndex].Cells[2].Value.ToString();
            ModifyFilmRunningTime.Text = FilmDataTable.Rows[FilmDataTable.CurrentCell.RowIndex].Cells[3].Value.ToString();
            ModifyFilmRating.Text = FilmDataTable.Rows[FilmDataTable.CurrentCell.RowIndex].Cells[4].Value.ToString();

            
        }


        public string FilmID
        {
            get;
            set;
        }

        public bool Status
        {
            get { throw new NotImplementedException(); }
        }

        private void TBXSearchBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmModifyFilm_Click_1();
            }
        }

        private void ModifyFilmUI_Load_1(object sender, EventArgs e)
        {

        }
    }
}

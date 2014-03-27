namespace DigitalProjectorSystem.FILMS.BROWSE_FILMS____MUST_EDIT.IMPLEMENTATION
{
    partial class BrowseFilmUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CBXSearchBy = new System.Windows.Forms.ComboBox();
            this.BTNSearchBy = new System.Windows.Forms.Button();
            this.TBXSearchBy = new System.Windows.Forms.TextBox();
            this.FilmDataTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FilmDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // (search by)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By...";
            // 
            // CBXSearchBy
            // 
            this.CBXSearchBy.FormattingEnabled = true;
            this.CBXSearchBy.Location = new System.Drawing.Point(78, 36);
            this.CBXSearchBy.Name = "CBXSearchBy";
            this.CBXSearchBy.Size = new System.Drawing.Size(121, 21);
            this.CBXSearchBy.TabIndex = 1;
            // 
            // BTNSearchBy
            // 
            this.BTNSearchBy.Location = new System.Drawing.Point(342, 35);
            this.BTNSearchBy.Name = "BTNSearchBy";
            this.BTNSearchBy.Size = new System.Drawing.Size(75, 23);
            this.BTNSearchBy.TabIndex = 2;
            this.BTNSearchBy.Text = "Search";
            this.BTNSearchBy.UseVisualStyleBackColor = true;
            // 
            // TBXSearchBy
            // 
            this.TBXSearchBy.Location = new System.Drawing.Point(223, 37);
            this.TBXSearchBy.Name = "TBXSearchBy";
            this.TBXSearchBy.Size = new System.Drawing.Size(100, 20);
            this.TBXSearchBy.TabIndex = 3;
            // 
            // FilmDataTable
            // 
            this.FilmDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmDataTable.Location = new System.Drawing.Point(67, 86);
            this.FilmDataTable.Name = "FilmDataTable";
            this.FilmDataTable.Size = new System.Drawing.Size(301, 280);
            this.FilmDataTable.TabIndex = 4;
            // 
            // button1
            // (back button)
            // 
            this.button1.Location = new System.Drawing.Point(173, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "<< - Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.evnButtonClickToFilmsFromBrowseFilms);
            // 
            // BrowseFilmUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilmDataTable);
            this.Controls.Add(this.TBXSearchBy);
            this.Controls.Add(this.BTNSearchBy);
            this.Controls.Add(this.CBXSearchBy);
            this.Controls.Add(this.label1);
            this.Name = "BrowseFilmUI";
            this.Text = "BrowseFilmUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrowseFilmsUI_FormClosing); //exit on close.
            ((System.ComponentModel.ISupportInitialize)(this.FilmDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBXSearchBy;
        private System.Windows.Forms.Button BTNSearchBy;
        private System.Windows.Forms.TextBox TBXSearchBy;
        private System.Windows.Forms.DataGridView FilmDataTable;
        private System.Windows.Forms.Button button1;
    }
}
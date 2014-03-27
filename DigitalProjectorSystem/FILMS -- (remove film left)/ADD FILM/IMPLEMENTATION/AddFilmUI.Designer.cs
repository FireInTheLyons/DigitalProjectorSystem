namespace DigitalProjectorSystem.FILMS.ADD_FILM.IMPLEMENTATION
{
    partial class AddFilmUI
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
            this.ConfirmAddFilm = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.AddFilmTitle = new System.Windows.Forms.TextBox();
            this.AddFilmGenre = new System.Windows.Forms.TextBox();
            this.AddFilmRunningTime = new System.Windows.Forms.TextBox();
            this.AddFilmRating = new System.Windows.Forms.TextBox();
            this.AddFilmStatus = new System.Windows.Forms.CheckBox();
            this.AddFilmTitle_Label = new System.Windows.Forms.Label();
            this.AddFilmGenre_Label = new System.Windows.Forms.Label();
            this.AddFilmRunningTime_Label = new System.Windows.Forms.Label();
            this.AddFilmRating_Label = new System.Windows.Forms.Label();
            this.AddFilmStatus_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmAddFilm
            // 
            this.ConfirmAddFilm.Location = new System.Drawing.Point(56, 241);
            this.ConfirmAddFilm.Name = "ConfirmAddFilm";
            this.ConfirmAddFilm.Size = new System.Drawing.Size(159, 31);
            this.ConfirmAddFilm.TabIndex = 0;
            this.ConfirmAddFilm.Text = "Confirm";
            this.ConfirmAddFilm.UseVisualStyleBackColor = true;
            this.ConfirmAddFilm.Click += new System.EventHandler(this.evnButtonClickToConfirmAddFilm);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(56, 278);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(159, 32);
            this.Back.TabIndex = 1;
            this.Back.Text = "< - Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.evnButtonClickToFilmsFrmAddFilmUI);
            // 
            // AddFilmTitle
            // 
            this.AddFilmTitle.Location = new System.Drawing.Point(100, 48);
            this.AddFilmTitle.Multiline = true;
            this.AddFilmTitle.Name = "AddFilmTitle";
            this.AddFilmTitle.Size = new System.Drawing.Size(159, 31);
            this.AddFilmTitle.TabIndex = 3;
            // 
            // AddFilmGenre
            // 
            this.AddFilmGenre.Location = new System.Drawing.Point(100, 85);
            this.AddFilmGenre.Multiline = true;
            this.AddFilmGenre.Name = "AddFilmGenre";
            this.AddFilmGenre.Size = new System.Drawing.Size(159, 32);
            this.AddFilmGenre.TabIndex = 4;
            // 
            // AddFilmRunningTime
            // 
            this.AddFilmRunningTime.Location = new System.Drawing.Point(100, 123);
            this.AddFilmRunningTime.Multiline = true;
            this.AddFilmRunningTime.Name = "AddFilmRunningTime";
            this.AddFilmRunningTime.Size = new System.Drawing.Size(159, 32);
            this.AddFilmRunningTime.TabIndex = 5;
            // 
            // AddFilmRating
            // 
            this.AddFilmRating.Location = new System.Drawing.Point(100, 161);
            this.AddFilmRating.Multiline = true;
            this.AddFilmRating.Name = "AddFilmRating";
            this.AddFilmRating.Size = new System.Drawing.Size(159, 32);
            this.AddFilmRating.TabIndex = 6;
            // 
            // AddFilmStatus
            // 
            this.AddFilmStatus.AutoSize = true;
            this.AddFilmStatus.Location = new System.Drawing.Point(100, 208);
            this.AddFilmStatus.Name = "AddFilmStatus";
            this.AddFilmStatus.Size = new System.Drawing.Size(69, 17);
            this.AddFilmStatus.TabIndex = 7;
            this.AddFilmStatus.Text = "Available";
            this.AddFilmStatus.UseVisualStyleBackColor = true;
            this.AddFilmStatus.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AddFilmTitle_Label
            // 
            this.AddFilmTitle_Label.AutoSize = true;
            this.AddFilmTitle_Label.Location = new System.Drawing.Point(42, 51);
            this.AddFilmTitle_Label.Name = "AddFilmTitle_Label";
            this.AddFilmTitle_Label.Size = new System.Drawing.Size(27, 13);
            this.AddFilmTitle_Label.TabIndex = 9;
            this.AddFilmTitle_Label.Text = "Title";
            // 
            // AddFilmGenre_Label
            // 
            this.AddFilmGenre_Label.AutoSize = true;
            this.AddFilmGenre_Label.Location = new System.Drawing.Point(40, 88);
            this.AddFilmGenre_Label.Name = "AddFilmGenre_Label";
            this.AddFilmGenre_Label.Size = new System.Drawing.Size(36, 13);
            this.AddFilmGenre_Label.TabIndex = 10;
            this.AddFilmGenre_Label.Text = "Genre";
            // 
            // AddFilmRunningTime_Label
            // 
            this.AddFilmRunningTime_Label.AutoSize = true;
            this.AddFilmRunningTime_Label.Location = new System.Drawing.Point(21, 126);
            this.AddFilmRunningTime_Label.Name = "AddFilmRunningTime_Label";
            this.AddFilmRunningTime_Label.Size = new System.Drawing.Size(73, 13);
            this.AddFilmRunningTime_Label.TabIndex = 11;
            this.AddFilmRunningTime_Label.Text = "Running Time";
            // 
            // AddFilmRating_Label
            // 
            this.AddFilmRating_Label.AutoSize = true;
            this.AddFilmRating_Label.Location = new System.Drawing.Point(40, 164);
            this.AddFilmRating_Label.Name = "AddFilmRating_Label";
            this.AddFilmRating_Label.Size = new System.Drawing.Size(38, 13);
            this.AddFilmRating_Label.TabIndex = 12;
            this.AddFilmRating_Label.Text = "Rating";
            // 
            // AddFilmStatus_Label
            // 
            this.AddFilmStatus_Label.AutoSize = true;
            this.AddFilmStatus_Label.Location = new System.Drawing.Point(40, 208);
            this.AddFilmStatus_Label.Name = "AddFilmStatus_Label";
            this.AddFilmStatus_Label.Size = new System.Drawing.Size(37, 13);
            this.AddFilmStatus_Label.TabIndex = 13;
            this.AddFilmStatus_Label.Text = "Status";
            // 
            // AddFilmUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.AddFilmStatus_Label);
            this.Controls.Add(this.AddFilmRating_Label);
            this.Controls.Add(this.AddFilmRunningTime_Label);
            this.Controls.Add(this.AddFilmGenre_Label);
            this.Controls.Add(this.AddFilmTitle_Label);
            this.Controls.Add(this.AddFilmStatus);
            this.Controls.Add(this.AddFilmRating);
            this.Controls.Add(this.AddFilmRunningTime);
            this.Controls.Add(this.AddFilmGenre);
            this.Controls.Add(this.AddFilmTitle);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ConfirmAddFilm);
            this.Name = "AddFilmUI";
            this.Text = "AddFilmUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFilmUI_FormClosing);
            this.Load += new System.EventHandler(this.AddFilmUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ConfirmAddFilm;
        public System.Windows.Forms.Button Back;
        public System.Windows.Forms.TextBox AddFilmTitle;
        public System.Windows.Forms.TextBox AddFilmGenre;
        public System.Windows.Forms.TextBox AddFilmRunningTime;
        public System.Windows.Forms.TextBox AddFilmRating;
        public System.Windows.Forms.CheckBox AddFilmStatus;
        public System.Windows.Forms.Label AddFilmTitle_Label;
        public System.Windows.Forms.Label AddFilmGenre_Label;
        public System.Windows.Forms.Label AddFilmRunningTime_Label;
        public System.Windows.Forms.Label AddFilmRating_Label;
        public System.Windows.Forms.Label AddFilmStatus_Label;
        //NOTE: These WERE private, but I changed them to public.



    }
}
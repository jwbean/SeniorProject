namespace SeniorProject
{
    partial class SoloExcerpts
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
            this.changeInstrumentButton = new System.Windows.Forms.Button();
            this.circleOfFifths = new System.Windows.Forms.Button();
            this.instrumentName = new System.Windows.Forms.Label();
            this.instrumentPicture = new System.Windows.Forms.PictureBox();
            this.excerptListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Composer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearPublished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Difficulty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StoreLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FillerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.instrumentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // changeInstrumentButton
            // 
            this.changeInstrumentButton.Location = new System.Drawing.Point(950, 13);
            this.changeInstrumentButton.Name = "changeInstrumentButton";
            this.changeInstrumentButton.Size = new System.Drawing.Size(140, 34);
            this.changeInstrumentButton.TabIndex = 0;
            this.changeInstrumentButton.Text = "Change Instruments";
            this.changeInstrumentButton.UseVisualStyleBackColor = true;
            this.changeInstrumentButton.Click += new System.EventHandler(this.changeInstrumentButton_Click);
            // 
            // circleOfFifths
            // 
            this.circleOfFifths.Location = new System.Drawing.Point(13, 13);
            this.circleOfFifths.Name = "circleOfFifths";
            this.circleOfFifths.Size = new System.Drawing.Size(140, 34);
            this.circleOfFifths.TabIndex = 2;
            this.circleOfFifths.Text = "Back to Circle of Fifths";
            this.circleOfFifths.UseVisualStyleBackColor = true;
            this.circleOfFifths.Click += new System.EventHandler(this.circleOfFifths_Click);
            // 
            // instrumentName
            // 
            this.instrumentName.Location = new System.Drawing.Point(971, 179);
            this.instrumentName.Name = "instrumentName";
            this.instrumentName.Size = new System.Drawing.Size(100, 20);
            this.instrumentName.TabIndex = 63;
            this.instrumentName.Text = "this is a test";
            this.instrumentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instrumentPicture
            // 
            this.instrumentPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.instrumentPicture.Location = new System.Drawing.Point(971, 64);
            this.instrumentPicture.Name = "instrumentPicture";
            this.instrumentPicture.Size = new System.Drawing.Size(100, 100);
            this.instrumentPicture.TabIndex = 60;
            this.instrumentPicture.TabStop = false;
            // 
            // excerptListView
            // 
            this.excerptListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FillerHeader,
            this.Title,
            this.Composer,
            this.YearPublished,
            this.Difficulty,
            this.StoreLink});
            this.excerptListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excerptListView.FullRowSelect = true;
            this.excerptListView.GridLines = true;
            this.excerptListView.HideSelection = false;
            this.excerptListView.Location = new System.Drawing.Point(45, 144);
            this.excerptListView.Name = "excerptListView";
            this.excerptListView.Size = new System.Drawing.Size(900, 250);
            this.excerptListView.TabIndex = 64;
            this.excerptListView.UseCompatibleStateImageBehavior = false;
            this.excerptListView.View = System.Windows.Forms.View.Details;
            this.excerptListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.excerptListView_ColumnWidthChanging);
            this.excerptListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnClick);
            // 
            // Title
            // 
            this.Title.DisplayIndex = 0;
            this.Title.Text = "Title";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Title.Width = 176;
            // 
            // Composer
            // 
            this.Composer.DisplayIndex = 1;
            this.Composer.Text = "Composer";
            this.Composer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Composer.Width = 150;
            // 
            // YearPublished
            // 
            this.YearPublished.DisplayIndex = 2;
            this.YearPublished.Text = "Year Published";
            this.YearPublished.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YearPublished.Width = 105;
            // 
            // Difficulty
            // 
            this.Difficulty.DisplayIndex = 3;
            this.Difficulty.Text = "Difficulty";
            this.Difficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Difficulty.Width = 65;
            // 
            // StoreLink
            // 
            this.StoreLink.DisplayIndex = 4;
            this.StoreLink.Text = "Store Link";
            this.StoreLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StoreLink.Width = 400;
            // 
            // FillerHeader
            // 
            this.FillerHeader.DisplayIndex = 5;
            this.FillerHeader.Text = "";
            this.FillerHeader.Width = 0;
            // 
            // SoloExcerpts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 625);
            this.Controls.Add(this.excerptListView);
            this.Controls.Add(this.instrumentName);
            this.Controls.Add(this.instrumentPicture);
            this.Controls.Add(this.circleOfFifths);
            this.Controls.Add(this.changeInstrumentButton);
            this.Name = "SoloExcerpts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoloExcerpts";
            ((System.ComponentModel.ISupportInitialize)(this.instrumentPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeInstrumentButton;
        private System.Windows.Forms.Button circleOfFifths;
        private System.Windows.Forms.PictureBox instrumentPicture;
        private System.Windows.Forms.Label instrumentName;
        private System.Windows.Forms.ListView excerptListView;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader FillerHeader;
        private System.Windows.Forms.ColumnHeader Composer;
        private System.Windows.Forms.ColumnHeader YearPublished;
        private System.Windows.Forms.ColumnHeader Difficulty;
        private System.Windows.Forms.ColumnHeader StoreLink;
    }
}
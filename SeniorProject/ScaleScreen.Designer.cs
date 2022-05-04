namespace SeniorProject
{
    partial class ScaleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleScreen));
            this.changeInstrumentButton = new System.Windows.Forms.Button();
            this.circleOfFifthsButton = new System.Windows.Forms.Button();
            this.excerptButton = new System.Windows.Forms.Button();
            this.instrumentName = new System.Windows.Forms.Label();
            this.instrumentPicture = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.keySignature = new System.Windows.Forms.PictureBox();
            this.musicPanel = new System.Windows.Forms.PictureBox();
            this.metronomeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // changeInstrumentButton
            // 
            this.changeInstrumentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeInstrumentButton.Location = new System.Drawing.Point(950, 13);
            this.changeInstrumentButton.Name = "changeInstrumentButton";
            this.changeInstrumentButton.Size = new System.Drawing.Size(140, 34);
            this.changeInstrumentButton.TabIndex = 1;
            this.changeInstrumentButton.Text = "Change Instruments";
            this.changeInstrumentButton.UseVisualStyleBackColor = true;
            this.changeInstrumentButton.Click += new System.EventHandler(this.changeInstrumentButton_Click);
            // 
            // circleOfFifthsButton
            // 
            this.circleOfFifthsButton.Location = new System.Drawing.Point(13, 13);
            this.circleOfFifthsButton.Name = "circleOfFifthsButton";
            this.circleOfFifthsButton.Size = new System.Drawing.Size(140, 34);
            this.circleOfFifthsButton.TabIndex = 2;
            this.circleOfFifthsButton.Text = "Back to Circle of Fifths";
            this.circleOfFifthsButton.UseVisualStyleBackColor = true;
            this.circleOfFifthsButton.Click += new System.EventHandler(this.circleOfFifthsButton_Click);
            // 
            // excerptButton
            // 
            this.excerptButton.Location = new System.Drawing.Point(13, 57);
            this.excerptButton.Name = "excerptButton";
            this.excerptButton.Size = new System.Drawing.Size(140, 34);
            this.excerptButton.TabIndex = 5;
            this.excerptButton.Text = "Solo Excerpts";
            this.excerptButton.UseVisualStyleBackColor = true;
            this.excerptButton.Click += new System.EventHandler(this.excerptButton_Click);
            // 
            // instrumentName
            // 
            this.instrumentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.instrumentName.Location = new System.Drawing.Point(971, 179);
            this.instrumentName.Name = "instrumentName";
            this.instrumentName.Size = new System.Drawing.Size(100, 20);
            this.instrumentName.TabIndex = 61;
            this.instrumentName.Text = "this is a test";
            this.instrumentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instrumentPicture
            // 
            this.instrumentPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.instrumentPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.instrumentPicture.Location = new System.Drawing.Point(971, 64);
            this.instrumentPicture.Name = "instrumentPicture";
            this.instrumentPicture.Size = new System.Drawing.Size(100, 100);
            this.instrumentPicture.TabIndex = 60;
            this.instrumentPicture.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton.Location = new System.Drawing.Point(436, 350);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(45, 41);
            this.playButton.TabIndex = 4;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // keySignature
            // 
            this.keySignature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keySignature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keySignature.Location = new System.Drawing.Point(242, 163);
            this.keySignature.Name = "keySignature";
            this.keySignature.Size = new System.Drawing.Size(178, 166);
            this.keySignature.TabIndex = 3;
            this.keySignature.TabStop = false;
            // 
            // musicPanel
            // 
            this.musicPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musicPanel.Location = new System.Drawing.Point(401, 200);
            this.musicPanel.Name = "musicPanel";
            this.musicPanel.Size = new System.Drawing.Size(494, 150);
            this.musicPanel.TabIndex = 0;
            this.musicPanel.TabStop = false;
            this.musicPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.musicPanel_Paint);
            this.musicPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.musicPanel_Click);
            // 
            // metronomeButton
            // 
            this.metronomeButton.Location = new System.Drawing.Point(13, 100);
            this.metronomeButton.Name = "metronomeButton";
            this.metronomeButton.Size = new System.Drawing.Size(140, 34);
            this.metronomeButton.TabIndex = 62;
            this.metronomeButton.Text = "Metronome";
            this.metronomeButton.UseVisualStyleBackColor = true;
            this.metronomeButton.Click += new System.EventHandler(this.metronomeButton_Click);
            // 
            // ScaleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 625);
            this.Controls.Add(this.metronomeButton);
            this.Controls.Add(this.instrumentName);
            this.Controls.Add(this.instrumentPicture);
            this.Controls.Add(this.excerptButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.keySignature);
            this.Controls.Add(this.circleOfFifthsButton);
            this.Controls.Add(this.changeInstrumentButton);
            this.Controls.Add(this.musicPanel);
            this.Name = "ScaleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScaleScreen";
            ((System.ComponentModel.ISupportInitialize)(this.instrumentPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox musicPanel;
        private System.Windows.Forms.Button changeInstrumentButton;
        private System.Windows.Forms.Button circleOfFifthsButton;
        private System.Windows.Forms.PictureBox keySignature;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button excerptButton;
        private System.Windows.Forms.PictureBox instrumentPicture;
        private System.Windows.Forms.Label instrumentName;
        private System.Windows.Forms.Button metronomeButton;
    }
}
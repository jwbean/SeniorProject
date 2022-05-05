namespace SeniorProject
{
    partial class InstrumentForm
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
            this.instrumentList = new System.Windows.Forms.ListBox();
            this.advanceButton = new System.Windows.Forms.Button();
            this.instrumentPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Your Instrument:";
            // 
            // instrumentList
            // 
            this.instrumentList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instrumentList.FormattingEnabled = true;
            this.instrumentList.Location = new System.Drawing.Point(464, 82);
            this.instrumentList.Name = "instrumentList";
            this.instrumentList.Size = new System.Drawing.Size(143, 186);
            this.instrumentList.TabIndex = 10;
            this.instrumentList.SelectedIndexChanged += new System.EventHandler(this.instrumentList_SelectedIndexChanged);
            // 
            // advanceButton
            // 
            this.advanceButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.advanceButton.Location = new System.Drawing.Point(479, 504);
            this.advanceButton.Name = "advanceButton";
            this.advanceButton.Size = new System.Drawing.Size(109, 52);
            this.advanceButton.TabIndex = 11;
            this.advanceButton.Text = "GO!";
            this.advanceButton.UseVisualStyleBackColor = true;
            this.advanceButton.Click += new System.EventHandler(this.advanceButton_Click);
            // 
            // instrumentPicture
            // 
            this.instrumentPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instrumentPicture.BackgroundImage = global::SeniorProject.Properties.Resources.AltoSax;
            this.instrumentPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.instrumentPicture.Location = new System.Drawing.Point(426, 295);
            this.instrumentPicture.Name = "instrumentPicture";
            this.instrumentPicture.Size = new System.Drawing.Size(213, 170);
            this.instrumentPicture.TabIndex = 9;
            this.instrumentPicture.TabStop = false;
            // 
            // InstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 625);
            this.Controls.Add(this.advanceButton);
            this.Controls.Add(this.instrumentList);
            this.Controls.Add(this.instrumentPicture);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(550, 664);
            this.Name = "InstrumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Instrument";
            ((System.ComponentModel.ISupportInitialize)(this.instrumentPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InstrumentList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox instrumentPicture;
        private System.Windows.Forms.ListBox instrumentList;
        private System.Windows.Forms.Button advanceButton;
    }
}


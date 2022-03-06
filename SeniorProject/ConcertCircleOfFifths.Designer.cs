namespace SeniorProject
{
    partial class ConcertCircleOfFifths
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConcertCircleOfFifths));
            this.changeInstrumentButton = new System.Windows.Forms.Button();
            this.CMajor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CMajor)).BeginInit();
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
            // CMajor
            // 
            this.CMajor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CMajor.BackgroundImage")));
            this.CMajor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CMajor.Location = new System.Drawing.Point(468, 119);
            this.CMajor.Name = "CMajor";
            this.CMajor.Size = new System.Drawing.Size(126, 88);
            this.CMajor.TabIndex = 1;
            this.CMajor.TabStop = false;
            this.CMajor.Click += new System.EventHandler(this.CMajor_Click);
            // 
            // ConcertCircleOfFifths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 625);
            this.Controls.Add(this.CMajor);
            this.Controls.Add(this.changeInstrumentButton);
            this.Name = "ConcertCircleOfFifths";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConcertCircleOfFifths";
            ((System.ComponentModel.ISupportInitialize)(this.CMajor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeInstrumentButton;
        private System.Windows.Forms.PictureBox CMajor;
    }
}
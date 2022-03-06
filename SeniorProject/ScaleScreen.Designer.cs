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
            this.musicPanel = new System.Windows.Forms.PictureBox();
            this.changeInstrumentButton = new System.Windows.Forms.Button();
            this.circleOfFifthsButton = new System.Windows.Forms.Button();
            this.keySignature = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.musicPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySignature)).BeginInit();
            this.SuspendLayout();
            // 
            // musicPanel
            // 
            this.musicPanel.Location = new System.Drawing.Point(300, 200);
            this.musicPanel.Name = "musicPanel";
            this.musicPanel.Size = new System.Drawing.Size(494, 99);
            this.musicPanel.TabIndex = 0;
            this.musicPanel.TabStop = false;
            this.musicPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.musicPanel_Paint);
            // 
            // changeInstrumentButton
            // 
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
            // keySignature
            // 
            this.keySignature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keySignature.Location = new System.Drawing.Point(141, 166);
            this.keySignature.Name = "keySignature";
            this.keySignature.Size = new System.Drawing.Size(178, 166);
            this.keySignature.TabIndex = 3;
            this.keySignature.TabStop = false;
            // 
            // ScaleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 625);
            this.Controls.Add(this.keySignature);
            this.Controls.Add(this.circleOfFifthsButton);
            this.Controls.Add(this.changeInstrumentButton);
            this.Controls.Add(this.musicPanel);
            this.Name = "ScaleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScaleScreen";
            ((System.ComponentModel.ISupportInitialize)(this.musicPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySignature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox musicPanel;
        private System.Windows.Forms.Button changeInstrumentButton;
        private System.Windows.Forms.Button circleOfFifthsButton;
        private System.Windows.Forms.PictureBox keySignature;
    }
}
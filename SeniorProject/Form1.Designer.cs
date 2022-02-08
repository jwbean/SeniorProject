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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.trumpet = new System.Windows.Forms.PictureBox();
            this.flute = new System.Windows.Forms.PictureBox();
            this.trombone = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trumpet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trombone)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::SeniorProject.Properties.Resources.AltoSax;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(417, 413);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // trumpet
            // 
            this.trumpet.BackgroundImage = global::SeniorProject.Properties.Resources.AdjustedTrumpet;
            this.trumpet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.trumpet.Location = new System.Drawing.Point(635, 233);
            this.trumpet.Name = "trumpet";
            this.trumpet.Size = new System.Drawing.Size(200, 200);
            this.trumpet.TabIndex = 6;
            this.trumpet.TabStop = false;
            this.trumpet.Click += new System.EventHandler(this.trumpet_Click);
            // 
            // flute
            // 
            this.flute.BackgroundImage = global::SeniorProject.Properties.Resources.AdjustedFlute;
            this.flute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flute.Location = new System.Drawing.Point(200, 233);
            this.flute.Name = "flute";
            this.flute.Size = new System.Drawing.Size(200, 200);
            this.flute.TabIndex = 5;
            this.flute.TabStop = false;
            this.flute.Click += new System.EventHandler(this.flute_Click);
            // 
            // trombone
            // 
            this.trombone.BackgroundImage = global::SeniorProject.Properties.Resources.AdjustedTrombone;
            this.trombone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.trombone.Location = new System.Drawing.Point(417, 56);
            this.trombone.Name = "trombone";
            this.trombone.Size = new System.Drawing.Size(200, 200);
            this.trombone.TabIndex = 4;
            this.trombone.TabStop = false;
            this.trombone.Click += new System.EventHandler(this.trombone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Your Instrument:";
            // 
            // InstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.trumpet);
            this.Controls.Add(this.flute);
            this.Controls.Add(this.trombone);
            this.Name = "InstrumentForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trumpet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trombone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox trombone;
        private System.Windows.Forms.PictureBox flute;
        private System.Windows.Forms.PictureBox trumpet;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}


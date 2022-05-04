
namespace SeniorProject
{
    partial class Metronome
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
            this.playButton = new System.Windows.Forms.Button();
            this.tempoSelect = new System.Windows.Forms.NumericUpDown();
            this.changeInstrumentButton = new System.Windows.Forms.Button();
            this.circleOfFifths = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroLight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tempoSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::SeniorProject.Properties.Resources.playIcon;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton.Location = new System.Drawing.Point(371, 251);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(42, 41);
            this.playButton.TabIndex = 0;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // tempoSelect
            // 
            this.tempoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoSelect.Location = new System.Drawing.Point(368, 206);
            this.tempoSelect.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.tempoSelect.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.tempoSelect.Name = "tempoSelect";
            this.tempoSelect.Size = new System.Drawing.Size(47, 26);
            this.tempoSelect.TabIndex = 2;
            this.tempoSelect.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // changeInstrumentButton
            // 
            this.changeInstrumentButton.Location = new System.Drawing.Point(648, 12);
            this.changeInstrumentButton.Name = "changeInstrumentButton";
            this.changeInstrumentButton.Size = new System.Drawing.Size(140, 34);
            this.changeInstrumentButton.TabIndex = 4;
            this.changeInstrumentButton.Text = "Change Instruments";
            this.changeInstrumentButton.UseVisualStyleBackColor = true;
            this.changeInstrumentButton.Click += new System.EventHandler(this.changeInstrumentButton_Click);
            // 
            // circleOfFifths
            // 
            this.circleOfFifths.Location = new System.Drawing.Point(12, 12);
            this.circleOfFifths.Name = "circleOfFifths";
            this.circleOfFifths.Size = new System.Drawing.Size(140, 34);
            this.circleOfFifths.TabIndex = 5;
            this.circleOfFifths.Text = "Back to Circle of Fifths";
            this.circleOfFifths.UseVisualStyleBackColor = true;
            this.circleOfFifths.Click += new System.EventHandler(this.circleOfFifths_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Metronome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tempo (bpm):";
            // 
            // metroLight
            // 
            this.metroLight.BackColor = System.Drawing.SystemColors.Window;
            this.metroLight.Enabled = false;
            this.metroLight.Location = new System.Drawing.Point(356, 313);
            this.metroLight.Name = "metroLight";
            this.metroLight.Size = new System.Drawing.Size(75, 75);
            this.metroLight.TabIndex = 8;
            this.metroLight.UseVisualStyleBackColor = false;
            // 
            // Metronome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circleOfFifths);
            this.Controls.Add(this.changeInstrumentButton);
            this.Controls.Add(this.tempoSelect);
            this.Controls.Add(this.playButton);
            this.Name = "Metronome";
            this.Text = "Tuner";
            ((System.ComponentModel.ISupportInitialize)(this.tempoSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.NumericUpDown tempoSelect;
        private System.Windows.Forms.Button changeInstrumentButton;
        private System.Windows.Forms.Button circleOfFifths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button metroLight;
    }
}
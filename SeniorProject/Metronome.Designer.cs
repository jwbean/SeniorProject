
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
            this.button1 = new System.Windows.Forms.Button();
            this.tempoBar = new System.Windows.Forms.TrackBar();
            this.tempoSelect = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.changeInstrumentButton = new System.Windows.Forms.Button();
            this.circleOfFifths = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tempoBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tempoBar
            // 
            this.tempoBar.Location = new System.Drawing.Point(260, 200);
            this.tempoBar.Maximum = 200;
            this.tempoBar.Minimum = 30;
            this.tempoBar.Name = "tempoBar";
            this.tempoBar.Size = new System.Drawing.Size(285, 45);
            this.tempoBar.TabIndex = 1;
            this.tempoBar.TickFrequency = 10;
            this.tempoBar.Value = 80;
            // 
            // tempoSelect
            // 
            this.tempoSelect.Location = new System.Drawing.Point(366, 159);
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
            this.tempoSelect.Size = new System.Drawing.Size(47, 20);
            this.tempoSelect.TabIndex = 2;
            this.tempoSelect.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // Metronome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circleOfFifths);
            this.Controls.Add(this.changeInstrumentButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tempoSelect);
            this.Controls.Add(this.tempoBar);
            this.Controls.Add(this.button1);
            this.Name = "Metronome";
            this.Text = "Tuner";
            ((System.ComponentModel.ISupportInitialize)(this.tempoBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar tempoBar;
        private System.Windows.Forms.NumericUpDown tempoSelect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button changeInstrumentButton;
        private System.Windows.Forms.Button circleOfFifths;
    }
}
using SeniorProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorProject
{
    public partial class ScaleScreen : Form
    {
        private int instrumentIndex;
        private Scale scale;
        private string[] noteArray = new string[8];
        private float[] noteHeight = new float[8];
        
        public ScaleScreen(int instrumentIndex, Scale scale)
        {
            InitializeComponent();
            this.instrumentIndex = instrumentIndex;
            this.scale = scale;
            keySignature.BackgroundImage = Resources.CMajor; //change to be relevant to scale
            //populate the noteArray with sound file names, preferably in a smart way using instrument name and scale
        }

        //https://stackoverflow.com/questions/4052598/draw-a-music-staff-in-c-sharp

        private int _staffHght = 15;
        private int _noteHght = 12;
        private int _noteWdth = 20;
        private Pen _notePen = new Pen(Color.Black, 2);
        private Brush _noteBrush = Brushes.Black;

        private void musicPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            // draw some staff lines
            for (int i = 1; i < 6; i++)
                g.DrawLine(Pens.Black, 0, i * _staffHght, musicPanel.Width, i * _staffHght);

            switch (scale)
            {
                case SeniorProject.Scale.CMajor:
                    noteHeight[0] = 5.6f * _staffHght;
                    noteHeight[1] = 5 * _staffHght;
                    noteHeight[2] = 4.6f * _staffHght;
                    noteHeight[3] = 4 * _staffHght;
                    noteHeight[4] = 3.6f * _staffHght;
                    noteHeight[5] = 3 * _staffHght;
                    noteHeight[6] = 2.6f * _staffHght;
                    noteHeight[7] = 2 * _staffHght;
                    break;
            }

            // draw four semi-random full and quarter notes
            g.FillEllipse(_noteBrush, 50, noteHeight[0], _noteWdth, _noteHght);
            g.FillEllipse(_noteBrush, 100, noteHeight[1], _noteWdth, _noteHght);
            g.FillEllipse(_noteBrush, 150, noteHeight[2], _noteWdth, _noteHght);
            g.FillEllipse(_noteBrush, 200, noteHeight[3], _noteWdth, _noteHght);
            g.FillEllipse(_noteBrush, 250, noteHeight[4], _noteWdth, _noteHght);
            g.FillEllipse(_noteBrush, 300, noteHeight[5], _noteWdth, _noteHght);
            g.FillEllipse(_noteBrush, 350, noteHeight[6], _noteWdth, _noteHght);
            g.FillEllipse(_noteBrush, 400, noteHeight[7], _noteWdth, _noteHght);
        }

        private void changeInstrumentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstrumentForm instruments = new InstrumentForm(instrumentIndex);
            instruments.Closed += (s, args) => this.Close();
            instruments.Show();
        }

        private void circleOfFifthsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (instrumentIndex == (int)Instrument.Flute || instrumentIndex == (int)Instrument.Oboe)
            {
                ConcertCircleOfFifths scales = new ConcertCircleOfFifths(instrumentIndex); //make treble clef version and bass for others
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
            else if (instrumentIndex == (int)Instrument.Bassoon || instrumentIndex == (int)Instrument.Trombone || instrumentIndex == (int)Instrument.Tuba)
            {
                ConcertCircleOfFifths scales = new ConcertCircleOfFifths(instrumentIndex); //might even need to make own for tuba
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
            else if (instrumentIndex == (int)Instrument.AltoSax)
            {
                EFlatCircleOfFifths scales = new EFlatCircleOfFifths(instrumentIndex);
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
            else if (instrumentIndex == (int)Instrument.Clarinet || instrumentIndex == (int)Instrument.Trumpet || instrumentIndex == (int)Instrument.TenorSax)
            {
                BFlatCircleOfFifths scales = new BFlatCircleOfFifths(instrumentIndex);
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
            else if (instrumentIndex == (int)Instrument.FrenchHorn)
            {
                FCircleOfFifths scales = new FCircleOfFifths(instrumentIndex);
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
        }
    }
}

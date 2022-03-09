using SeniorProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Reflection;
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
            noteArray = new[]{ "C4", "D4", "E4", "F4", "G4", "A4", "B4", "C5"}; //add switch statement for each scale (and instrument? :/)
            //maybe use switch statement from below
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
                    keySignature.BackgroundImage = Resources.CMajor;
                    g.DrawLine(Pens.Black, 45, 6 * _staffHght, 75, 6 * _staffHght);
                    noteHeight[0] = 5.6f * _staffHght; //need to add ledger lines somehow
                    noteHeight[1] = 5 * _staffHght;
                    noteHeight[2] = 4.6f * _staffHght;
                    noteHeight[3] = 4 * _staffHght;
                    noteHeight[4] = 3.6f * _staffHght;
                    noteHeight[5] = 3 * _staffHght;
                    noteHeight[6] = 2.6f * _staffHght;
                    noteHeight[7] = 2 * _staffHght;
                    break;
                case SeniorProject.Scale.FMajor:
                    keySignature.BackgroundImage = Resources.FMajor;
                    noteHeight[0] = 4 * _staffHght;
                    noteHeight[1] = 3.6f * _staffHght;
                    noteHeight[2] = 3 * _staffHght;
                    noteHeight[3] = 2.6f * _staffHght;
                    noteHeight[4] = 2 * _staffHght;
                    noteHeight[5] = 1.6f * _staffHght;
                    noteHeight[6] = _staffHght;
                    noteHeight[7] = 0.6f * _staffHght;
                    break;
                case SeniorProject.Scale.BFlatMajor:
                    keySignature.BackgroundImage = Resources.BFlatMajor;
                    g.DrawLine(Pens.Black, 45, _staffHght - 20, 75, _staffHght - 20); //check this height
                    noteHeight[0] = 2.6f * _staffHght;
                    noteHeight[1] = 2 * _staffHght;
                    noteHeight[2] = 1.6f * _staffHght;
                    noteHeight[3] = _staffHght;
                    noteHeight[4] = 0.6f * _staffHght;
                    noteHeight[5] = 0.01f * _staffHght;
                    noteHeight[6] = _staffHght - 20; //need to adjust to work with music panel
                    noteHeight[7] = _staffHght - 30; // check this value
                    break;
                case SeniorProject.Scale.EFlatMajor:
                    keySignature.BackgroundImage = Resources.EFlatMajor;
                    break;
                case SeniorProject.Scale.AFlatMajor:
                    break;
                case SeniorProject.Scale.DFlatMajor:
                    break;
                case SeniorProject.Scale.GFlatMajor:
                    break;
                case SeniorProject.Scale.BMajor:
                    break;
                case SeniorProject.Scale.EMajor:
                    break;
                case SeniorProject.Scale.AMajor:
                    break;
                case SeniorProject.Scale.DMajor:
                    keySignature.BackgroundImage = Resources.DMajor;
                    break;
                case SeniorProject.Scale.GMajor:
                    keySignature.BackgroundImage = Resources.GMajor;
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
            if (instrumentIndex == (int)Instrument.Bassoon || instrumentIndex == (int)Instrument.Trombone || instrumentIndex == (int)Instrument.Tuba)
            {
                BassCircleOfFifths scales = new BassCircleOfFifths(instrumentIndex); //might even need to make own for tuba
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
            else
            {
                TrebleCircleOfFifths scales = new TrebleCircleOfFifths(instrumentIndex); //might even need to make own for tuba
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //change to set str to noteArray[i] from i=0..7
            //for loop outside of using statement
            var asmbly = Assembly.GetExecutingAssembly();
            //var embeddedResources = String.Join("; ", asmbly.GetManifestResourceNames());            
            for (int i = 0; i < 8; i++)
            {
                var wav = asmbly.GetManifestResourceStream("SeniorProject.InstrumentWavFiles." + (Instrument)instrumentIndex + "." + (Instrument)instrumentIndex + noteArray[i] + ".wav");
                using (System.IO.Stream str = wav)
                {
                    SoundPlayer player = new SoundPlayer(str);
                    player.Load();
                    player.Play();
                    System.Threading.Thread.Sleep(800);
                }
            }          
        }
    }
}

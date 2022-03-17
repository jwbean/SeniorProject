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
        private Instrument instrument;
        private Scale scale;
        private string[] noteArray = new string[8];
        private float[] noteHeight = new float[8];
        private int primaryOctave;
        
        public ScaleScreen(Instrument instrument, Scale scale)
        {
            InitializeComponent();
            this.instrument = instrument;
            this.scale = scale;
                
            if (instrument == Instrument.Flute || instrument == Instrument.AltoSax || instrument == Instrument.Trumpet || instrument == Instrument.FrenchHorn)
            {
                primaryOctave = 4;
            }                   
            else if (instrument == Instrument.Trombone)
            {
                primaryOctave = 3;
            }
            else if (instrument == Instrument.Tuba)
            {
                primaryOctave = 2;
            }

            noteArray = new[]{ "C"+primaryOctave, "D" + primaryOctave, "E" + primaryOctave, "F" + primaryOctave, "G" + primaryOctave, "A" + primaryOctave, "B" + primaryOctave, "C" + (primaryOctave+1) }; //add switch statement for each scale (and instrument? :/)
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
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        keySignature.BackgroundImage = Resources.bass_clef4;
                    }
                    else
                    {
                        keySignature.BackgroundImage = Resources.CMajor;
                    }                   
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
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        keySignature.BackgroundImage = Resources.BassFMajor;
                    }
                    else
                    {
                        keySignature.BackgroundImage = Resources.FMajor;
                    }
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
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        keySignature.BackgroundImage = Resources.BassBFlatMajor;
                    }
                    else
                    {
                        keySignature.BackgroundImage = Resources.BFlatMajor;
                    }
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
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        keySignature.BackgroundImage = Resources.BassEFlatMajor;
                    }
                    else
                    {
                        keySignature.BackgroundImage = Resources.EFlatMajor;
                    }
                    break;
                case SeniorProject.Scale.AFlatMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        keySignature.BackgroundImage = Resources.BassAFlatMajor;
                    }
                    else
                    {
                        keySignature.BackgroundImage = Resources.AFlatMajor;
                    }
                    break;
                case SeniorProject.Scale.DFlatMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        keySignature.BackgroundImage = Resources.BassDFlatMajor;
                    }
                    else
                    {
                        keySignature.BackgroundImage = Resources.DFlatMajor;
                    }
                    break;
                case SeniorProject.Scale.GFlatMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        keySignature.BackgroundImage = Resources.BassGFlatMajor;
                    }
                    else
                    {
                        keySignature.BackgroundImage = Resources.GFlatMajor;
                    }
                    break;
                case SeniorProject.Scale.BMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        keySignature.BackgroundImage = Resources.BassBMajor;
                    }
                    else
                    {
                        keySignature.BackgroundImage = Resources.BMajor;
                    }
                    break;
                case SeniorProject.Scale.EMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        keySignature.BackgroundImage = Resources.BassEMajor;
                    }
                    else
                    {
                        keySignature.BackgroundImage = Resources.EMajor;
                    }
                    break;
                case SeniorProject.Scale.AMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        keySignature.BackgroundImage = Resources.BassAMajor;
                    }
                    else
                    {
                        keySignature.BackgroundImage = Resources.AMajor;
                    }
                    break;
                case SeniorProject.Scale.DMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        keySignature.BackgroundImage = Resources.BassDMajor;
                    }
                    else
                    {
                        keySignature.BackgroundImage = Resources.DMajor;
                    }
                    break;
                case SeniorProject.Scale.GMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        keySignature.BackgroundImage = Resources.BassGMajor;
                    }
                    else
                    {
                        keySignature.BackgroundImage = Resources.GMajor;
                    }
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
            InstrumentForm instruments = new InstrumentForm(instrument);
            instruments.Closed += (s, args) => this.Close();
            instruments.Show();
        }

        private void circleOfFifthsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
            {
                BassCircleOfFifths scales = new BassCircleOfFifths(instrument); //might even need to make own for tuba
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
            else
            {
                TrebleCircleOfFifths scales = new TrebleCircleOfFifths(instrument); //might even need to make own for tuba
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            var asmbly = Assembly.GetExecutingAssembly();
            //var embeddedResources = String.Join("; ", asmbly.GetManifestResourceNames());            
            for (int i = 0; i < 8; i++)
            {
                var wav = asmbly.GetManifestResourceStream("SeniorProject.InstrumentWavFiles." + instrument + "." + instrument + noteArray[i] + ".wav");
                using (System.IO.Stream str = wav)
                {
                    SoundPlayer player = new SoundPlayer(str);
                    player.Load();
                    player.Play();
                    System.Threading.Thread.Sleep(800);
                }
            }          
        }

        private void excerptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoloExcerpts excerpts = new SoloExcerpts(instrument);
            excerpts.Closed += (s, args) => this.Close();
            excerpts.Show();
        }
    }
}

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
using Rectangle = System.Drawing.Rectangle;

namespace SeniorProject
{
    public partial class ScaleScreen : Form
    {
        private Instrument instrument;
        private Scale scale;
        private string[] noteArray = new string[8];
        private float[] noteHeight = new float[8];
        private int primaryOctave;
        private bool major; //1 for major, 0 for minor
        private bool staffPainted;
        private bool scalePlaying = false;

        public ScaleScreen(Instrument instrument, Scale scale, bool majorOrMinor)
        {
            InitializeComponent();           
            this.instrument = instrument;
            this.scale = scale;
            major = majorOrMinor;

            switch (instrument)
            {
                case Instrument.AltoSax:
                    instrumentPicture.BackgroundImage = Properties.Resources.AltoSax;
                    instrumentName.Text = "Alto Sax";
                    break;
                case Instrument.Clarinet:
                    instrumentPicture.BackgroundImage = Properties.Resources.Clarinet;
                    instrumentName.Text = "Clarinet";
                    break;
                case Instrument.FrenchHorn:
                    instrumentPicture.BackgroundImage = Properties.Resources.FrenchHorn;
                    instrumentName.Text = "French Horn";
                    break;
                case Instrument.Flute:
                    instrumentPicture.BackgroundImage = Properties.Resources.Flute;
                    instrumentName.Text = "Flute";
                    break;
                case Instrument.Oboe:
                    instrumentPicture.BackgroundImage = Properties.Resources.Oboe;
                    instrumentName.Text = "Oboe";
                    break;
                case Instrument.TenorSax:
                    instrumentPicture.BackgroundImage = Properties.Resources.TenorSax;
                    instrumentName.Text = "Tenor Sax";
                    break;
                case Instrument.Trumpet:
                    instrumentPicture.BackgroundImage = Properties.Resources.Trumpet;
                    instrumentName.Text = "Trumpet";
                    break;
                case Instrument.Trombone:
                    instrumentPicture.BackgroundImage = Properties.Resources.Trombone;
                    instrumentName.Text = "Trombone";
                    break;
                case Instrument.Bassoon:
                    instrumentPicture.BackgroundImage = Properties.Resources.Bassoon;
                    instrumentName.Text = "Bassoon";
                    break;
                case Instrument.Tuba:
                    instrumentPicture.BackgroundImage = Properties.Resources.Tuba;
                    instrumentName.Text = "Tuba";
                    break;
                default:
                    break;
            }

            int tbnOffset = 0;
            int fluteOboeOffset = 0;
            //maybe change flute to octave 5 (and possibly alto)
            if (instrument == Instrument.Flute || instrument == Instrument.AltoSax || instrument == Instrument.Trumpet || instrument == Instrument.FrenchHorn || instrument == Instrument.Oboe || instrument == Instrument.Clarinet || instrument == Instrument.TenorSax)
            {
                primaryOctave = 4;
                if (instrument == Instrument.Flute || instrument == Instrument.Oboe || instrument == Instrument.AltoSax || instrument == Instrument.TenorSax)
                {
                    fluteOboeOffset = 1;
                }
            }           
            else if (instrument == Instrument.Trombone || instrument == Instrument.Bassoon)
            {
                primaryOctave = 3;
                tbnOffset = 1;
            }
            else if (instrument == Instrument.Tuba)
            {
                primaryOctave = 2;
            }
            switch (scale)
            {
                case SeniorProject.Scale.CMajor:
                    noteArray = new[] { "C" + primaryOctave, "D" + primaryOctave, "E" + primaryOctave, "F" + primaryOctave, "G" + primaryOctave, "A" + primaryOctave, "B" + primaryOctave, "C" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.CMinor:
                    noteArray = new[] { "C" + primaryOctave, "D" + primaryOctave, "DSharp" + primaryOctave, "F" + primaryOctave, "G" + primaryOctave, "GSharp" + primaryOctave, "ASharp" + primaryOctave, "C" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.DFlatMajor:
                    noteArray = new[] { "CSharp" + primaryOctave, "DSharp" + primaryOctave, "F" + primaryOctave, "FSharp" + primaryOctave, "GSharp" + primaryOctave, "ASharp" + primaryOctave, "C" + (primaryOctave + 1), "CSharp" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.CSharpMinor:
                    noteArray = new[] { "CSharp" + primaryOctave, "DSharp" + primaryOctave, "E" + primaryOctave, "FSharp" + primaryOctave, "GSharp" + primaryOctave, "A" + primaryOctave, "B" + primaryOctave, "CSharp" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.DMajor:
                    noteArray = new[] { "D" + primaryOctave, "E" + primaryOctave, "FSharp" + primaryOctave, "G" + primaryOctave, "A" + primaryOctave, "B" + primaryOctave, "CSharp" + (primaryOctave + 1), "D" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.DMinor:
                    noteArray = new[] { "D" + primaryOctave, "E" + primaryOctave, "F" + primaryOctave, "G" + primaryOctave, "A" + primaryOctave, "ASharp" + primaryOctave, "C" + (primaryOctave + 1), "D" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.EFlatMajor:
                    noteArray = new[] { "DSharp" + primaryOctave, "F" + primaryOctave, "G" + primaryOctave, "GSharp" + primaryOctave, "ASharp" + primaryOctave, "C" + (primaryOctave + 1), "D" + (primaryOctave + 1), "DSharp" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.EFlatMinor:
                    noteArray = new[] { "DSharp" + primaryOctave, "F" + primaryOctave, "FSharp" + primaryOctave, "GSharp" + primaryOctave, "ASharp" + primaryOctave, "B" + primaryOctave, "CSharp" + (primaryOctave + 1), "DSharp" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.EMajor:
                    noteArray = new[] { "E" + primaryOctave, "FSharp" + primaryOctave, "GSharp" + primaryOctave, "A" + primaryOctave, "B" + primaryOctave, "CSharp" + (primaryOctave + 1), "DSharp" + (primaryOctave + 1), "E" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.EMinor:
                    noteArray = new[] { "E" + primaryOctave, "FSharp" + primaryOctave, "G" + primaryOctave, "A" + primaryOctave, "B" + primaryOctave, "C" + (primaryOctave+1), "D" + (primaryOctave + 1), "E" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.FMajor:
                    noteArray = new[] { "F" + primaryOctave, "G" + primaryOctave, "A" + primaryOctave, "ASharp" + primaryOctave, "C" + (primaryOctave + 1), "D" + (primaryOctave + 1), "E" + (primaryOctave + 1), "F" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.FMinor:
                    noteArray = new[] { "F" + primaryOctave, "G" + primaryOctave, "GSharp" + primaryOctave, "ASharp" + primaryOctave, "C" + (primaryOctave + 1), "CSharp" + (primaryOctave + 1), "DSharp" + (primaryOctave + 1), "F" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.GFlatMajor:
                    noteArray = new[] { "FSharp" + (primaryOctave - tbnOffset), "GSharp" + (primaryOctave - tbnOffset), "ASharp" + (primaryOctave - tbnOffset), "B" + (primaryOctave - tbnOffset), "CSharp" + (primaryOctave + 1 - tbnOffset), "DSharp" + (primaryOctave + 1 - tbnOffset), "F" + (primaryOctave + 1 - tbnOffset), "FSharp" + (primaryOctave + 1 - tbnOffset) };
                    break;
                case SeniorProject.Scale.FSharpMinor:
                    noteArray = new[] { "FSharp" + primaryOctave, "GSharp" + primaryOctave, "A" + primaryOctave, "B" + primaryOctave, "CSharp" + (primaryOctave + 1), "D" + (primaryOctave + 1), "E" + (primaryOctave + 1), "FSharp" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.GMajor:
                    noteArray = new[] { "G" + (primaryOctave - 1 + fluteOboeOffset), "A" + (primaryOctave - 1 + fluteOboeOffset), "B" + (primaryOctave - 1 + fluteOboeOffset), "C" + (primaryOctave + fluteOboeOffset), "D" + (primaryOctave + fluteOboeOffset), "E" + (primaryOctave + fluteOboeOffset), "FSharp" + (primaryOctave + fluteOboeOffset), "G" + (primaryOctave + fluteOboeOffset) };
                    break;
                case SeniorProject.Scale.GMinor:
                    noteArray = new[] { "G" + (primaryOctave - 1 + fluteOboeOffset), "A" + (primaryOctave - 1 + fluteOboeOffset), "ASharp" + (primaryOctave - 1 + fluteOboeOffset), "C" + (primaryOctave + fluteOboeOffset), "D" + (primaryOctave + fluteOboeOffset), "DSharp" + (primaryOctave + fluteOboeOffset), "F" + (primaryOctave + fluteOboeOffset), "G" + (primaryOctave + fluteOboeOffset) };
                    break;
                case SeniorProject.Scale.AFlatMajor:
                    noteArray = new[] { "GSharp" + (primaryOctave - 1 + fluteOboeOffset), "ASharp" + (primaryOctave - 1 + fluteOboeOffset), "C" + (primaryOctave + fluteOboeOffset), "CSharp" + (primaryOctave + fluteOboeOffset), "DSharp" + (primaryOctave + fluteOboeOffset), "F" + (primaryOctave + fluteOboeOffset), "G" + (primaryOctave + fluteOboeOffset), "GSharp" + (primaryOctave + fluteOboeOffset) };
                    break;
                case SeniorProject.Scale.GSharpMinor:
                    noteArray = new[] { "GSharp" + (primaryOctave - 1 + fluteOboeOffset), "ASharp" + (primaryOctave - 1 + fluteOboeOffset), "B" + (primaryOctave - 1 + fluteOboeOffset), "CSharp" + (primaryOctave + fluteOboeOffset), "DSharp" + (primaryOctave + fluteOboeOffset), "E" + (primaryOctave + fluteOboeOffset), "FSharp" + (primaryOctave + fluteOboeOffset), "GSharp" + (primaryOctave + fluteOboeOffset) };
                    break;
                case SeniorProject.Scale.AMajor:
                    noteArray = new[] { "A" + (primaryOctave - 1 + fluteOboeOffset), "B" + (primaryOctave - 1 + fluteOboeOffset), "CSharp" + (primaryOctave + fluteOboeOffset), "D" + (primaryOctave + fluteOboeOffset), "E" + (primaryOctave + fluteOboeOffset), "FSharp" + (primaryOctave + fluteOboeOffset), "GSharp" + (primaryOctave + fluteOboeOffset), "A" + (primaryOctave + fluteOboeOffset) };
                    break;
                case SeniorProject.Scale.AMinor:
                    noteArray = new[] { "A" + (primaryOctave - 1 + fluteOboeOffset), "B" + (primaryOctave - 1 + fluteOboeOffset), "C" + (primaryOctave + fluteOboeOffset), "D" + (primaryOctave + fluteOboeOffset), "E" + (primaryOctave + fluteOboeOffset), "F" + (primaryOctave + fluteOboeOffset), "G" + (primaryOctave + fluteOboeOffset), "A" + (primaryOctave + fluteOboeOffset) };
                    break;
                case SeniorProject.Scale.BFlatMajor:
                    noteArray = new[] { "ASharp" + (primaryOctave - 1 + fluteOboeOffset), "C" + (primaryOctave + fluteOboeOffset), "D" + (primaryOctave + fluteOboeOffset), "DSharp" + (primaryOctave + fluteOboeOffset), "F" + (primaryOctave + fluteOboeOffset), "G" + (primaryOctave + fluteOboeOffset), "A" + (primaryOctave + fluteOboeOffset), "ASharp" + (primaryOctave + fluteOboeOffset) };
                    break;
                case SeniorProject.Scale.BFlatMinor:
                    noteArray = new[] { "ASharp" + (primaryOctave - 1 + fluteOboeOffset), "C" + (primaryOctave + fluteOboeOffset), "CSharp" + (primaryOctave + fluteOboeOffset), "DSharp" + (primaryOctave + fluteOboeOffset), "F" + (primaryOctave + fluteOboeOffset), "FSharp" + (primaryOctave + fluteOboeOffset), "GSharp" + (primaryOctave + fluteOboeOffset), "ASharp" + (primaryOctave + fluteOboeOffset) };
                    break;
                case SeniorProject.Scale.BMajor:
                    noteArray = new[] { "B" + (primaryOctave - 1 + fluteOboeOffset), "CSharp" + (primaryOctave + fluteOboeOffset), "DSharp" + (primaryOctave + fluteOboeOffset), "E" + (primaryOctave + fluteOboeOffset), "FSharp" + (primaryOctave + fluteOboeOffset), "GSharp" + (primaryOctave + fluteOboeOffset), "ASharp" + (primaryOctave + fluteOboeOffset), "B" + (primaryOctave + fluteOboeOffset) };
                    break;
                case SeniorProject.Scale.BMinor:
                    noteArray = new[] { "B" + (primaryOctave - 1 + fluteOboeOffset), "CSharp" + (primaryOctave + fluteOboeOffset), "D" + (primaryOctave + fluteOboeOffset), "E" + (primaryOctave + fluteOboeOffset), "FSharp" + (primaryOctave + fluteOboeOffset), "G" + (primaryOctave + fluteOboeOffset), "A" + (primaryOctave + fluteOboeOffset), "B" + (primaryOctave + fluteOboeOffset) };
                    break;
            }
        }

        //https://stackoverflow.com/questions/4052598/draw-a-music-staff-in-c-sharp

        private int _staffHght = 15;
        private int _noteHght = 12;
        private int _noteWdth = 20;
        private Pen _notePen = new Pen(Color.Black, 2);
        private Brush _noteBrush = Brushes.Black;
        private Brush _highlightBrush = Brushes.Green;
        //private Graphics g;

        private void musicPanel_Paint(object sender, PaintEventArgs e)
        {
            if (staffPainted) return;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            if (instrument == Instrument.Trombone || instrument == Instrument.Bassoon || instrument == Instrument.Flute || instrument == Instrument.Oboe || instrument == Instrument.AltoSax || instrument == Instrument.TenorSax)
            {
                musicPanel.Top = musicPanel.Top - 30;
                for (int i = 1; i < 6; i++)
                    g.DrawLine(Pens.Black, 0, (i * _staffHght)+30, musicPanel.Width, (i * _staffHght)+30);
            }
            
            // draw some staff lines
            else
            {
                for (int i = 1; i < 6; i++)
                    g.DrawLine(Pens.Black, 0, i * _staffHght, musicPanel.Width, i * _staffHght);
            }
                      
            switch (scale)
            {
                case SeniorProject.Scale.CMinor:
                case SeniorProject.Scale.CMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassCMajorV_2; //no flats or sharps
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassEFlatMajorV_2; //three flats
                        }
                    }
                    else
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.CMajor; //no flats or sharps
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.EFlatMajor; //three flats
                        }
                    }
                    c_noteHeight(g);
                    break;
                case SeniorProject.Scale.FMinor:
                case SeniorProject.Scale.FMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassFMajorV_2;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassAFlatMajorV_2;
                        }
                    }
                    else
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.FMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.AFlatMajor;
                        }
                    }
                    f_noteHeight(g);
                    break;
                case SeniorProject.Scale.BFlatMinor:
                case SeniorProject.Scale.BFlatMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassBFlatMajorV_2;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassDFlatMajorV_2;
                        }
                    }
                    else
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BFlatMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.DFlatMajor;
                        }
                    }
                    b_noteHeight(g);
                    break;
                case SeniorProject.Scale.EFlatMinor:
                case SeniorProject.Scale.EFlatMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassEFlatMajorV_2;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassGFlatMajorV_2;
                        }
                    }
                    else
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.EFlatMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.GFlatMajor;
                        }
                    }
                    e_noteHeight(g);
                    break;
                case SeniorProject.Scale.GSharpMinor:
                case SeniorProject.Scale.AFlatMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassAFlatMajorV_2;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassBMajorV_2;
                        }
                    }
                    else
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.AFlatMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BMajor;
                        }
                    }
                    if (major)
                    {
                        a_noteHeight(g);
                    }
                    else
                    {
                        g_noteHeight(g, false);
                    }
                    break;
                case SeniorProject.Scale.CSharpMinor:
                case SeniorProject.Scale.DFlatMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassDFlatMajorV_2;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassEMajorV_2;
                        }
                    }
                    else
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.DFlatMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.EMajor;
                        }
                    }
                    if (major)
                    {
                        d_noteHeight(g);
                    }
                    else
                    {
                        c_noteHeight(g);
                    }
                    break;
                case SeniorProject.Scale.FSharpMinor:
                case SeniorProject.Scale.GFlatMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassGFlatMajorV_2;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassAMajorV_2;
                        }
                    }
                    else
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.GFlatMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.AMajor;
                        }
                    }
                    if (major)
                    {
                        g_noteHeight(g, true);
                    }
                    else
                    {
                        f_noteHeight(g);
                    }
                    break;
                case SeniorProject.Scale.BMinor:
                case SeniorProject.Scale.BMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassBMajorV_2;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassDMajorV_2;
                        }
                    }
                    else
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.DMajor;
                        }
                    }
                    b_noteHeight(g);
                    break;
                case SeniorProject.Scale.EMinor:
                case SeniorProject.Scale.EMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassEMajorV_2;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassGMajorV_2;
                        }
                    }
                    else
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.EMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.GMajor;
                        }
                    }
                    e_noteHeight(g);
                    break;
                case SeniorProject.Scale.AMinor:
                case SeniorProject.Scale.AMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassAMajorV_2;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassCMajorV_2;
                        }
                    }
                    else
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.AMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.CMajor;
                        }
                    }
                    a_noteHeight(g);
                    break;
                case SeniorProject.Scale.DMinor:
                case SeniorProject.Scale.DMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassDMajorV_2;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassFMajorV_2;
                        }
                    }
                    else
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.DMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.FMajor;
                        }
                    }
                    d_noteHeight(g);
                    break;
                case SeniorProject.Scale.GMinor:
                case SeniorProject.Scale.GMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassGMajorV_2;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassBFlatMajorV_2;
                        }
                    }
                    else
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.GMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BFlatMajor;
                        }
                    }
                    g_noteHeight(g, false);
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

            staffPainted = true;
        }

        private void a_noteHeight(Graphics g)
        {
            float tubaOffset = 0;
            float tbnOffset = 0;
            float fluteOboeOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
            }
            else if (instrument == Instrument.Trombone || instrument == Instrument.Bassoon)
            {
                tbnOffset = 2.5f;
            }
            else if (instrument == Instrument.Flute || instrument == Instrument.Oboe || instrument == Instrument.AltoSax || instrument == Instrument.TenorSax)
            {
                fluteOboeOffset = 3.5f;
            }
            if (tbnOffset == 0 && fluteOboeOffset == 0)
            {
                g.DrawLine(Pens.Black, 45, 7 * _staffHght, 75, 7 * _staffHght);
                g.DrawLine(Pens.Black, 45, 6 * _staffHght, 75, 6 * _staffHght);
                g.DrawLine(Pens.Black, 95, 6 * _staffHght, 125, 6 * _staffHght);
                g.DrawLine(Pens.Black, 145, 6 * _staffHght, 175, 6 * _staffHght);
                if (tubaOffset != 0)
                {
                    g.DrawLine(Pens.Black, 45, 8 * _staffHght, 75, 8 * _staffHght);
                    g.DrawLine(Pens.Black, 95, 7 * _staffHght, 125, 7 * _staffHght);
                    g.DrawLine(Pens.Black, 145, 7 * _staffHght, 175, 7 * _staffHght);
                    g.DrawLine(Pens.Black, 195, 6 * _staffHght, 225, 6 * _staffHght);
                    g.DrawLine(Pens.Black, 245, 6 * _staffHght, 275, 6 * _staffHght);
                }
            }            
            noteHeight[0] = (6.6f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[1] = (6 + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[2] = (5.6f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[3] = (5 + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[4] = (4.6f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[5] = (4 + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[6] = (3.6f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[7] = (3 + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            if (tbnOffset != 0 || fluteOboeOffset != 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    noteHeight[i] += 30;
                }
            }
            if (fluteOboeOffset != 0)
            {
                g.DrawLine(Pens.Black, 395, noteHeight[7] + 7, 425, noteHeight[7] + 7);
            }
        }

        private void b_noteHeight(Graphics g)
        {
            float tubaOffset = 0;
            float tbnOffset = 0;
            float fluteOboeOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
            }
            else if (instrument == Instrument.Trombone || instrument == Instrument.Bassoon)
            {
                tbnOffset = 2.5f;
            }
            else if (instrument == Instrument.Flute || instrument == Instrument.Oboe || instrument == Instrument.AltoSax || instrument == Instrument.TenorSax)
            {
                fluteOboeOffset = 3.5f;
            }
            if (tbnOffset == 0)
            {
                g.DrawLine(Pens.Black, 45, 6 * _staffHght, 75, 6 * _staffHght);
                g.DrawLine(Pens.Black, 95, 6 * _staffHght, 125, 6 * _staffHght);
                if (tubaOffset != 0)
                {
                    g.DrawLine(Pens.Black, 45, 7 * _staffHght, 75, 7 * _staffHght);
                    g.DrawLine(Pens.Black, 95, 7 * _staffHght, 125, 7 * _staffHght);
                    g.DrawLine(Pens.Black, 145, 6 * _staffHght, 175, 6 * _staffHght);
                    g.DrawLine(Pens.Black, 195, 6 * _staffHght, 225, 6 * _staffHght);
                }
            }
            noteHeight[0] = (6 + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[1] = (5.6f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[2] = (5 + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[3] = (4.6f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[4] = (4 + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[5] = (3.6f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[6] = (3 + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            noteHeight[7] = (2.6f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            if (tbnOffset != 0 || fluteOboeOffset != 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    noteHeight[i] += 30;
                }
            }
            if (fluteOboeOffset != 0)
            {
                g.DrawLine(Pens.Black, 345, noteHeight[6] + 7, 375, noteHeight[6] + 7);
                g.DrawLine(Pens.Black, 395, noteHeight[6] + 7, 425, noteHeight[6] + 7);
            }
        }

        private void c_noteHeight(Graphics g)
        {
            float tubaOffset = 0;
            float tbnOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
            }
            else if (instrument == Instrument.Trombone || instrument == Instrument.Bassoon)
            {
                tbnOffset = 2.5f;
            }                   
            noteHeight[0] = (5.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[1] = (5 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[2] = (4.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[3] = (4 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[4] = (3.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[5] = (3 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[6] = (2.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[7] = (2 + tubaOffset - tbnOffset) * _staffHght;
            if (tbnOffset != 0 || instrument == Instrument.Flute || instrument == Instrument.Oboe || instrument == Instrument.AltoSax || instrument == Instrument.TenorSax)
            {
                for (int i = 0; i < 8; i++)
                {
                    noteHeight[i] += 30;
                }
                if (tbnOffset != 0)
                {
                    g.DrawLine(Pens.Black, 395, noteHeight[7] + 7, 425, noteHeight[7] + 7);
                }
                else
                {
                    g.DrawLine(Pens.Black, 45, noteHeight[0] + 7, 75, noteHeight[0] + 7);
                }
            }
            else
            {
                g.DrawLine(Pens.Black, 45, 6 * _staffHght, 75, 6 * _staffHght);
                if (tubaOffset != 0)
                {
                    g.DrawLine(Pens.Black, 45, 7 * _staffHght, 75, 7 * _staffHght);
                    g.DrawLine(Pens.Black, 95, 6 * _staffHght, 125, 6 * _staffHght);
                    g.DrawLine(Pens.Black, 145, 6 * _staffHght, 175, 6 * _staffHght);
                }
            }
        }

        private void d_noteHeight(Graphics g)
        {
            float tubaOffset = 0;
            float tbnOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
                g.DrawLine(Pens.Black, 45, 6 * _staffHght, 75, 6 * _staffHght);
                g.DrawLine(Pens.Black, 95, 6 * _staffHght, 125, 6 * _staffHght);
            }
            else if (instrument == Instrument.Trombone || instrument == Instrument.Bassoon)
            {
                tbnOffset = 2.5f;
            }
            noteHeight[0] = (5 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[1] = (4.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[2] = (4 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[3] = (3.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[4] = (3 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[5] = (2.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[6] = (2 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[7] = (1.6f + tubaOffset - tbnOffset) * _staffHght;
            if (tbnOffset != 0 || instrument == Instrument.Flute || instrument == Instrument.Oboe || instrument == Instrument.AltoSax || instrument == Instrument.TenorSax)
            {
                for (int i = 0; i < 8; i++)
                {
                    noteHeight[i] += 30;
                }
                if (tbnOffset != 0)
                {
                    g.DrawLine(Pens.Black, 345, noteHeight[6] + 7, 375, noteHeight[6] + 7);
                    g.DrawLine(Pens.Black, 395, noteHeight[6] + 7, 425, noteHeight[6] + 7);
                }               
            }
        }

        private void e_noteHeight(Graphics g)
        {
            float tubaOffset = 0;
            float tbnOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
                g.DrawLine(Pens.Black, 45, 6 * _staffHght, 75, 6 * _staffHght);
            }
            else if (instrument == Instrument.Trombone || instrument == Instrument.Bassoon)
            {
                tbnOffset = 2.5f;
            }
            noteHeight[0] = (4.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[1] = (4 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[2] = (3.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[3] = (3 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[4] = (2.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[5] = (2 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[6] = (1.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[7] = (1 + tubaOffset - tbnOffset) * _staffHght;
            if (tbnOffset != 0 || instrument == Instrument.Flute || instrument == Instrument.Oboe || instrument == Instrument.AltoSax || instrument == Instrument.TenorSax)
            {
                for (int i = 0; i < 8; i++)
                {
                    noteHeight[i] += 30;
                }
                if (tbnOffset != 0)
                {
                    g.DrawLine(Pens.Black, 295, noteHeight[5] + 7, 325, noteHeight[5] + 7);
                    g.DrawLine(Pens.Black, 345, noteHeight[5] + 7, 375, noteHeight[5] + 7);
                    g.DrawLine(Pens.Black, 395, noteHeight[5] + 7, 425, noteHeight[5] + 7);
                    g.DrawLine(Pens.Black, 395, noteHeight[5] - 8, 425, noteHeight[5] - 8);
                }               
            }
        }

        private void f_noteHeight(Graphics g)
        {
            float tubaOffset = 0;
            float tbnOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
            }
            else if (instrument == Instrument.Trombone || instrument == Instrument.Bassoon)
            {
                tbnOffset = 2.5f;
            }
            noteHeight[0] = (4 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[1] = (3.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[2] = (3 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[3] = (2.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[4] = (2 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[5] = (1.6f + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[6] = (1 + tubaOffset - tbnOffset) * _staffHght;
            noteHeight[7] = (0.6f + tubaOffset - tbnOffset) * _staffHght;
            if (tbnOffset != 0 || instrument == Instrument.Flute || instrument == Instrument.Oboe || instrument == Instrument.AltoSax || instrument == Instrument.TenorSax)
            {
                for (int i = 0; i < 8; i++)
                {
                    noteHeight[i] += 30;
                }
                if (tbnOffset != 0)
                {
                    g.DrawLine(Pens.Black, 245, noteHeight[4] + 7, 275, noteHeight[4] + 7);
                    g.DrawLine(Pens.Black, 295, noteHeight[4] + 7, 325, noteHeight[4] + 7);
                    g.DrawLine(Pens.Black, 345, noteHeight[4] + 7, 375, noteHeight[4] + 7);
                    g.DrawLine(Pens.Black, 345, noteHeight[4] - 8, 375, noteHeight[4] - 8);
                    g.DrawLine(Pens.Black, 395, noteHeight[4] + 7, 425, noteHeight[4] + 7);
                    g.DrawLine(Pens.Black, 395, noteHeight[4] - 8, 425, noteHeight[4] - 8);
                }               
            }
        }

        private void g_noteHeight(Graphics g, bool gflat)
        {
            float tubaOffset = 0;
            float tbnOffset = 0;
            float fluteOboeOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
            }
            else if (instrument == Instrument.Trombone || instrument == Instrument.Bassoon)
            {
                tbnOffset = 2.5f;
            }
            else if (instrument == Instrument.Flute || instrument == Instrument.Oboe || instrument == Instrument.AltoSax || instrument == Instrument.TenorSax)
            {
                fluteOboeOffset = 0.01f;
            }
            if ((gflat && tbnOffset == 0) || fluteOboeOffset != 0)
            {
                noteHeight[0] = (3.6f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
                noteHeight[1] = (3 + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
                noteHeight[2] = (2.6f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
                noteHeight[3] = (2 + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
                noteHeight[4] = (1.6f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
                noteHeight[5] = (1 + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
                noteHeight[6] = (0.6f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
                noteHeight[7] = (0.01f + tubaOffset - tbnOffset - fluteOboeOffset) * _staffHght;
            }
            else
            {
                g.DrawLine(Pens.Black, 45, 7 * _staffHght, 75, 7 * _staffHght);
                g.DrawLine(Pens.Black, 45, 6 * _staffHght, 75, 6 * _staffHght);
                g.DrawLine(Pens.Black, 95, 6 * _staffHght, 125, 6 * _staffHght);
                g.DrawLine(Pens.Black, 95, 7 * _staffHght, 125, 7 * _staffHght);
                g.DrawLine(Pens.Black, 145, 6 * _staffHght, 175, 6 * _staffHght);
                g.DrawLine(Pens.Black, 195, 6 * _staffHght, 225, 6 * _staffHght);
                if (tubaOffset != 0)
                {
                    g.DrawLine(Pens.Black, 45, 8 * _staffHght, 75, 8 * _staffHght);
                    g.DrawLine(Pens.Black, 95, 8 * _staffHght, 125, 8 * _staffHght);
                    g.DrawLine(Pens.Black, 145, 7 * _staffHght, 175, 7 * _staffHght);
                    g.DrawLine(Pens.Black, 195, 7 * _staffHght, 225, 7 * _staffHght);
                    g.DrawLine(Pens.Black, 245, 6 * _staffHght, 275, 6 * _staffHght);
                    g.DrawLine(Pens.Black, 295, 6 * _staffHght, 325, 6 * _staffHght);
                }
                noteHeight[0] = (7 + tubaOffset - tbnOffset) * _staffHght;
                noteHeight[1] = (6.6f + tubaOffset - tbnOffset) * _staffHght;
                noteHeight[2] = (6 + tubaOffset - tbnOffset) * _staffHght;
                noteHeight[3] = (5.6f + tubaOffset - tbnOffset) * _staffHght;
                noteHeight[4] = (5 + tubaOffset - tbnOffset) * _staffHght;
                noteHeight[5] = (4.6f + tubaOffset - tbnOffset) * _staffHght;
                noteHeight[6] = (4 + tubaOffset - tbnOffset) * _staffHght;
                noteHeight[7] = (3.6f + tubaOffset - tbnOffset) * _staffHght;
            }
            if (tbnOffset != 0 || fluteOboeOffset != 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    noteHeight[i] += 30;
                }
            }
        }

        private void changeInstrumentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstrumentForm instruments = new InstrumentForm(instrument);
            instruments.Closed += (s, args) => this.Close();
            musicPanel.Dispose();
            instruments.Show();
        }

        private void circleOfFifthsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
            {
                BassCircleOfFifths scales = new BassCircleOfFifths(instrument, major); 
                scales.Closed += (s, args) => this.Close();
                musicPanel.Dispose();
                scales.Show();
            }
            else
            {
                TrebleCircleOfFifths scales = new TrebleCircleOfFifths(instrument, major);
                scales.Closed += (s, args) => this.Close();
                musicPanel.Dispose();
                scales.Show();
            }
        }

        private async void playButton_Click(object sender, EventArgs e)
        {
            if (!scalePlaying)
            {
                scalePlaying = true;
                playButton.BackgroundImage = Resources.stopIcon;
                var asmbly = Assembly.GetExecutingAssembly();
                //var embeddedResources = String.Join("; ", asmbly.GetManifestResourceNames());
                Graphics g2 = musicPanel.CreateGraphics();
                g2.SmoothingMode = SmoothingMode.HighQuality;
                for (int i = 0; i < 8; i++)
                {
                    if (scalePlaying)
                    {
                        g2.FillEllipse(_highlightBrush, 50 * (i + 1), noteHeight[i], _noteWdth, _noteHght);
                        var wav = asmbly.GetManifestResourceStream("SeniorProject.InstrumentWavFiles." + instrument + "." + instrument + noteArray[i] + ".wav");
                        using (System.IO.Stream str = wav)
                        {
                            SoundPlayer player = new SoundPlayer(str);
                            player.Load();
                            player.Play();
                            await Task.Delay(800);
                        }
                        g2.FillEllipse(_noteBrush, 50 * (i + 1), noteHeight[i], _noteWdth, _noteHght);
                    }                    
                }
                g2.Dispose();
                scalePlaying = false;
                playButton.BackgroundImage = Resources.playIcon;
            }
            else
            {
                scalePlaying = false;
                playButton.BackgroundImage = Resources.playIcon;
            }
        }

        private void excerptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoloExcerpts excerpts = new SoloExcerpts(instrument);
            excerpts.Closed += (s, args) => this.Close();
            musicPanel.Dispose();
            excerpts.Show();
        }

        private async void musicPanel_Click(object sender, MouseEventArgs e)
        {
            int i = 0;
            Region region1 = new Region(new Rectangle(new Point(50, (int)noteHeight[i]), new Size(_noteWdth, _noteHght)));
            i++;
            Region region2 = new Region(new Rectangle(new Point(100, (int)noteHeight[i]), new Size(_noteWdth, _noteHght)));
            i++;
            Region region3 = new Region(new Rectangle(new Point(150, (int)noteHeight[i]), new Size(_noteWdth, _noteHght)));
            i++;
            Region region4 = new Region(new Rectangle(new Point(200, (int)noteHeight[i]), new Size(_noteWdth, _noteHght)));
            i++;
            Region region5 = new Region(new Rectangle(new Point(250, (int)noteHeight[i]), new Size(_noteWdth, _noteHght)));
            i++;
            Region region6 = new Region(new Rectangle(new Point(300, (int)noteHeight[i]), new Size(_noteWdth, _noteHght)));
            i++;
            Region region7 = new Region(new Rectangle(new Point(350, (int)noteHeight[i]), new Size(_noteWdth, _noteHght)));
            i++;
            Region region8 = new Region(new Rectangle(new Point(400, (int)noteHeight[i]), new Size(_noteWdth, _noteHght)));
            if (e.Button == MouseButtons.Left)
            {
                if (region1.IsVisible(e.Location))
                {
                    i = 0;
                }
                else if (region2.IsVisible(e.Location))
                {
                    i = 1;
                }
                else if (region3.IsVisible(e.Location))
                {
                    i = 2;
                }
                else if (region4.IsVisible(e.Location))
                {
                    i = 3;
                }
                else if (region5.IsVisible(e.Location))
                {
                    i = 4;
                }
                else if (region6.IsVisible(e.Location))
                {
                    i = 5;
                }
                else if (region7.IsVisible(e.Location))
                {
                    i = 6;
                }
                else if (region8.IsVisible(e.Location))
                {
                    i = 7;
                }
                else
                {
                    return;
                }
                var asmbly = Assembly.GetExecutingAssembly();
                //var embeddedResources = String.Join("; ", asmbly.GetManifestResourceNames());
                Graphics g2 = musicPanel.CreateGraphics();
                g2.SmoothingMode = SmoothingMode.HighQuality;
                g2.FillEllipse(_highlightBrush, 50 * (i + 1), noteHeight[i], _noteWdth, _noteHght);
                var wav = asmbly.GetManifestResourceStream("SeniorProject.InstrumentWavFiles." + instrument + "." + instrument + noteArray[i] + ".wav");
                using (System.IO.Stream str = wav)
                {
                    SoundPlayer player = new SoundPlayer(str);
                    player.Load();
                    player.Play();
                    await Task.Delay(800);
                }
                g2.FillEllipse(_noteBrush, 50 * (i + 1), noteHeight[i], _noteWdth, _noteHght);
                g2.Dispose();
            }
        }

        private void metronomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Metronome metro = new Metronome(instrument);
            metro.Closed += (s, args) => this.Close();
            musicPanel.Dispose();
            metro.Show();
        }
    }
}

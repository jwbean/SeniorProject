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
        bool major; //1 for major, 0 for minor
        
        public ScaleScreen(Instrument instrument, Scale scale, bool majorOrMinor)
        {
            InitializeComponent();
            this.instrument = instrument;
            this.scale = scale;
            major = majorOrMinor;
                
            //maybe change flute to octave 5 (and possibly alto)
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
                case SeniorProject.Scale.FMajor:
                    noteArray = new[] { "F" + primaryOctave, "G" + primaryOctave, "A" + primaryOctave, "ASharp" + primaryOctave, "C" + (primaryOctave + 1), "D" + (primaryOctave + 1), "E" + (primaryOctave + 1), "F" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.FMinor:
                    noteArray = new[] { "F" + primaryOctave, "G" + primaryOctave, "GSharp" + primaryOctave, "ASharp" + primaryOctave, "C" + (primaryOctave + 1), "CSharp" + (primaryOctave + 1), "DSharp" + (primaryOctave + 1), "F" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.GFlatMajor:
                    noteArray = new[] { "FSharp" + primaryOctave, "GSharp" + primaryOctave, "ASharp" + primaryOctave, "B" + primaryOctave, "CSharp" + (primaryOctave + 1), "DSharp" + (primaryOctave + 1), "F" + (primaryOctave + 1), "FSharp" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.FSharpMinor:
                    noteArray = new[] { "FSharp" + primaryOctave, "GSharp" + primaryOctave, "A" + primaryOctave, "B" + primaryOctave, "CSharp" + (primaryOctave + 1), "D" + (primaryOctave + 1), "E" + (primaryOctave + 1), "FSharp" + (primaryOctave + 1) };
                    break;
                case SeniorProject.Scale.GMajor:
                    noteArray = new[] { "G" + (primaryOctave - 1), "A" + (primaryOctave - 1), "B" + (primaryOctave - 1), "C" + primaryOctave, "D" + primaryOctave, "E" + primaryOctave, "FSharp" + primaryOctave, "G" + primaryOctave };
                    break;
                case SeniorProject.Scale.GMinor:
                    noteArray = new[] { "G" + (primaryOctave - 1), "A" + (primaryOctave - 1), "ASharp" + (primaryOctave - 1), "C" + primaryOctave, "D" + primaryOctave, "DSharp" + primaryOctave, "F" + primaryOctave, "G" + primaryOctave };
                    break;
                case SeniorProject.Scale.AFlatMajor:
                    noteArray = new[] { "GSharp" + (primaryOctave - 1), "ASharp" + (primaryOctave - 1), "C" + primaryOctave, "CSharp" + primaryOctave, "DSharp" + primaryOctave, "F" + primaryOctave, "G" + primaryOctave, "GSharp" + primaryOctave };
                    break;
                case SeniorProject.Scale.GSharpMinor:
                    noteArray = new[] { "GSharp" + (primaryOctave - 1), "ASharp" + (primaryOctave - 1), "B" + (primaryOctave - 1), "CSharp" + primaryOctave, "DSharp" + primaryOctave, "E" + primaryOctave, "FSharp" + primaryOctave, "GSharp" + primaryOctave };
                    break;
                case SeniorProject.Scale.AMajor:
                    noteArray = new[] { "A" + (primaryOctave-1), "B" + (primaryOctave - 1), "CSharp" + primaryOctave, "D" + primaryOctave, "E" + primaryOctave, "FSharp" + primaryOctave, "GSharp" + primaryOctave, "A" + primaryOctave };
                    break;
                case SeniorProject.Scale.AMinor:
                    noteArray = new[] { "A" + (primaryOctave-1), "B" + (primaryOctave-1), "C" + primaryOctave, "D" + primaryOctave, "E" + primaryOctave, "F" + primaryOctave, "G" + primaryOctave, "A" + primaryOctave };
                    break;
                case SeniorProject.Scale.BFlatMajor:
                    noteArray = new[] { "ASharp" + (primaryOctave-1), "C" + primaryOctave, "D" + primaryOctave, "DSharp" + primaryOctave, "F" + primaryOctave, "G" + primaryOctave, "A" + primaryOctave, "ASharp" + primaryOctave };
                    break;
                case SeniorProject.Scale.BFlatMinor:
                    noteArray = new[] { "ASharp" + (primaryOctave-1), "C" + primaryOctave, "CSharp" + primaryOctave, "DSharp" + primaryOctave, "F" + primaryOctave, "FSharp" + primaryOctave, "GSharp" + primaryOctave, "ASharp" + primaryOctave };
                    break;
                case SeniorProject.Scale.BMajor:
                    noteArray = new[] { "B" + (primaryOctave-1), "CSharp" + primaryOctave, "DSharp" + primaryOctave, "E" + primaryOctave, "FSharp" + primaryOctave, "GSharp" + primaryOctave, "ASharp" + primaryOctave, "B" + primaryOctave };
                    break;
                case SeniorProject.Scale.BMinor:
                    noteArray = new[] { "B" + (primaryOctave-1), "CSharp" + primaryOctave, "D" + primaryOctave, "E" + primaryOctave, "FSharp" + primaryOctave, "G" + primaryOctave, "A" + primaryOctave, "B" + primaryOctave };
                    break;
            }
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
                case SeniorProject.Scale.CMinor:
                case SeniorProject.Scale.CMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.bass_clef4; //no flats or sharps
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassEFlatMajor; //three flats
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
                            keySignature.BackgroundImage = Resources.BassFMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassAFlatMajor;
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
                    f_noteHeight();
                    break;
                case SeniorProject.Scale.BFlatMinor:
                case SeniorProject.Scale.BFlatMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassBFlatMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassDFlatMajor;
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
                            keySignature.BackgroundImage = Resources.BassEFlatMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassGFlatMajor;
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
                    e_noteHeight();
                    break;
                case SeniorProject.Scale.GSharpMinor:
                case SeniorProject.Scale.AFlatMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassAFlatMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassBMajor;
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
                            keySignature.BackgroundImage = Resources.BassDFlatMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassEMajor;
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
                        d_noteHeight();
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
                            keySignature.BackgroundImage = Resources.BassGFlatMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassAMajor;
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
                        f_noteHeight();
                    }
                    break;
                case SeniorProject.Scale.BMinor:
                case SeniorProject.Scale.BMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassBMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassDMajor;
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
                            keySignature.BackgroundImage = Resources.BassEMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassGMajor;
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
                    e_noteHeight();
                    break;
                case SeniorProject.Scale.AMinor:
                case SeniorProject.Scale.AMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassAMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.bass_clef4;
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
                            keySignature.BackgroundImage = Resources.BassDMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassFMajor;
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
                    d_noteHeight();
                    break;
                case SeniorProject.Scale.GMinor:
                case SeniorProject.Scale.GMajor:
                    if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
                    {
                        if (major)
                        {
                            keySignature.BackgroundImage = Resources.BassGMajor;
                        }
                        else
                        {
                            keySignature.BackgroundImage = Resources.BassBFlatMajor;
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
        }

        private void a_noteHeight(Graphics g)
        {
            float tubaOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
            }
            g.DrawLine(Pens.Black, 45, 6 * _staffHght, 75, 6 * _staffHght);
            g.DrawLine(Pens.Black, 95, 6 * _staffHght, 125, 6 * _staffHght);
            g.DrawLine(Pens.Black, 145, 6 * _staffHght, 175, 6 * _staffHght);
            noteHeight[0] = (6.6f + tubaOffset) * _staffHght;
            noteHeight[1] = (6 + tubaOffset) * _staffHght;
            noteHeight[2] = (5.6f + tubaOffset) * _staffHght;
            noteHeight[3] = (5 + tubaOffset) * _staffHght;
            noteHeight[4] = (4.6f + tubaOffset) * _staffHght;
            noteHeight[5] = (4 + tubaOffset) * _staffHght;
            noteHeight[6] = (3.6f + tubaOffset) * _staffHght;
            noteHeight[7] = (3 + tubaOffset) * _staffHght;
        }

        private void b_noteHeight(Graphics g)
        {
            float tubaOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
            }
            g.DrawLine(Pens.Black, 45, 6 * _staffHght, 75, 6 * _staffHght);
            g.DrawLine(Pens.Black, 95, 6 * _staffHght, 125, 6 * _staffHght);
            noteHeight[0] = (6 + tubaOffset) * _staffHght;
            noteHeight[1] = (5.6f + tubaOffset) * _staffHght;
            noteHeight[2] = (5 + tubaOffset) * _staffHght;
            noteHeight[3] = (4.6f + tubaOffset) * _staffHght;
            noteHeight[4] = (4 + tubaOffset) * _staffHght;
            noteHeight[5] = (3.6f + tubaOffset) * _staffHght;
            noteHeight[6] = (3 + tubaOffset) * _staffHght;
            noteHeight[7] = (2.6f + tubaOffset) * _staffHght; 
        }

        private void c_noteHeight(Graphics g)
        {
            float tubaOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
            }
            g.DrawLine(Pens.Black, 45, 6 * _staffHght, 75, 6 * _staffHght);           
            noteHeight[0] = (5.6f + tubaOffset) * _staffHght;
            noteHeight[1] = (5 + tubaOffset) * _staffHght;
            noteHeight[2] = (4.6f + tubaOffset) * _staffHght;
            noteHeight[3] = (4 + tubaOffset) * _staffHght;
            noteHeight[4] = (3.6f + tubaOffset) * _staffHght;
            noteHeight[5] = (3 + tubaOffset) * _staffHght;
            noteHeight[6] = (2.6f + tubaOffset) * _staffHght;
            noteHeight[7] = (2 + tubaOffset) * _staffHght;
        }

        private void d_noteHeight()
        {
            float tubaOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
            }
            noteHeight[0] = (5 + tubaOffset) * _staffHght;
            noteHeight[1] = (4.6f + tubaOffset) * _staffHght;
            noteHeight[2] = (4 + tubaOffset) * _staffHght;
            noteHeight[3] = (3.6f + tubaOffset) * _staffHght;
            noteHeight[4] = (3 + tubaOffset) * _staffHght;
            noteHeight[5] = (2.6f + tubaOffset) * _staffHght;
            noteHeight[6] = (2 + tubaOffset) * _staffHght;
            noteHeight[7] = (1.6f + tubaOffset) * _staffHght;
        }

        private void e_noteHeight()
        {
            float tubaOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
            }
            noteHeight[0] = (4.6f + tubaOffset) * _staffHght;
            noteHeight[1] = (4 + tubaOffset) * _staffHght;
            noteHeight[2] = (3.6f + tubaOffset) * _staffHght;
            noteHeight[3] = (3 + tubaOffset) * _staffHght;
            noteHeight[4] = (2.6f + tubaOffset) * _staffHght;
            noteHeight[5] = (2 + tubaOffset) * _staffHght;
            noteHeight[6] = (1.6f + tubaOffset) * _staffHght;
            noteHeight[7] = (1 + tubaOffset) * _staffHght;
        }

        private void f_noteHeight()
        {
            float tubaOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
            }
            noteHeight[0] = (4 + tubaOffset) * _staffHght;
            noteHeight[1] = (3.6f + tubaOffset) * _staffHght;
            noteHeight[2] = (3 + tubaOffset) * _staffHght;
            noteHeight[3] = (2.6f + tubaOffset) * _staffHght;
            noteHeight[4] = (2 + tubaOffset) * _staffHght;
            noteHeight[5] = (1.6f + tubaOffset) * _staffHght;
            noteHeight[6] = (1 + tubaOffset) * _staffHght;
            noteHeight[7] = (0.6f + tubaOffset) * _staffHght;
        }

        private void g_noteHeight(Graphics g, bool gflat)
        {
            float tubaOffset = 0;
            if (instrument == Instrument.Tuba)
            {
                tubaOffset = 1;
            }
            if (gflat)
            {
                noteHeight[0] = (3.6f + tubaOffset) * _staffHght;
                noteHeight[1] = (3 + tubaOffset) * _staffHght;
                noteHeight[2] = (2.6f + tubaOffset) * _staffHght;
                noteHeight[3] = (2 + tubaOffset) * _staffHght;
                noteHeight[4] = (1.6f + tubaOffset) * _staffHght;
                noteHeight[5] = (1 + tubaOffset) * _staffHght;
                noteHeight[6] = (0.6f + tubaOffset) * _staffHght;
                noteHeight[7] = (0.01f + tubaOffset) * _staffHght;
            }
            else
            {
                g.DrawLine(Pens.Black, 45, 6 * _staffHght, 75, 6 * _staffHght);
                g.DrawLine(Pens.Black, 95, 6 * _staffHght, 125, 6 * _staffHght);
                g.DrawLine(Pens.Black, 145, 6 * _staffHght, 175, 6 * _staffHght);
                g.DrawLine(Pens.Black, 195, 6 * _staffHght, 225, 6 * _staffHght);
                noteHeight[0] = (7 + tubaOffset) * _staffHght;
                noteHeight[1] = (6.6f + tubaOffset) * _staffHght;
                noteHeight[2] = (6 + tubaOffset) * _staffHght;
                noteHeight[3] = (5.6f + tubaOffset) * _staffHght;
                noteHeight[4] = (5 + tubaOffset) * _staffHght;
                noteHeight[5] = (4.6f + tubaOffset) * _staffHght;
                noteHeight[6] = (4 + tubaOffset) * _staffHght;
                noteHeight[7] = (3.6f + tubaOffset) * _staffHght;
            }
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
                BassCircleOfFifths scales = new BassCircleOfFifths(instrument, major); //might even need to make own for tuba
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
            else
            {
                TrebleCircleOfFifths scales = new TrebleCircleOfFifths(instrument, major);
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

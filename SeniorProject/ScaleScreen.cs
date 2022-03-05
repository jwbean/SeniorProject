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
        
        public ScaleScreen(int instrumentIndex)
        {
            InitializeComponent();
            this.instrumentIndex = instrumentIndex;
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

            // draw four semi-random full and quarter notes
            g.DrawEllipse(_notePen, 10, 2 * _staffHght, _noteWdth, _noteHght);
            g.DrawEllipse(_notePen, 50, 4 * _staffHght, _noteWdth, _noteHght);
            g.DrawEllipse(_notePen, 10, 3.6f * _staffHght, _noteWdth, _noteHght);

            g.FillEllipse(_noteBrush, 100, 2 * _staffHght, _noteWdth, _noteHght);
            g.FillEllipse(_noteBrush, 150, 4 * _staffHght, _noteWdth, _noteHght);
        }

        private void changeInstrumentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstrumentForm instruments = new InstrumentForm(instrumentIndex);
            instruments.Closed += (s, args) => this.Close();
            instruments.Show();
        }
    }
}

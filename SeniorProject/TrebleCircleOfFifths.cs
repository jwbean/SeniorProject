using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorProject
{
    public partial class TrebleCircleOfFifths : Form
    {
        private Instrument instrument;

        public TrebleCircleOfFifths(Instrument instrument)
        {
            InitializeComponent();
            this.instrument = instrument;
        }

        private void changeInstrumentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstrumentForm instruments = new InstrumentForm(instrument);
            instruments.Closed += (s, args) => this.Close();
            instruments.Show();
        }

        private void CMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale = new ScaleScreen(instrument, SeniorProject.Scale.CMajor);
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void FMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale = new ScaleScreen(instrument, SeniorProject.Scale.FMajor);
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void BFlatMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale = new ScaleScreen(instrument, SeniorProject.Scale.BFlatMajor);
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void EFlatMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale = new ScaleScreen(instrument, SeniorProject.Scale.EFlatMajor);
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void GMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale = new ScaleScreen(instrument, SeniorProject.Scale.GMajor);
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void DMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale = new ScaleScreen(instrument, SeniorProject.Scale.DMajor);
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void majorMinorSwitch_Click(object sender, EventArgs e)
        {
            if (majorOrMinor.Text == "Major Scales")
            {
                majorOrMinor.Text = "Minor Scales";
                majorMinorSwitch.Text = "Switch to Major Scales";
                noFlats.Text = "A";
                oneFlat.Text = "D";
                twoFlats.Text = "G";
                threeFlats.Text = "C";
                fourFlats.Text = "F";
                fiveFlats.Text = "Bb";
                sixFlats.Text = "Eb";
                fiveSharps.Text = "G#";
                fourSharps.Text = "C#";
                threeSharps.Text = "F#";
                twoSharps.Text = "B";
                oneSharp.Text = "E";
            }
            else
            {
                majorOrMinor.Text = "Major Scales";
                majorMinorSwitch.Text = "Switch to Minor Scales";
                noFlats.Text = "C";
                oneFlat.Text = "F";
                twoFlats.Text = "Bb";
                threeFlats.Text = "Eb";
                fourFlats.Text = "Ab";
                fiveFlats.Text = "Db";
                sixFlats.Text = "Gb";
                fiveSharps.Text = "B";
                fourSharps.Text = "E";
                threeSharps.Text = "A";
                twoSharps.Text = "D";
                oneSharp.Text = "G";
            }
        }
    }
}

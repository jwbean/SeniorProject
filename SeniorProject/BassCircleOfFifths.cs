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
    public partial class BassCircleOfFifths : Form
    {
        private Instrument instrument;

        public BassCircleOfFifths(Instrument instrument, bool major)
        {
            InitializeComponent();
            this.instrument = instrument;
            if(!major)
            {
                majorMinorSwitch_Click(null, EventArgs.Empty);
            }

            switch (instrument)
            {
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
        }

        private void changeInstrumentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstrumentForm instruments = new InstrumentForm(instrument);
            instruments.Closed += (s, args) => this.Close();
            instruments.Show();
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

        private void excerptsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoloExcerpts excerpts = new SoloExcerpts(instrument);
            excerpts.Closed += (s, args) => this.Close();
            excerpts.Show();
        }

        private void CMajor_Click(object sender, EventArgs e) //C Major or A Minor
        {
            this.Hide();
            ScaleScreen scale;
            if (majorOrMinor.Text == "Major Scales")
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.CMajor, true);
            }
            else
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.AMinor, false);
            }
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void FMajor_Click(object sender, EventArgs e) //F Major or D Minor
        {
            this.Hide();
            ScaleScreen scale;
            if (majorOrMinor.Text == "Major Scales")
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.FMajor, true);
            }
            else
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.DMinor, false);
            }
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void BFlatMajor_Click(object sender, EventArgs e) //BFlat Major or G Minor
        {
            this.Hide();
            ScaleScreen scale;
            if (majorOrMinor.Text == "Major Scales")
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.BFlatMajor, true);
            }
            else
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.GMinor, false);
            }
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void EFlatMajor_Click(object sender, EventArgs e) //EFlat Major or C Minor
        {
            this.Hide();
            ScaleScreen scale;
            if (majorOrMinor.Text == "Major Scales")
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.EFlatMajor, true);
            }
            else
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.CMinor, false);
            }
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void GMajor_Click(object sender, EventArgs e) //G Major or E Minor
        {
            this.Hide();
            ScaleScreen scale;
            if (majorOrMinor.Text == "Major Scales")
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.GMajor, true);
            }
            else
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.EMinor, false);
            }
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void DMajor_Click(object sender, EventArgs e) //D Major or B Minor
        {
            this.Hide();
            ScaleScreen scale;
            if (majorOrMinor.Text == "Major Scales")
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.DMajor, true);
            }
            else
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.BMinor, false);
            }
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void AFlatMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale;
            if (majorOrMinor.Text == "Major Scales")
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.AFlatMajor, true);
            }
            else
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.FMinor, false);
            }
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void DFlatMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale;
            if (majorOrMinor.Text == "Major Scales")
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.DFlatMajor, true);
            }
            else
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.BFlatMinor, false);
            }
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void GFlatMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale;
            if (majorOrMinor.Text == "Major Scales")
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.GFlatMajor, true);
            }
            else
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.EFlatMinor, false);
            }
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void BMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale;
            if (majorOrMinor.Text == "Major Scales")
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.BMajor, true);
            }
            else
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.GSharpMinor, false);
            }
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void EMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale;
            if (majorOrMinor.Text == "Major Scales")
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.EMajor, true);
            }
            else
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.CSharpMinor, false);
            }
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void AMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale;
            if (majorOrMinor.Text == "Major Scales")
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.AMajor, true);
            }
            else
            {
                scale = new ScaleScreen(instrument, SeniorProject.Scale.FSharpMinor, false);
            }
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }
    }
}

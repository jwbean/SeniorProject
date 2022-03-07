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
        private int instrumentIndex;

        public TrebleCircleOfFifths(int instrumentIndex)
        {
            InitializeComponent();
            this.instrumentIndex = instrumentIndex;
        }

        private void changeInstrumentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstrumentForm instruments = new InstrumentForm(instrumentIndex);
            instruments.Closed += (s, args) => this.Close();
            instruments.Show();
        }

        private void CMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale = new ScaleScreen(instrumentIndex, SeniorProject.Scale.CMajor);
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void FMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale = new ScaleScreen(instrumentIndex, SeniorProject.Scale.FMajor);
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void BFlatMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale = new ScaleScreen(instrumentIndex, SeniorProject.Scale.BFlatMajor);
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void EFlatMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale = new ScaleScreen(instrumentIndex, SeniorProject.Scale.EFlatMajor);
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void GMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale = new ScaleScreen(instrumentIndex, SeniorProject.Scale.GMajor);
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }

        private void DMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScaleScreen scale = new ScaleScreen(instrumentIndex, SeniorProject.Scale.DMajor);
            scale.Closed += (s, args) => this.Close();
            scale.Show();
        }
    }
}

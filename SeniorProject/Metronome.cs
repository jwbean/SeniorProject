using SeniorProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorProject
{
    public partial class Metronome : Form
    {
        private bool buttonClicked = false;
        private Instrument instrument;
        
        public Metronome(Instrument instrument)
        {
            InitializeComponent();
            this.instrument = instrument;
        }

        private async void playButton_Click(object sender, EventArgs e)
        {
            if (!buttonClicked)
            {
                buttonClicked = true;
                playButton.BackgroundImage = Resources.stopIcon;
                var asmbly = Assembly.GetExecutingAssembly();
                var wav = asmbly.GetManifestResourceStream("SeniorProject.InstrumentWavFiles.MetronomeClick.wav");
                using (System.IO.Stream str = wav)
                {
                    decimal bpm = tempoSelect.Value;
                    decimal millis = (1 / (bpm / 60)) * 1000;
                    SoundPlayer player = new SoundPlayer(str);
                    while (buttonClicked)
                    {
                        metroLight.BackColor = Color.Green;
                        player.Load();
                        player.Play();
                        await Task.Delay((int)(millis / 2));
                        metroLight.BackColor = Color.White;
                        await Task.Delay((int)(millis / 2));                      
                    }
                }
            }
            else
            {
                buttonClicked = false;
                playButton.BackgroundImage = Resources.playIcon;
            }
        }

        private void changeInstrumentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstrumentForm instruments = new InstrumentForm(instrument);
            instruments.Closed += (s, args) => this.Close();
            instruments.Show();
        }

        private void circleOfFifths_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (instrument == Instrument.Bassoon || instrument == Instrument.Trombone || instrument == Instrument.Tuba)
            {
                BassCircleOfFifths scales = new BassCircleOfFifths(instrument, true); //might even need to make own for tuba
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
            else
            {
                TrebleCircleOfFifths scales = new TrebleCircleOfFifths(instrument, true); //might even need to make own for tuba
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
        }
    }
}

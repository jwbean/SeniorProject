using SeniorProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorProject
{
    public partial class InstrumentForm : Form
    {
        public InstrumentForm()
        {
            InitializeComponent();
            instrumentList.Items.Add("Alto Sax");
            instrumentList.Items.Add("Bassoon");
            instrumentList.Items.Add("Clarinet");
            instrumentList.Items.Add("Flute");
            instrumentList.Items.Add("French Horn");
            instrumentList.Items.Add("Oboe");
            instrumentList.Items.Add("Tenor Sax");
            instrumentList.Items.Add("Trombone");
            instrumentList.Items.Add("Trumpet");
            instrumentList.Items.Add("Tuba");
            instrumentList.SelectedIndex = 0;
        }

        private void instrumentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (instrumentList.SelectedItem.ToString())
            {
                case "Alto Sax":
                    instrumentPicture.BackgroundImage = Properties.Resources.AltoSax;
                    break;
                case "Bassoon":
                    instrumentPicture.BackgroundImage = Properties.Resources.Bassoon;
                    break;
                case "Clarinet":
                    instrumentPicture.BackgroundImage = Properties.Resources.Clarinet;
                    break;
                case "French Horn":
                    instrumentPicture.BackgroundImage = Properties.Resources.FrenchHorn;
                    break;
                case "Flute":
                    instrumentPicture.BackgroundImage = Properties.Resources.Flute;
                    break;
                case "Oboe":
                    instrumentPicture.BackgroundImage = Properties.Resources.Oboe;
                    break;
                case "Tenor Sax":
                    instrumentPicture.BackgroundImage = Properties.Resources.TenorSax;
                    break;
                case "Trombone":
                    instrumentPicture.BackgroundImage = Properties.Resources.Trombone;
                    break;
                case "Trumpet":
                    instrumentPicture.BackgroundImage = Properties.Resources.Trumpet;
                    break;
                case "Tuba":
                    instrumentPicture.BackgroundImage = Properties.Resources.Tuba;
                    break;
                default:
                    break;
            }
        }

        private void advanceButton_Click(object sender, EventArgs e)
        {
            //research the possibility of having one form and adjusting the scale within it based on passed parameter
            this.Hide();
            string instr = instrumentList.SelectedItem.ToString();
            if (instr == "Flute" || instr == "Oboe")
            {
                ConcertCircleOfFifths scales = new ConcertCircleOfFifths(); //make treble clef version and bass for others
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
            else if (instr == "Bassoon" || instr == "Trombone" || instr == "Tuba")
            {
                ConcertCircleOfFifths scales = new ConcertCircleOfFifths(); //might even need to make own for tuba
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
            else if (instr == "Alto Sax")
            {
                EFlatCircleOfFifths scales = new EFlatCircleOfFifths();
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
            else if (instr == "Clarinet" || instr == "Trumpet" || instr == "Tenor Sax")
            {
                BFlatCircleOfFifths scales = new BFlatCircleOfFifths();
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
            else if (instr == "French Horn")
            {
                FCircleOfFifths scales = new FCircleOfFifths();
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
        }
    }
}

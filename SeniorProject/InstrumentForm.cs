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
        }

        private void instrumentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (instrumentList.SelectedItem.ToString())
            {
                case "Alto Sax":
                    instrumentPicture.BackgroundImage = Properties.Resources.AltoSax;
                    break;
                case "Flute":
                    instrumentPicture.BackgroundImage = Properties.Resources.AdjustedFlute;
                    break;
                case "Trombone":
                    instrumentPicture.BackgroundImage = Properties.Resources.AdjustedTrombone;
                    break;
                case "Trumpet":
                    instrumentPicture.BackgroundImage = Properties.Resources.AdjustedTrumpet;
                    break;
                default:
                    break;
            }
        }
    }
}

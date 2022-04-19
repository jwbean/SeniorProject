using SeniorProject.Models;
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
    public partial class SoloExcerpts : Form
    {
        private Instrument instrument;
        
        public SoloExcerpts(Instrument instrument)
        {
            InitializeComponent();
            this.instrument = instrument;
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
            
            List<Excerpt> excerpts = ExcerptCollection.getExcerpts(instrumentName.Text, null);
            for (int i = 0; i < excerpts.Count; i++)
            {
                Excerpt e = excerpts[i];
                string[] row = { "", e.ExcerptTitle, e.Composer, e.YearPublished.ToString(), e.Difficulty.ToString(), e.StoreLink };
                var listViewItem = new ListViewItem(row);
                listViewItem.Font = new Font(listViewItem.Font, FontStyle.Regular);
                excerptListView.Items.Add(listViewItem);
            }
            int listViewWidth = 0;
            for (int j = 1; j < 6; j++)
            {
                if (j < 3 || j == 5)
                {
                    excerptListView.AutoResizeColumn(j, ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else
                {
                    excerptListView.AutoResizeColumn(j, ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                var columns = excerptListView.Columns;
                listViewWidth += columns[j].Width;
            }
            excerptListView.Width = listViewWidth;
            if (excerptListView.Width > 900)
            {
                excerptListView.Width = 900;
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

        private void excerptListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) //to prevent users from changing column width
        {
            e.Cancel = true;
            e.NewWidth = excerptListView.Columns[e.ColumnIndex].Width;
        }
    }
}

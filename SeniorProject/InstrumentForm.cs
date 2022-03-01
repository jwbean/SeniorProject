﻿using System;
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
            if (instrumentList.SelectedItem.ToString() == "Flute")
            {
                this.Hide();
                ConcertCircleOfFifths scales = new ConcertCircleOfFifths();
                scales.Closed += (s, args) => this.Close();
                scales.Show();
            }
        }
    }
}

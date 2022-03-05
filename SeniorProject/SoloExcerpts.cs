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
        private int instrumentIndex;
        
        public SoloExcerpts(int instrumentIndex)
        {
            InitializeComponent();
            this.instrumentIndex = instrumentIndex;
            /*using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Excerpt>("dbo.RetrieveUsers").ToList();
                return output;
            }*/
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

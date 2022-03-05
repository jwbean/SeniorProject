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
        public SoloExcerpts()
        {
            InitializeComponent();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Excerpt>("dbo.RetrieveUsers").ToList();
                return output;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveopsAttendanceBasic
{
    public partial class LiveopsAttendance : Form
    {
        public LiveopsAttendance()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            AnalyzerProcessor ap = new AnalyzerProcessor();
            var scheduledAgents = ap.GetStringArray(tbScheduledAgents.Text);
            var presentAgents = ap.GetStringArrayPresent(tbAgentsPresent.Text);
            var absent = ap.IsAbsent(scheduledAgents, presentAgents);
            tbAgentsAbsent.Text = ap.DisplayAgents(absent);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbScheduledAgents.Clear();
            tbAgentsPresent.Clear();
            tbAgentsAbsent.Clear();
        }
    }
}

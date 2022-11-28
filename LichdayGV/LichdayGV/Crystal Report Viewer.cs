using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions;
using CrystalDecisions.CrystalReports.Engine;

namespace LichdayGV
{
    public partial class Crystal_Report_Viewer : Form
    {
        public Crystal_Report_Viewer()
        {
            InitializeComponent();
        }

        private void Crystal_Report_Viewer_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            string path = string.Format("{0}\\Report\\CrystalReport1.rpt", Application.StartupPath);
            report.Load(path);

            report.SetParameterValue("tennguoilapbieu","Phuong");
            crystalReportViewer1.ReportSource = report;

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRCApp
{
    public partial class report : Form
    {
        // -----------------------demographic--------------------
        int[] rent = new int[13];
        int[] Mortgage = new int[13];
        int[] electric = new int[13];
        int[] water = new int[13];
        int[] natgas = new int[13];
        int[] prescirption = new int[13];
        int[] transportation = new int[13];
        int[] docs = new int[13];
        int[] shelter = new int[13];
        int[] repair = new int[13];
       // -----------------------primaryIncome--------------------
        int[] goverment = new int[13];
        int[] Employment = new int[13];
        int[] Mixed = new int[13];
        int[] noincome = new int[13];
        int[] otherIncome = new int[13];
        public report(int year)
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            SearchRequest(DateTime.Now.Year);
            SearchPrimaryIncome(DateTime.Now.Year);
            SearchDemographicStats(DateTime.Now.Year);
        }

        private void SearchRequest(int year)
        {
            lstviewAssistance.Items.Clear();
            var request = new DataSet1TableAdapters.RequestsReportByYearTableAdapter().GetRequestsReportByYear(year);
            foreach(var cntrequest in request)
            {
                        ListViewItem item = new ListViewItem (cntrequest.Type);
                        String[] data = { cntrequest.January.ToString(), cntrequest.February.ToString(), cntrequest.March.ToString(), cntrequest.April.ToString(), cntrequest.May.ToString(), cntrequest.June.ToString(), cntrequest.July.ToString(), cntrequest.August.ToString(), cntrequest.September.ToString(), cntrequest.October.ToString(), cntrequest.November.ToString(), cntrequest.December.ToString(), cntrequest.YTD.ToString() };
                        item.SubItems.AddRange(data);
                        lstviewAssistance.Items.Add(item);
                        if (item.Index % 2 == 0)
                        { item.BackColor = Color.Gainsboro; }
                        else
                        { item.BackColor = Color.WhiteSmoke; }
            }

        }
        private void SearchPrimaryIncome(int year)
        {
            lstPrimaryIncome.Items.Clear();
            var incomeAdapter = new DataSet1TableAdapters.RequestsReportByYearTableAdapter();
            var primaryIncomes = incomeAdapter.GetMonthlyPrimaryIncomeSourceByYear(year);
            foreach (var income in primaryIncomes)
            {
                ListViewItem item = new ListViewItem(income.Type);
                String[] data = { income.January.ToString(), income.February.ToString(), income.March.ToString(), income.April.ToString(), income.May.ToString(), income.June.ToString(), income.July.ToString(), income.August.ToString(), income.September.ToString(), income.October.ToString(), income.November.ToString(), income.December.ToString(), income.YTD.ToString() };
                item.SubItems.AddRange(data);
                lstPrimaryIncome.Items.Add(item);
                if (item.Index % 2 == 0)
                { item.BackColor = Color.Gainsboro; }
                else
                { item.BackColor = Color.WhiteSmoke; }
            }
        }

        private void SearchDemographicStats(int year)
        {
            lstViewDemographic.Items.Clear();
            var reportAdapter = new DataSet1TableAdapters.RequestsReportByYearTableAdapter();
            var requestsSubmitted = reportAdapter.GetMonthlyRequestsCountByYear(year)[0];
            var requestsApproved = reportAdapter.GetMonthlyRequestsApprovedByYear(year)[0];
            var householdsPerMonth = reportAdapter.GetMonthlyHouseholdsApplyingByYear(year)[0];
            var firstTimeInYear = reportAdapter.GetMonthlyFirstTimeApplyingInYearByYear(year)[0];
            var firstTimeEver = reportAdapter.GetMonthlyFirstTimeApplyingEverByYear(year)[0];
            DataSet1.RequestsReportByYearRow[] rows = {requestsSubmitted, requestsApproved, householdsPerMonth, firstTimeInYear, firstTimeEver};
            foreach (var row in rows)
            {
                ListViewItem item = new ListViewItem(row.Type);
                String[] data = { row.January.ToString(), row.February.ToString(), row.March.ToString(), row.April.ToString(), row.May.ToString(), row.June.ToString(), row.July.ToString(), row.August.ToString(), row.September.ToString(), row.October.ToString(), row.November.ToString(), row.December.ToString(), row.YTD.ToString() };
                item.SubItems.AddRange(data);
                lstViewDemographic.Items.Add(item);
                if (item.Index % 2 == 0)
                { item.BackColor = Color.Gainsboro; }
                else
                { item.BackColor = Color.WhiteSmoke; }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchRequest(DtpickerYear.Value.Year);
            SearchPrimaryIncome(DtpickerYear.Value.Year);
            SearchDemographicStats(DtpickerYear.Value.Year);
        }

        private void btn_export_Click(object sender, EventArgs e) {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "csv files (*.csv)|*.csv";
            dialog.FilterIndex = 0;
            dialog.RestoreDirectory = true;

            int year = DtpickerYear.Value.Year;

            if (dialog.ShowDialog() == DialogResult.OK) {
                if (dialog.CheckPathExists) {
                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine(string.Format("Program Service and Demographic Report by Month,Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec,{0} YTD",year));

                    var reportAdapter = new DataSet1TableAdapters.RequestsReportByYearTableAdapter();
                    var requestsSubmitted = reportAdapter.GetMonthlyRequestsCountByYear(year)[0];
                    var requestsApproved = reportAdapter.GetMonthlyRequestsApprovedByYear(year)[0];
                    var householdsPerMonth = reportAdapter.GetMonthlyHouseholdsApplyingByYear(year)[0];
                    var firstTimeInYear = reportAdapter.GetMonthlyFirstTimeApplyingInYearByYear(year)[0];
                    var firstTimeEver = reportAdapter.GetMonthlyFirstTimeApplyingEverByYear(year)[0];
                    DataSet1.RequestsReportByYearRow[] rows = { requestsSubmitted, requestsApproved, householdsPerMonth, firstTimeInYear, firstTimeEver };
                    foreach (var row in rows) {
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}", row.Type, row.January.ToString(), row.February.ToString(), row.March.ToString(), row.April.ToString(), row.May.ToString(), row.June.ToString(), row.July.ToString(), row.August.ToString(), row.September.ToString(), row.October.ToString(), row.November.ToString(), row.December.ToString(), row.YTD.ToString()));
                    }

                    sb.AppendLine("Types of Assistance Requested");

                    var request = new DataSet1TableAdapters.RequestsReportByYearTableAdapter().GetRequestsReportByYear(year);
                    foreach (var cntrequest in request) {
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",cntrequest.Type,cntrequest.January.ToString(), cntrequest.February.ToString(), cntrequest.March.ToString(), cntrequest.April.ToString(), cntrequest.May.ToString(), cntrequest.June.ToString(), cntrequest.July.ToString(), cntrequest.August.ToString(), cntrequest.September.ToString(), cntrequest.October.ToString(), cntrequest.November.ToString(), cntrequest.December.ToString(), cntrequest.YTD.ToString()));
                    }

                    sb.AppendLine("Primary Income of Household");

                    var incomeAdapter = new DataSet1TableAdapters.RequestsReportByYearTableAdapter();
                    var primaryIncomes = incomeAdapter.GetMonthlyPrimaryIncomeSourceByYear(year);
                    foreach (var income in primaryIncomes) {
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",income.Type,income.January.ToString(), income.February.ToString(), income.March.ToString(), income.April.ToString(), income.May.ToString(), income.June.ToString(), income.July.ToString(), income.August.ToString(), income.September.ToString(), income.October.ToString(), income.November.ToString(), income.December.ToString(), income.YTD.ToString()));
                    }
                    try {
                        File.WriteAllText(dialog.FileName, sb.ToString());
                    }
                    catch (Exception) {
                        MessageBox.Show("Error writing to file.");
                    }
                }
            }
        }
    }

    public class MonthReport
    {
    
    
    }
}

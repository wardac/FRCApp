using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void SearchRequest(int year)
        {
            var request = new DataSet1TableAdapters.RequestsReportByYearTableAdapter().GetRequestsReportByYear(year);
            foreach(var cntrequest in request)
            {
                        ListViewItem item = new ListViewItem (cntrequest.Type);
                        String[] data = { cntrequest.January.ToString(), cntrequest.February.ToString(), cntrequest.March.ToString(), cntrequest.April.ToString(), cntrequest.May.ToString(), cntrequest.June.ToString(), cntrequest.July.ToString(), cntrequest.August.ToString(), cntrequest.September.ToString(), cntrequest.October.ToString(), cntrequest.November.ToString(), cntrequest.December.ToString(), cntrequest.YTD.ToString() };
                        item.SubItems.AddRange(data);
                        lstviewAssistance.Items.Add(item);
            }

        }
        private void SearchPrimaryIncome(int year)
        { 
        
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }
    }

    public class MonthReport
    {
    
    
    }
}

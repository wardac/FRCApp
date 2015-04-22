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
            SearchAssistance(DateTime.Now.Year);
                SearchPrimaryIncome(DateTime.Now.Year);
        }

        private void SearchAssistance(int year)
        {
            DataSet1 ds = new DataSet1();
            //DataSet1.EFARequestsDataTable dt;

            try
            {
                var requestcnt = new DataSet1TableAdapters.EFASubrequestsTableAdapter().getRentReportbyYear(2015);
            }
            catch (ConstraintException e)
            {
                MessageBox.Show(e.ToString());
            }
            int ids = 0;
        //    foreach (var cntRequest in requestcnt)
            {
                ids++;
                //  rent[i] =cntRequest.cntVal
            }
        }
        private void SearchPrimaryIncome(int year)
        { 
        
        }
    }

    public class MonthReport
    {
    
    
    }
}

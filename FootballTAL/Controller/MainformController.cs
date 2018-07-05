using FootballTAL.BusinessLogic;
using FootballTAL.Data;
using FootballTAL.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballTAL.Controller
{
    
   public class MainformController 
    {
        private FootballClubArray clubArray { get; set; }
        private MainForm myView { get; set; }
        public MainformController (MainForm view)
        {
            myView = view;
            clubArray = new FootballClubArray();
            myView.GVFields.AllowUserToResizeColumns = false;
        }
        public FootballClubArray GetClubArray()
        {
            return clubArray;
        }
        public void FileSelection_Click()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "CSV Files|*.CSV;*.csv";
                if (openFileDialog.ShowDialog(myView) == DialogResult.OK)
                {
                    myView.TBPath.Text = openFileDialog.FileName;
                }
            }
        }
        public bool IsFileSelectionEmpty()
        {
            if (string.IsNullOrWhiteSpace(myView.TBPath.Text))
                return true;
            myView.ErrorLabel.Text = string.Empty;
            myView.GVFields.Rows.Clear();
            return false;
        }

        public void showResult()
        {
            var calResults = new FindDifference().FindSmallestForAgainst(clubArray.GetFootballClubList(new CSVFileReading(myView.TBPath.Text)));

            if (calResults.Count() == 0)
            {
                myView.ErrorLabel.Text = Properties.Resources.NoOuput;
                return;
            }
            if (clubArray.GetContainsError() && myView.CBContinueOnError.Checked == false)
            {
                myView.ErrorLabel.Text = Properties.Resources.ErrorRecordFoundStop;
                return;
            }
            if (clubArray.GetContainsError() && myView.CBContinueOnError.Checked == true)
                myView.ErrorLabel.Text = Properties.Resources.ErrorRecordFoundGoOn;
            var bindingList = new BindingList<FootballClubExtenions>(calResults).Select(i => new { i.ClubName, i.DifferenceFA });//only show 2 fields to grid
            myView.GVFields.DataSource = new BindingSource(bindingList, null);

        }
        public void BtnClear_click()
        {
            myView.TBPath.Text = string.Empty;
            myView.GVFields.Rows.Clear();
            myView.ErrorLabel.Text = string.Empty;
        }
    }
}

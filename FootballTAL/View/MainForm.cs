using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballTAL.BusinessLogic;
using FootballTAL.Controller;
using FootballTAL.Data;
using FootballTAL.DataAccess;

namespace FootballTAL
{
    public partial class MainForm : Form
    {
        MainformController mc;
        public MainForm()
        {
            InitializeComponent();
            mc = new MainformController(this);
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            mc.FileSelection_Click();
        }

        private void BTNCal_Click(object sender, EventArgs e)
        {
            if (!mc.IsFileSelectionEmpty())
                mc.showResult();
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            mc.BtnClear_click();
        }
    }
}

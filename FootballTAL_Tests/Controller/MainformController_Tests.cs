using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballTAL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace FootballTAL.Controller.Tests
{
    [TestClass()]
    public class MainformController_Tests
    {
        string validFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\football.csv");

        [TestMethod()]
        public void MainformController_ConstructorTest()
        {
            var mc = new MainformController(new MainForm());

            Assert.IsTrue(mc.GetClubArray() != null);
        }

        [TestMethod()]
        public void IsFileSelectionEmpty_Test()
        {
            var mc = new MainformController(new MainForm());
            Assert.IsTrue(mc.IsFileSelectionEmpty());
        }
        [TestMethod()]
        public void IsFileSelectionEmpty_Test2()
        {
            var mainForm = new MainForm();
            mainForm.TBPath.Text = "sth";
            var mc = new MainformController(mainForm);
            Assert.AreEqual(false, mc.IsFileSelectionEmpty());
        }

        [TestMethod()]
        public void BtnClear_click_Test()
        {
            var mainForm = new MainForm();
            mainForm.TBPath.Text = "sth";
            mainForm.GVFields.Rows.Add("test");
            mainForm.ErrorLabel.Text = "sth";
            var mc = new MainformController(mainForm);
            mc.BtnClear_click();
            Assert.AreEqual(string.Empty, mainForm.TBPath.Text);
            Assert.AreEqual(string.Empty, mainForm.ErrorLabel.Text);
            Assert.AreEqual(0, mainForm.GVFields.Rows.Count);
        }

        [TestMethod()]
        public void showResult_Test()
        {
            var mainForm = new MainForm();
            mainForm.TBPath.Text = validFile;
            var mc = new MainformController(mainForm);
            mc.showResult();
            Assert.AreEqual(2, mainForm.GVFields.RowCount);
        }
    }
}
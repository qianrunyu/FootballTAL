using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballTAL.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTAL.BusinessLogic.Tests
{
    [TestClass()]
    public class CreateFootballClub_Tests
    {
        [TestMethod()]
        public void CreateClub_ValidInput()
        {
            var tester = new CreateFootballClub();
            var output= tester.CreateClub(new string[] {"1. ClubName","1","2","3","4","5","-","6","7" });
            Assert.AreEqual(1, output.ClubRank);
            Assert.AreEqual("ClubName", output.ClubName);
            Assert.AreEqual(1, output.P);
            Assert.AreEqual(2, output.W);
            Assert.AreEqual(3, output.L);
            Assert.AreEqual(4, output.D);
            Assert.AreEqual(5, output.F);
            Assert.AreEqual(6, output.A);
            Assert.AreEqual(7, output.Pts);
            Assert.AreEqual(false, output.ErrorFound);
        }

        [TestMethod()]
        public void CreateClub_InValidInput_integer()
        {
            var tester = new CreateFootballClub();
            var output = tester.CreateClub(new string[] { "1. ClubName", "1b", "2", "3d", "4", "5", "-", "6", "7" });
            Assert.AreNotEqual(1, output.ClubRank);
            Assert.AreEqual(true, output.ErrorFound);
        }
        [TestMethod()]
        public void CreateClub_InValidInput_ShorterFields()
        {
            var tester = new CreateFootballClub();
            var output = tester.CreateClub(new string[] { "1. ClubName", "1", "2", "3", "4", "5", "-"});
            Assert.AreNotEqual(1, output.ClubRank);
            Assert.AreEqual(true, output.ErrorFound);
        }
    }
}
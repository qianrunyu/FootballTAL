using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballTAL.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballTAL.Data;

namespace FootballTAL.BusinessLogic.Tests
{
    [TestClass()]
    public class FindDifference_Tests
    {
        [TestMethod()]
        public void FindSmallestForAgainst_ContainsInvlidRecords()
        {
            var input = new List<FootballClubExtenions>();
            input.Add(new FootballClubExtenions() { ErrorFound=true});
            input.Add(new FootballClubExtenions() { F=12,A=20 });
            input.Add(new FootballClubExtenions() {F=30,A=28 });
            var tester = new FindDifference();
            var output=tester.FindSmallestForAgainst(input);
            Assert.AreEqual(1,output.Count());
        }
        [TestMethod()]
        public void FindSmallestForAgainst_ContainsValidRecords()
        {
            var input = new List<FootballClubExtenions>();
            input.Add(new FootballClubExtenions() { F=10,A=12 });
            input.Add(new FootballClubExtenions() { F = 30,A=31 });
            input.Add(new FootballClubExtenions() { F = 30, A = 28 });
            var tester = new FindDifference();
            var output = tester.FindSmallestForAgainst(input);
            Assert.AreEqual(1, output.Count());
        }
        [TestMethod()]
        public void FindSmallestForAgainst_ContainsMultiOutput()
        {
            var input = new List<FootballClubExtenions>();
            input.Add(new FootballClubExtenions() { F = 10, A = 12 });
            input.Add(new FootballClubExtenions() { F = 30, A = 32 });
            input.Add(new FootballClubExtenions() { F = 30, A = 28 });
            var tester = new FindDifference();
            var output = tester.FindSmallestForAgainst(input);
            Assert.AreEqual(3, output.Count());
        }
        [TestMethod()]
        public void FindSmallestForAgainst_GetDifference()
        {
            var input = new List<FootballClubExtenions>();
            input.Add(new FootballClubExtenions() { F = 10, A = 12 });
            input.Add(new FootballClubExtenions() { F = 5, A = 6 });
            input.Add(new FootballClubExtenions() { F = 30, A = 28 });
            var tester = new FindDifference();
            var output = tester.FindSmallestForAgainst(input);
            Assert.AreEqual(1, output.Count());
            Assert.AreEqual(1, output[0].DifferenceFA);
        }
    }
}
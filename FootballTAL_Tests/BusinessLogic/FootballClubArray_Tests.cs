using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballTAL.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using FootballTAL.DataAccess;
using Moq;

namespace FootballTAL.BusinessLogic.Tests
{
    [TestClass()]
    public class FootballClubArray_Tests
    {
        string validFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\football.csv");
        string FileMissingHeader = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\football_NoTitle.csv");
        string FileWrongColumnCount = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\football_ColumnCountErr.csv");
        string FileCellError = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\football_CellError.csv");

        [TestMethod()]
        public void GetFootballClubList_FootballClubListIsNull()
        {
            var tester = new FootballClubArray();

            Assert.AreEqual(false,tester.GetContainsError());
        }
        [TestMethod()]
        public void GetFootballClubList_ValidInput()
        {
            var tester = new FootballClubArray();
            var output=tester.GetFootballClubList(new CSVFileReading(validFile));
            Assert.AreEqual(20, output.Count);
            Assert.AreEqual(0, output.Where(i => i.ErrorFound).Count());
            Assert.AreEqual(false, tester.GetContainsError());
        }
        [TestMethod()]
        public void GetFootballClubList_MissingHeader()
        {
            var tester = new FootballClubArray();
            var ouput = tester.GetFootballClubList(new CSVFileReading(FileMissingHeader));
            Assert.AreEqual(20, ouput.Count);
            Assert.AreEqual(0, ouput.Where(i => i.ErrorFound).Count());
            Assert.AreEqual(false, tester.GetContainsError());

        }
        [TestMethod()]
        public void GetFootballClubList_CellFormatError()
        {
            var tester = new FootballClubArray();
            var ouput = tester.GetFootballClubList(new CSVFileReading(FileCellError));
            Assert.AreEqual(20, ouput.Count);
            Assert.AreEqual(2, ouput.Where(i => i.ErrorFound).Count());
            Assert.AreEqual(true, tester.GetContainsError());
        }
        [TestMethod()]
        public void GetFootballClubList_WrongColumnCount()
        {
            var tester = new FootballClubArray();
            var ouput = tester.GetFootballClubList(new CSVFileReading(FileCellError));
            Assert.AreEqual(20, ouput.Count);
            Assert.AreEqual(2, ouput.Where(i=>i.ErrorFound).Count());
            Assert.AreEqual(true, tester.GetContainsError());
        }
        [TestMethod()]
        public void GetFootballClubList_moq()
        {
            var list = new List<string[]>();
            list.Add(new string[] { "1. ClubName", "1", "2", "3", "4", "5", "-", "6", "7" });
            list.Add(new string[] { "1. ClubName", "11", "22", "33", "44", "55", "-", "66", "77" });
            var mock = new Mock<IFileReading>();
            mock.Setup(x => x.ReadFile()).Returns(list);
            var tester = new FootballClubArray();
            var ouput = tester.GetFootballClubList(mock.Object);
            Assert.AreEqual(mock.Object.ReadFile().Count, 2);
            Assert.AreEqual(ouput.Count,2);
            Assert.AreEqual( ouput.Where(i => i.ErrorFound).Count(),0);

        }
    }
}
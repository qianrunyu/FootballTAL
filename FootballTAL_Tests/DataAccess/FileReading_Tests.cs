using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballTAL.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace FootballTAL.DataAccess.Tests
{
    [TestClass()]
    public class CSVFileReading_Tests
    {
        string validFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\football.csv");
        string FileMissingHeader = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\football_NoTitle.csv");
        string FileWrongColumnCount = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\football_ColumnCountErr.csv");
        string FileCellError = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\football_CellError.csv");


        [TestMethod()]
        public void ReadFile_TestNoErrorInFile()
        {
            var tester = new CSVFileReading(validFile);
            Assert.AreEqual(20, tester.ReadFile().Count);
        }
        [TestMethod()]
        public void ReadFile_TestMissingHeader()
        {
            var tester = new CSVFileReading(FileMissingHeader);
            Assert.AreEqual(20, tester.ReadFile().Count);
        }
        [TestMethod()]
        public void ReadFile_TestColumnCountError()
        {
            var tester = new CSVFileReading(FileWrongColumnCount);
            Assert.AreEqual(20, tester.ReadFile().Count);
        }
        [TestMethod()]
        public void ReadFile_TestCellError()
        {
            var tester = new CSVFileReading(FileCellError);
            Assert.AreEqual(20, tester.ReadFile().Count);
        }
    }
}
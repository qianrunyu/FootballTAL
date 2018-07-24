using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTAL.DataAccess
{
    public class DatFileReading : IFileReading
    {

        private string FullPath { get; set; }
        public DatFileReading(string path)
        {
            this.FullPath = path;
        }
        public IList<string[]> ReadFile()
        {
            List<string[]> fileContent = new List<string[]>();
            using (StreamReader reader = new StreamReader(FullPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var rowArray = line.Split(new[] { " "}, StringSplitOptions.RemoveEmptyEntries);
                    if (rowArray[0].ToString().ToLower() == "team" || line.Contains("------------"))
                        continue; //reach "----" or title row
                    var temp = new List<string>();
                    temp.Add(rowArray[0] + rowArray[1]);
                    for(int i=2;i<rowArray.Length;i++)
                    {
                        temp.Add(rowArray[i]);
                    }
                    fileContent.Add(temp.ToArray());
                }
                return fileContent;
            }

        }
    }
}

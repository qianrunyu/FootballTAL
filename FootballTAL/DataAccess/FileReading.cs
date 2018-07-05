using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

namespace FootballTAL.DataAccess
{
    public class CSVFileReading : IFileReading
    {
        private string FullPath { get; set; }
        public CSVFileReading(string path)
        {
            this.FullPath = path;
        }

        public IList<string[]> ReadFile()
        {
            List<string[]> fileContent = new List<string[]>();
            //use in-build csv parser from Microsoft
            using (TextFieldParser parser = new TextFieldParser(FullPath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields[0].ToString().ToLower() == "team" || fields[0].Contains("--"))
                        continue; //reach "----" or title row

                    fileContent.Add(fields);
                }
            }
            return fileContent;
        }
    }
}

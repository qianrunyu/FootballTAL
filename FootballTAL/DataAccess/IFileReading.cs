using FootballTAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTAL.DataAccess
{
    public interface IFileReading
    {
        IList<string[]> ReadFile();//ReadFile function can be called by CSV reader or other formats

    }
}
